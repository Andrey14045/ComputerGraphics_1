using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Bitmap image;
        int n;// size of matr
        Stack<Bitmap> images = new Stack<Bitmap>();
        bool[,] matr = new bool[3, 3] { {false, true, false},
                                        {true, true, true},
                                        {false, true, false} };
        Form Form2;
        DataGridView DataGrid1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
            }
            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void иатричныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void гаусовскаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void вОттенкахСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScale();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Turn();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void cтеклоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Glass();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void идеальныйОтражательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Perfect();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Embosing();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void переносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Transfer();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void горизонтальныеВолныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new HorizintalWaves();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Png Image | *.png | JPeg Image | *.jpg | Bitmap Image | *.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    switch (dialog.FilterIndex)
                    {
                        case 1:
                            image.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case 2:
                            image.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case 3:
                            image.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                    }
                }
            }

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (images.Count != 0)
            {
                Bitmap oldImage = images.Pop();
                image = oldImage;
                pictureBox1.Image = oldImage;
                pictureBox1.Refresh();
            }
        }

        private void яркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Brightnes();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void фильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sobel();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void фильтрПрюиттаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Pruitt();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void размытиеВДвиженииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MoutionBlur();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Median(5);
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void сужениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MathMorfology.Erosion(image, matr);
            pictureBox1.Refresh();
        }

        private void расширениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MathMorfology.Dilation(image, matr);
            pictureBox1.Refresh();
        }

        private void открытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MathMorfology.Opening(image, matr);
            pictureBox1.Refresh();
        }

        private void закрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MathMorfology.Closing(image, matr);
            pictureBox1.Refresh();
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = MathMorfology.TopHat(image, matr);
            pictureBox1.Refresh();
        }

        private void линейноеРастяжениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearStretching();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void cерыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayWorld();
            backgroundWorker1.RunWorkerAsync(filter);
            images.Push(image);
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 3;
            matr = new bool[n, n];
            Form2 = new Form();
            Form2.Size = new Size(490, 360);
            Form2.Show();
            DataGrid1 = new DataGridView();
            DataGrid1.Size = new Size(320, 200);
            DataGrid1.ColumnCount = n;
            DataGrid1.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                DataGrid1.Columns[i].Width = 95;
                DataGrid1.Rows[i].Height = 50;
            }
            Form2.Controls.Add(DataGrid1);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    DataGrid1[i, j].Value = 1;

            DataGrid1.Show();
            Button Apply = new Button();
            Apply.Text = "Продолжить";
            Apply.Width = 90;
            Apply.Location = new Point(380, 245);
            Apply.Click += new EventHandler(button_click);
            Form2.Controls.Add(Apply);
            Apply.Show();
        }

        private void button_click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (DataGrid1[i, j].Value.ToString() == "0")
                        matr[i, j] = false;
                    else
                        matr[i, j] = true;
                }
            }
            Form2.Close();
            MessageBox.Show("Create mask " + n + " x " + n);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 5;
            matr = new bool[n, n];
            Form2 = new Form();
            Form2.Size = new Size(490, 360);
            Form2.Show();
            DataGrid1 = new DataGridView();
            DataGrid1.Size = new Size(320, 200);
            DataGrid1.ColumnCount = n;
            DataGrid1.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                DataGrid1.Columns[i].Width = 55;
                DataGrid1.Rows[i].Height = 35;
            }
            Form2.Controls.Add(DataGrid1);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    DataGrid1[i, j].Value = 1;
            DataGrid1.Show();
            Button Apply = new Button();
            Apply.Text = "Продолжить";
            Apply.Width = 90;
            Apply.Location = new Point(380, 245);
            Apply.Click += new EventHandler(button_click);
            Form2.Controls.Add(Apply);
            Apply.Show();
        }
    }
}
