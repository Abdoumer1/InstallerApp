using System;
using System.Windows.Forms;

namespace InstallerApp
{
    public partial class information2 : Form
    {
        public information2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            start parent = new start();
            parent.ShowDialog();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Class.informations.appname = name.Text;
            Class.informations.appver = ver.Text;
            Class.informations.apppubl = publ.Text;
            Class.informations.appweb = web.Text;
            local3 form = new local3();
            form.ShowDialog();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "My Program")
            {
                name.Text = "";
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "My Program";
            }
        }

        private void ver_Enter(object sender, EventArgs e)
        {
            if (ver.Text == "1.0")
            {
                ver.Text = "";
            }
        }

        private void ver_Leave(object sender, EventArgs e)
        {
            if (ver.Text == "")
            {
                ver.Text = "1.0";
            }
        }

        private void publ_Enter(object sender, EventArgs e)
        {
            if (publ.Text == "My company,inc")
            {
                publ.Text = "";
            }
        }

        private void publ_Leave(object sender, EventArgs e)
        {
            if (publ.Text == "")
            {
                publ.Text = "My company,inc";
            }
        }

        private void web_Enter(object sender, EventArgs e)
        {
            if (web.Text == "http://www.example.com/")
            {
                web.Text = "";
            }
        }

        private void web_Leave(object sender, EventArgs e)
        {
            if (web.Text == "")
            {
                web.Text = "http://www.example.com/";
            }
        }


    }
}
