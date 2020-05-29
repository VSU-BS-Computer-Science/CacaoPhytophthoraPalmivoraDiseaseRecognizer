using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;

namespace CacaoDiseaseRecognizer
{
    public partial class Form1 : Form
    {
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;
        Rectangle rect;
        HaralickGLCM haralickglcm;
        int g = 8, d = 1;
        public Form1()
        {
            InitializeComponent();
            resultBox.DataSource = Enum.GetValues(typeof(Status));
        }
        private void fullImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image File(*.jpg, *.bmp, *.png, *.gif)|*.jpg;*.bmp;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadImageBox.Image = new Bitmap(ofd.FileName);
                cropBox.Enabled = false;

            }
        }

        private void singleImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ofd.Filter = "Image files (*.png,*.jpg,*.jpeg,*.jfif,*.bmp,*.tif,*.tiff,*.gif)|*.png;*.jpg;*.jpeg;*.jfif;*.bmp;*.tif;*.tiff;*.gif";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                classifyBox.Image = Image.FromFile(ofd.FileName);
                cropBox.Image = classifyBox.Image;
                loadImageBox.Image = cropBox.Image;
                resultBox.Text = " ";
            }
        }

        private void folderedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
        }

        private void cropButton_Click(object sender, EventArgs e)
        {
            cropBox.Enabled = true;
            cropBox.Image = loadImageBox.Image;
            cropBox.Width = cropBox.Image.Width;
            cropBox.Height = cropBox.Image.Height;
        }

        private void cropBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                resultBox.Text = " ";
                cropBox.Refresh();
                classifyBox.Refresh();
                Graphics g = cropBox.CreateGraphics();
                rect = new Rectangle(new Point(e.X, e.Y), new Size(150, 150));
                g.DrawRectangle(new Pen(Brushes.Red), rect);
                Image img = cropBox.Image.Crop(rect);
                classifyBox.Image = img.Fit2PictureBox(cropBox);
            }
        }

        private void classify()
        {
            haralickglcm = new HaralickGLCM(ImageProcessing.grayscale(classifyBox.Image), g, d);
            if (haralickglcm != null)
            {
                if (haralickglcm.MeanF14 > 0.810434)
                {
                    if (haralickglcm.RangeF14 > 0.022991)
                    {
                        if (haralickglcm.MeanF3 > 84215.08293)
                        {
                            if (haralickglcm.RangeF3 > 107.372557)
                            {
                                if (haralickglcm.RangeF6 > 0.004285)
                                {
                                    if (haralickglcm.RangeF14 > 0.033765)
                                    {
                                        if (haralickglcm.RangeF3 > 225.352415)
                                        {
                                            if (haralickglcm.MeanF3 > 86897.84964)
                                            {
                                                if (haralickglcm.RangeF3 > 420.345385)
                                                {
                                                    if (haralickglcm.MeanF2 > 0.643759)
                                                    {
                                                        resultBox.SelectedItem = Status.Infected;
                                                    }
                                                    else if (haralickglcm.MeanF2 <= 0.643759)
                                                    {
                                                        resultBox.SelectedItem = Status.Healthy; 
                                                    }
                                                }
                                                else if (haralickglcm.RangeF3 <= 420.345385)
                                                {
                                                    resultBox.SelectedItem = Status.Infected; 
                                                }
                                            }
                                            else if (haralickglcm.MeanF3 <= 86897.84964)
                                            {
                                                resultBox.SelectedItem = Status.Healthy;
                                            }
                                        }
                                        else if (haralickglcm.RangeF3 <= 225.352415)
                                        {
                                            resultBox.SelectedItem = Status.Healthy; 
                                        }
                                    }
                                    else if (haralickglcm.RangeF14 <= 0.033765)
                                    {
                                        resultBox.SelectedItem = Status.Infected; 
                                    }
                                }
                                else if (haralickglcm.RangeF6 <= 0.004285)
                                {
                                    if (haralickglcm.RangeF4 > 0.012583)
                                    {
                                        if (haralickglcm.RangeF6 > 0.004022)
                                        {
                                            resultBox.SelectedItem = Status.Healthy; 
                                        }
                                        else if (haralickglcm.RangeF6 <= 0.004022)
                                        {
                                            if (haralickglcm.MeanF3 > 93841.41003)
                                            {
                                                if (haralickglcm.MeanF1 > 0.122648)
                                                {
                                                    resultBox.SelectedItem = Status.Infected; 
                                                }
                                                else if (haralickglcm.MeanF1 <= 0.122648)
                                                {
                                                    resultBox.SelectedItem = Status.Healthy; 
                                                }
                                            }
                                            else if (haralickglcm.MeanF3 <= 93841.41003)
                                            {
                                                resultBox.SelectedItem = Status.Infected; 
                                            }
                                        }
                                    }
                                    else if (haralickglcm.RangeF4 <= 0.012583)
                                    {
                                        resultBox.SelectedItem = Status.Healthy; 
                                    }
                                }
                            }
                            else if (haralickglcm.RangeF3 <= 107.372557)
                            {
                                resultBox.SelectedItem = Status.Healthy; 
                            }
                        }
                        else if (haralickglcm.MeanF3 <= 84215.08293)
                        {
                            if (haralickglcm.MeanF11 > 0.175617)
                            {
                                if (haralickglcm.MeanF6 > 8.720345)
                                {
                                    if (haralickglcm.MeanF11 > 0.340539)
                                    {
                                        if (haralickglcm.RangeF7 > 0.209472)
                                        {
                                            resultBox.SelectedItem = Status.Infected;
                                        }
                                        else if (haralickglcm.RangeF7 <= 0.209472)
                                        {
                                            if (haralickglcm.MeanF11 > 0.080821)
                                            {
                                                resultBox.SelectedItem = Status.Infected; 
                                            }
                                            else if (haralickglcm.MeanF11 <= 0.080821)
                                            {
                                                resultBox.SelectedItem = Status.Healthy; 
                                            }
                                        }
                                    }
                                    else if (haralickglcm.MeanF11 <= 0.340539)
                                    {
                                        if (haralickglcm.MeanF11 > 0.327348)
                                        {
                                            resultBox.SelectedItem = Status.Healthy; 
                                        }
                                        else if (haralickglcm.MeanF11 <= 0.327348)
                                        {
                                            if (haralickglcm.MeanF7 > 68.131014)
                                            {
                                                resultBox.SelectedItem = Status.Infected;
                                            }
                                            else if (haralickglcm.MeanF7 <= 68.131014)
                                            {
                                                if (haralickglcm.RangeF14 > 0.072043)
                                                {
                                                    resultBox.SelectedItem = Status.Infected; 
                                                }
                                                else if (haralickglcm.RangeF14 <= 0.072043)
                                                {
                                                    resultBox.SelectedItem = Status.Healthy; 
                                                }
                                            }
                                        }
                                    }
                                }
                                else if (haralickglcm.MeanF6 <= 8.720345)
                                {
                                    if (haralickglcm.MeanF1 > 0.312391)
                                    {
                                        if (haralickglcm.MeanF7 > 25.442828)
                                        {
                                            if (haralickglcm.MeanF8 > 0.559666)
                                            {
                                                resultBox.SelectedItem = Status.Healthy; 
                                            }
                                            else if (haralickglcm.MeanF8 <= 0.559666)
                                            {
                                                resultBox.SelectedItem = Status.Infected; 
                                            }
                                        }
                                        else if (haralickglcm.MeanF7 <= 25.442828)
                                        {
                                            resultBox.SelectedItem = Status.Infected; 
                                        }
                                    }
                                    else if (haralickglcm.MeanF1 <= 0.312391)
                                    {
                                        resultBox.SelectedItem = Status.Infected; 
                                    }
                                }
                            }
                            else if (haralickglcm.MeanF11 <= 0.175617)
                            {
                                if (haralickglcm.RangeF5 > 0.0215)
                                {
                                    resultBox.SelectedItem = Status.Healthy; 
                                }
                                else if (haralickglcm.RangeF5 <= 0.0215)
                                {
                                    resultBox.SelectedItem = Status.Infected; 
                                }
                            }
                        }
                    }
                    else if (haralickglcm.RangeF14 <= 0.022991)
                    {
                        resultBox.SelectedItem = Status.Infected; 
                    }


                }
                else if (haralickglcm.MeanF14 <= 0.810434)
                {
                    if (haralickglcm.MeanF7 > 43.022442)
                    {
                        if (haralickglcm.MeanF9 > 1.266173)
                        {
                            if (haralickglcm.RangeF2 > 0.254959)
                            {
                                resultBox.SelectedItem = Status.Infected; 
                            }
                            else if (haralickglcm.RangeF2 <= 0.254959)
                            {
                                resultBox.SelectedItem = Status.Healthy; 
                            }
                        }
                        else if (haralickglcm.MeanF9 <= 1.266173)
                        {
                            if (haralickglcm.MeanF7 > 130.081531)
                            {
                                resultBox.SelectedItem = Status.Healthy;
                            }
                            else if (haralickglcm.MeanF7 <= 130.081531)
                            {
                                if (haralickglcm.MeanF12 > -0.159637)
                                {
                                    resultBox.SelectedItem = Status.Healthy; 
                                }
                                else if (haralickglcm.MeanF12 <= -0.159637)
                                {
                                    if (haralickglcm.RangeF7 > 0.100611)
                                    {
                                        if (haralickglcm.MeanF11 > 0.293679)
                                        {
                                            if (haralickglcm.RangeF14 > 0.041102)
                                            {
                                                if (haralickglcm.MeanF6 > 8.858041)
                                                {
                                                    if (haralickglcm.RangeF2 > 0.117879)
                                                    {
                                                        if (haralickglcm.RangeF2 > 0.239765)
                                                        {
                                                            if (haralickglcm.MeanF2 > 0.822905)
                                                            {
                                                                resultBox.SelectedItem = Status.Infected; 
                                                            }
                                                            else if (haralickglcm.MeanF2 <= 0.822905)
                                                            {
                                                                resultBox.SelectedItem = Status.Healthy; 
                                                            }
                                                        }
                                                        else if (haralickglcm.RangeF2 <= 0.239765)
                                                        {
                                                            if (haralickglcm.MeanF6 > 10.722359)
                                                            {
                                                                if (haralickglcm.RangeF7 > 0.307628)
                                                                {
                                                                    if (haralickglcm.MeanF12 > -0.288538)
                                                                    {
                                                                        resultBox.SelectedItem = Status.Infected; 
                                                                    }
                                                                    else if (haralickglcm.MeanF12 <= -0.288538)
                                                                    {
                                                                        resultBox.SelectedItem = Status.Healthy; 
                                                                    }
                                                                }
                                                                else if (haralickglcm.RangeF7 <= 0.307628)
                                                                {
                                                                    if (haralickglcm.MeanF3 > 96278.68961)
                                                                    {
                                                                        resultBox.SelectedItem = Status.Healthy; 
                                                                    }
                                                                    else if (haralickglcm.MeanF3 <= 96278.68961)
                                                                    {
                                                                        resultBox.SelectedItem = Status.Infected; 
                                                                    }
                                                                }
                                                            }
                                                            else if (haralickglcm.MeanF6 <= 10.722359)
                                                            {
                                                                resultBox.SelectedItem = Status.Healthy; 
                                                            }
                                                        }
                                                    }
                                                    else if (haralickglcm.RangeF2 <= 0.117879)
                                                    {
                                                        if (haralickglcm.MeanF5 > 0.82149)
                                                        {
                                                            resultBox.SelectedItem = Status.Infected; 
                                                        }
                                                        else if (haralickglcm.MeanF5 <= 0.82149)
                                                        {
                                                            if (haralickglcm.MeanF5 > 0.814006)
                                                            {
                                                                resultBox.SelectedItem = Status.Healthy; 
                                                            }
                                                            else if (haralickglcm.MeanF5 <= 0.814006)
                                                            {
                                                                if (haralickglcm.RangeF7 > 0.171803)
                                                                {
                                                                    resultBox.SelectedItem = Status.Infected; 
                                                                }
                                                                else if (haralickglcm.RangeF7 <= 0.171803)
                                                                {
                                                                    if (haralickglcm.MeanF1 > 0.214119)
                                                                    {
                                                                        resultBox.SelectedItem = Status.Infected; 
                                                                    }
                                                                    else if (haralickglcm.MeanF1 <= 0.214119)
                                                                    {
                                                                        resultBox.SelectedItem = Status.Healthy; 
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (haralickglcm.MeanF6 <= 8.858041)
                                                {
                                                    if (haralickglcm.MeanF1 > 0.210067)
                                                    {
                                                        resultBox.SelectedItem = Status.Healthy; 
                                                    }
                                                    else if (haralickglcm.MeanF1 <= 0.210067)
                                                    {
                                                        if (haralickglcm.RangeF6 > 0.004217)
                                                        {
                                                            resultBox.SelectedItem = Status.Infected; 
                                                        }
                                                        else if (haralickglcm.RangeF6 <= 0.004217)
                                                        {
                                                            if (haralickglcm.MeanF6 > 8.061608)
                                                            {
                                                                resultBox.SelectedItem = Status.Healthy;
                                                            }
                                                            else if (haralickglcm.MeanF6 <= 8.061608)
                                                            {
                                                                resultBox.SelectedItem = Status.Infected;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            else if (haralickglcm.RangeF14 <= 0.041102)
                                            {
                                                resultBox.SelectedItem = Status.Infected; 
                                            }
                                        }
                                        else if (haralickglcm.MeanF11 <= 0.293679)
                                        {
                                            resultBox.SelectedItem = Status.Healthy; 
                                        }
                                    }
                                    else if (haralickglcm.RangeF7 <= 0.100611)
                                    {
                                        if (haralickglcm.MeanF2 > 0.686168)
                                        {
                                            if (haralickglcm.MeanF12 > -0.207568)
                                            {
                                                resultBox.SelectedItem = Status.Infected;
                                            }
                                            else if (haralickglcm.MeanF12 <= -0.207568)
                                            {
                                                resultBox.SelectedItem = Status.Healthy; 
                                            }
                                        }
                                        else if (haralickglcm.MeanF2 <= 0.686168)
                                        {
                                            resultBox.SelectedItem = Status.Healthy; 
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (haralickglcm.MeanF7 <= 43.022442)
                    {
                        if (haralickglcm.MeanF8 > 0.504057)
                        {
                            if (haralickglcm.MeanF14 > 0.61011)
                            {
                                resultBox.SelectedItem = Status.Infected; 
                            }
                            else if (haralickglcm.MeanF14 <= 0.61011)
                            {
                                if (haralickglcm.MeanF2 > 0.631352)
                                {
                                    resultBox.SelectedItem = Status.Infected;
                                }
                                else if (haralickglcm.MeanF2 <= 0.631352)
                                {
                                    resultBox.SelectedItem = Status.Healthy; 
                                }

                            }
                        }
                        else if (haralickglcm.MeanF8 <= 0.504057)
                        {
                            resultBox.SelectedItem = Status.Healthy; 
                        }
                    }

                }

            }
        }

        private void classifyButoon_Click(object sender, EventArgs e)
        {
            classify();
        }

        private void SetClassifyBoxImage(Image i)
        {
            classifyBox.Image = i;
        }

        delegate void SetClassifyBoxCallBack(Image i);

        private void bulkClassifyButton_Click_1(object sender, EventArgs e)
        {
            string[] file_extensions = new string[8] { "*.png", "*.jpg", "*.jpeg", "*.jfif", "*.bmp", "*.tif", "*.tiff", "*.gif" };
            //string[] 
            IEnumerable<string> filenames = new List<string>();
            foreach (string s in file_extensions)
                filenames = filenames.Concat(Directory.GetFiles(fbd.SelectedPath, s, SearchOption.AllDirectories).ToList());

            string to_write = "";

            to_write += "filename,";
            to_write += "recognition\n";
            List<Image> images = new List<Image>();

            foreach (string filename in filenames)
                images.Add(Image.FromFile(filename));

            for (int ctr = 0; ctr < images.Count; ctr++)
            {
                if (classifyBox.InvokeRequired)
                {
                    SetClassifyBoxCallBack c = new SetClassifyBoxCallBack(SetClassifyBoxImage);
                    this.Invoke(c, new object[] { images[ctr] });
                }
                else
                    classifyBox.Image = images[ctr];

                classify();
                to_write += Path.GetFileName(filenames.ElementAt(ctr)) + ",";
                to_write += resultBox.Text.ToString() + "\n";
                haralickglcm = null;
                classifyBox.Refresh();
            }

            StreamWriter sw = new StreamWriter(fbd.SelectedPath + "\\recognitions.csv");
            sw.Write(to_write);
            sw.Close();
            Console.WriteLine("Finished!");
            MessageBox.Show("Recognition Finished!\n Look at your results at:\n" + fbd.SelectedPath + "\\recognitions.csv");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm x = new AboutForm();
            x.Show();
        }

    }

    public enum Status { Healthy, Infected }
}
