using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinaq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = "Salam qaqas necesen? ele bildim cucesen :)";
            }
            if(checkBox2.Checked)
            {
                label1.Text = "Agilli olun hormetli olun :)";
            }
           
        }
    }
}
