﻿using System;
using System.Windows.Forms;

namespace InstallerApp
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void next_Click(object sender, EventArgs e)
        {
            this.Hide();
            information2 infor = new information2();
            infor.ShowDialog();
            this.Show();
            int a;
            int c;
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
