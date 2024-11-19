using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public int test = 1;

        public Form1()
        {
            this.test = 1;

            InitializeComponent();

            Gebruiker gebruiker = new Gebruiker();
            gebruiker.voornaam = "test";
            gebruiker.achternaam = "test";
            string test = gebruiker.info();
        }
    }
}
