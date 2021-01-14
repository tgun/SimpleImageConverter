using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using ImageMagick;
namespace ImageConverter {
    public partial class MainForm : Form {
        private IMagickImage<ushort> _image;
        private MagickImageFactory _magicFactory;
        private MagickReadSettings _magicReadSettings;
        // -- For the primary Preview Window
        private IMagickImage<ushort> _magickImage;
        // -- For the bulk Converter.
        private List<IMagickImage<ushort>> _magicImages;

        public MainForm() {
            InitializeComponent();
            _magicFactory = new MagickImageFactory();
            _magicReadSettings = new MagickReadSettings { Density = new Density(300.0) };
            _magicImages = new List<IMagickImage<ushort>>();
        }

        private void button1_Click(object sender, EventArgs e) {
            var dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.No || dialogResult == DialogResult.Abort)
                return;

            _magickImage = _magicFactory.Create(new FileInfo(openFileDialog1.FileName), _magicReadSettings);
            _image = _magickImage;

            picPreview.Image = _magickImage.ToBitmap();
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (_image == null) {
                MessageBox.Show("You need to select a file first!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.No || dialogResult == DialogResult.Abort)
                return;

            _image.Write(saveFileDialog1.FileName, ImageMagick.MagickFormat.Png);
        }

        private void btnBulkImport_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.No || dialogResult == DialogResult.Abort)
                return;

            var files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.heic");

            lstBulk.Items.Clear();
            _magicImages.Clear();

            List<string> errorFiles = new List<string>();

            foreach (var file in files)
            {
                try
                {
                    IMagickImage<ushort> magickImage = _magicFactory.Create(new FileInfo(file), _magicReadSettings);
                    _magicImages.Add(magickImage);
                    lstBulk.Items.Add(magickImage.FileName);
                }
                catch
                {
                    errorFiles.Add(file);
                }
            }

            if (errorFiles.Any())
            {
                MessageBox.Show("There was an error opening the following files;\n" + string.Join("\n", errorFiles),
                    "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnBulkConvert_Click(object sender, EventArgs e) {
            if (!_magicImages.Any())
            {
                MessageBox.Show("You need to select a file first!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MagickFormat selectedFormat = MagickFormat.APng;
            string extension = "";

            switch (comboBox1.Items[comboBox1.SelectedIndex]) {
                case "PNG":
                    selectedFormat = MagickFormat.Png;
                    extension = ".png";
                    break;
                case "JPEG":
                    selectedFormat = MagickFormat.Jpg;
                    extension = ".jpg";
                    break;
                default:
                    MessageBox.Show("Hi edge case", "what");
                    break;
            }

            foreach (var mf in _magicImages) mf.Write(new FileInfo(mf.FileName + extension), selectedFormat);
            MessageBox.Show("Conversion Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
