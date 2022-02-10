using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PictureBoxApp.Properties;

namespace PictureBoxApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            OpenImageFromFile(settings.FilePath);
            if (settings.FilePath != "")
                ofdFileOpen.FileName = settings.FilePath.Substring(settings.FilePath.LastIndexOf("\\") + 1); 
            flushToolStripMenuItem.Visible = pbPictureDisplay.Image != null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ofdFileOpen.ShowDialog() == DialogResult.OK)
            {
                OpenImageFromFile(ofdFileOpen.FileName);
            }
        }



        private void pnlPictureBoxContainer_Resize(object sender, EventArgs e)
        {
        }

        private Bitmap _image;

        private void flushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbPictureDisplay.Image = null;
            settings.FilePath = "";
            settings.Save();
        }

        private void pbPictureDisplay_Paint(object sender, PaintEventArgs e)
        {
            flushToolStripMenuItem.Visible = pbPictureDisplay.Image != null;


        }
        private void OpenImageFromFile(string filePath)
        {
            if (filePath != "")
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        _image?.Dispose();
                        _image = new Bitmap(fs);
                        pbPictureDisplay.Image = _image;
                        settings.FilePath = filePath;
                        settings.Save();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show($"Nie udało się wczytać pliku {filePath}");
                }
            }

        }
        Settings settings = new Settings();


        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            OpenImageFromFile(files[0]);

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
    }
}
