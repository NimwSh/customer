using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nimw
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string tarikh = textBox2.Text;
            string model = textBox3.Text;
            string line = name + "," + tarikh + "," + model + "," +  "\n";
            File.AppendAllText("moshtari2.csv", line);
        }
    }
}
