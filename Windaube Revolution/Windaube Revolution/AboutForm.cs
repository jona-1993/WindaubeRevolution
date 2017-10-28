using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Windaube_Revolution
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            System.Media.SystemSounds.Asterisk.Play();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
