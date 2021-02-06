using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometric_Proof_Calculator
{

    public partial class step1 : Form
    {

        public string input;

        public step1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) {input = figureNameTB.Text;}
        private void button1_Click(object sender, EventArgs e) 
        {
            if (figureNameTB.TextLength >= 3)
            {
                info.Text = "Current information:" + "\n> FIGURE: " + input;
                warnings.Text = "Warnings: All systems online.";
            }
            else
            {
                warnings.Text = "Warnings:" + " Your figure size is too small!";
            }
        }
    }
}
