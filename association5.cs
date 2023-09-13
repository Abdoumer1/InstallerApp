using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallerApp
{
    public partial class association5 : Form
    {
        public association5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void back_Click(object sender, EventArgs e)
        {
            data4 parent = new data4();
            parent.ShowDialog();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Class.informations.filename = name.Text;
            Class.informations.filetype = type.Text;
            finish6 form = new finish6();
            form.ShowDialog();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "My Program File")
            {
                name.Text = "";
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
           if (name.Text == "")
            {
                name.Text = "My Program File";
            }
        }
    }
}
