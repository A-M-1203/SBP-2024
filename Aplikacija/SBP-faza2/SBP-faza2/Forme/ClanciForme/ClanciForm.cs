﻿using SBP_faza2.Forme.AutoriForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_faza2.Forme.ClanciForme
{
    public partial class ClanciForm : Form
    {
        public ClanciForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajClankeForm dodajClankeForma = new DodajClankeForm();
            dodajClankeForma.ShowDialog(this);
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            AzurirajClankeForm azurirajClankeForma = new AzurirajClankeForm();
            azurirajClankeForma.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoriForm autoriForma = new AutoriForm();
            autoriForma.ShowDialog(this);
        }
    }
}