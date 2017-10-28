using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windaube_Revolution
{
    public partial class ErrorForm : Form
    {
        public int Confirmation = 0;

        public ErrorForm()
        {
            InitializeComponent();

            System.Media.SystemSounds.Exclamation.Play();
        }

        public ErrorForm(Point axis, bool mute)
        {
            InitializeComponent();

            this.Location = axis;

            if (mute == false)
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }


        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);


        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //return DialogResult.OK;

            Confirme = 1;

            Close();
        }

        public int Confirme
        {
            set { Confirmation = value; }
            get { return Confirmation; }
        }

        private void OKButton_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;

            Confirme = 0;
        }

        private void ErrorForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;

            Confirme = 0;
        }
    }
}
