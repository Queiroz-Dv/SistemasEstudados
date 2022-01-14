using System;
using System.Windows.Forms;

namespace DelegateStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void fillTextBox(int x);
        string textValue = "";
        
        public void FillMathNote(int ExamNote)
        {
            textValue += "Your Math Note is: " + ExamNote + Environment.NewLine;
        }
        public void FillChemistryNote(int ExamNote)
        {
            textValue += "You Chemistry Note is: " + ExamNote + Environment.NewLine;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ShowTextBox()
        {
            textBox1.Text = textValue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fillTextBox filltext = new fillTextBox(FillMathNote);
            filltext += FillChemistryNote;
            filltext(80);
            ShowTextBox();
        }
    }
}
