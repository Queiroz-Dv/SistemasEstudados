using System;
using System.Windows.Forms;
using System.IO;

namespace FileStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FileInfo ourfile = new FileInfo("secondfile.txt");
            ourfile.Create();
            MessageBox.Show("The file was created");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete("Firstfile.txt");
            MessageBox.Show("The file was deleted");
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is the first line written");
            sw.WriteLine("This is the second line written");
            sw.WriteLine("This is the fourth line written");
            sw.WriteLine("This is the fifth line written");
            sw.WriteLine("This is the sixth line written");
            sw.WriteLine("This is the seventh line written");
            sw.WriteLine("This is the eighth line written");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while(!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            textBox1.Text = text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy("secondfile.txt", @"C:\secondfile.txt");
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            FileInfo ourfile = new FileInfo("seconfile.txt");
            string name = ourfile.Name;
            MessageBox.Show(name);
        }
    }
}
