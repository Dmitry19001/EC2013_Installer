using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EC2013_Installer;

namespace EC2013_Installer
{
    public partial class settings_menu : UserControl
    {
        public settings_menu()
        {
            InitializeComponent();
        }

        private void settings_menu_Load(object sender, EventArgs e)
        {

        }

        private void path_txt_MouseEnter(object sender, EventArgs e) //fast path for testing
        {
           // if (path_txt.Text == "")
             //   path_txt.Text = Path.Combine(Application.StartupPath, "need", "ec");
        }

        private void path_txt_MouseHover(object sender, EventArgs e)
        {
            path_txt.Height = 100;
        }

        private void path_txt_MouseLeave(object sender, EventArgs e)
        {
            path_txt.Height = 25;
        }

        private void path_txt_TextChanged(object sender, EventArgs e)
        {
            Vars.mod_path = path_txt.Text;
        }

        private void browse_btn_Click(object sender, EventArgs e) //mod directory select
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowDialog();

            if (FBD.SelectedPath != "")
            {
                path_txt.Text = FBD.SelectedPath;
            }
        }
    }
}
