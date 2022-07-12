using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TimelapseThatFolder
{
    public partial class formMain : Form
    {
        private int _imageIndex = -1;

        private bool _isRunning = false;
        private bool _playForward = true;

        private string _imagePath = string.Empty;

        private List<string> _imageFiles = new List<string>();

        public formMain()
        {
            InitializeComponent();
        }

        public formMain(string imagePath)
        {
            InitializeComponent();

            _imagePath = imagePath;
            textBoxImagePath.Text = imagePath;

            if (Directory.Exists(textBoxImagePath.Text))
            {
                _imagePath = textBoxImagePath.Text;
                _imageFiles = Directory.GetFiles(_imagePath).ToList();
                _imageIndex = 0;
            }
            else
            {
                MessageBox.Show("Image Path Does Not Exist!", "Invalid Image Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isRunning = true;
            workerImageLoader.RunWorkerAsync();
        }

        #region Button Handlers

        private void buttonForward_Click(object sender, EventArgs e)
        {
            _playForward = true;

            if (string.IsNullOrEmpty(_imagePath)) // first run
            {
                if (Directory.Exists(textBoxImagePath.Text))
                {
                    _imagePath = textBoxImagePath.Text;
                    _imageFiles = Directory.GetFiles(_imagePath).ToList();
                    _imageIndex = 0;
                }
                else
                {
                    MessageBox.Show("Image Path Does Not Exist!", "Invalid Image Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!_isRunning)
            {
                if (_imagePath == textBoxImagePath.Text) // path is the same
                {
                    _isRunning = true;
                    workerImageLoader.RunWorkerAsync();

                }
                else // new path, reset
                {
                    if (Directory.Exists(textBoxImagePath.Text))
                    {
                        _imagePath = textBoxImagePath.Text;
                        _imageFiles = Directory.GetFiles(_imagePath).ToList();
                        _imageIndex = 0;

                        workerImageLoader.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("Image Path Does Not Exist!", "Invalid Image Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            else
            {
                // already going forward, ignore
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _isRunning = false;
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            _playForward = false;

            if (string.IsNullOrEmpty(_imagePath)) // first run
            {
                if (Directory.Exists(textBoxImagePath.Text))
                {
                    _imagePath = textBoxImagePath.Text;
                    _imageFiles = Directory.GetFiles(_imagePath).ToList();
                    _imageIndex = _imageFiles.Count - 1;
                }
                else
                {
                    MessageBox.Show("Image Path Does Not Exist!", "Invalid Image Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!_isRunning)
            {
                if (_imagePath == textBoxImagePath.Text) // path is the same
                {
                    _isRunning = true;
                    workerImageLoader.RunWorkerAsync();

                }
                else // new path, reset
                {
                    if (Directory.Exists(textBoxImagePath.Text))
                    {
                        _imagePath = textBoxImagePath.Text;
                        _imageFiles = Directory.GetFiles(_imagePath).ToList();
                        _imageIndex = _imageFiles.Count - 1;

                        workerImageLoader.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("Image Path Does Not Exist!", "Invalid Image Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }
            else
            {
                // already going forward, ignore
            }

            _playForward = false;
        }

        private void buttonCopyImage_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
           
            Clipboard.SetImage(pictureBox.Image);
        }

        private void buttonCopyFilePath_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(_imageFiles[_imageIndex]);
        }

        private void buttonCopyFile_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetFileDropList(new StringCollection() { _imageFiles[_imageIndex] });
        }

        #endregion 

        #region Background Worker Methods
        private void workerImageLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = _imageFiles[_imageIndex];

            e.Result = Image.FromFile(filePath);
        }

        private void workerImageLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox.Image = e.Result as Image;
            labelImagePosition.Text = $"{_imageIndex + 1}/{_imageFiles.Count}";
            _imageIndex = _playForward ? _imageIndex + 1 : _imageIndex - 1;

            GC.Collect(); // 64gb of RAM was able to load quite a few 5mb images before exploding...  Turn this off and watch in Control Panel!

            if (_imageIndex < _imageFiles.Count && _isRunning)
            {
                workerImageLoader.RunWorkerAsync();
            }
        }

        #endregion

    }



}
