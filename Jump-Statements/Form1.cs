using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ************* BREAK STATEMENT *************

            string ivalue = "";

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    break;
                    ivalue += " " + i + " ";
                
            }
            MessageBox.Show(ivalue);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // ************* CONTINUE STATEMENT *************

            string ivalue = "";

            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue;
                ivalue += " " + i + " ";

            }
            MessageBox.Show(ivalue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ************* GO TO STATEMENT *************
            string messageText = "";
            int x = 3;

            switch (x)
            {
                case 1:
                    messageText = "You entered 1";
                    break;
                case 2:
                    messageText = "You entered 2";
                    break;
                case 3:
                    messageText = "You entered 3";
                    goto case 2;
                default:
                    messageText = "you entered 4";
                    break;
            }
            MessageBox.Show(messageText);
        }
    }
}
