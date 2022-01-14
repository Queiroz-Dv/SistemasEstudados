using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandlingStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(txtFirst.Text) / Convert.ToInt32(txtSecond.Text);
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("You can not divide any number to zero");
            }
            catch (Exception ex)
            {
                throw new Exception("Please use any numbers");
            }
            finally
            {
                MessageBox.Show("Program was finished");
            }
        }
    }
}
