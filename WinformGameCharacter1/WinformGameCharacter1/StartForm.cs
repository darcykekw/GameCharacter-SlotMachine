using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformGameCharacter1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void txtStart_Click(object sender, EventArgs e)
        {
            Game select = new Game();
            this.Hide();
            select.Show();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
