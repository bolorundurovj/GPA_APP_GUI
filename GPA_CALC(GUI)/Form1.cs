using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_CALC_GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(
"---------------------------FUTAs Grading System------------------------------\n|----------------------------------------------------------------------------|\n|           Mark/Score         |    Letter Grade    |   Grade Point (GP)     |\n|----------------------------------------------------------------------------|\n|        70% and Above         |          A         |         5.00           |\n|----------------------------------------------------------------------------|\n|           60  -  69          |          B         |         4.00           |\n|----------------------------------------------------------------------------|\n|           50  -  59          |          C         |         3.00           |\n|----------------------------------------------------------------------------|\n|           45  -  49          |          D         |         2.00           |\n|----------------------------------------------------------------------------|\n|           40  -  44          |          E         |         1.00           |\n|----------------------------------------------------------------------------|\n|            0  -  39          |          F         |         0.00           |\n|----------------------------------------------------------------------------|");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
