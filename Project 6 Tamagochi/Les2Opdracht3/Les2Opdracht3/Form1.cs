﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2Opdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void wisselOm(int getalA, int getalB)
        {
            txtGetalA.Text = getalB.ToString();
            txtGetalB.Text = getalA.ToString();
        }
        private void btnWisselOm_Click(object sender, EventArgs e)
        {
            wisselOm(int.Parse(txtGetalA.Text), int.Parse(txtGetalB.Text));
           
        }
     
    }
}
