﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nimw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string family = textBox2.Text;
            string phone = textBox3.Text;
            string city = textBox4.Text;
            string line = name + "," + family + "," + phone + "," + city + "\n";
            File.AppendAllText("moshtari.csv", line);



        }
        
        }
           
    }
