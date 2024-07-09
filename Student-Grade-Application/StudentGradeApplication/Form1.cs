using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double english = double.Parse(textEnglish.Text);
            double math = double.Parse(textMath.Text);
            double science = double.Parse(textScience.Text);
            double filipino = double.Parse(textFilipino.Text);
            double history = double.Parse(textHistory.Text);

            double average = (english + math + science + filipino + history) / 5;
            average = Math.Round(average,2);

            string message = average >= 75.00 ? "passed." : "failed.";

            messageshow.Text = "The student " + message;
            string name = textName.Text;
            messageshow2.Text = "The averange of " + name + " is " + average;






        }
    }
}
