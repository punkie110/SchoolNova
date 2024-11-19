﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les6Opdracht1
{
    public partial class Invoer : Form
    {
        public Invoer()
        {
            InitializeComponent();
        }
        public int laatsteId;
       

        private void Invoer_Load(object sender, EventArgs e)
        {
            cbxKlas.Items.Clear();
            foreach (Klas klas in Klas.getAll())
            {

                cbxKlas.Items.Add(klas.Klascode);
            }
            foreach (Kluis kluis in Kluis.getAll())
            {

                cbxKluisnr.Items.Add(kluis.KluisNr);
            }
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Student.addStudent(txtVoornaam.Text, txtAchternaam.Text, int.Parse(txtStudentnr.Text), (string)cbxKlas.SelectedItem);
            laatsteId = Student.getLast();
            Kluis.addKluisreservering(int.Parse(cbxKluisnr.Text), laatsteId);
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }
    }
}