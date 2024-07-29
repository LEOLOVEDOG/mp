using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYPROJECT66
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void picbox_sl_Click(object sender, EventArgs e)
        {
            
        }

        private void picbox_sl_Click_1(object sender, EventArgs e)
        {
            
            STORE st = new STORE();
            st.MdiParent = this;
            st.Show();
            SetParent((int)st.Handle, (int)this.Handle);

        }
        [DllImport("user32")]
        public static extern int SetParent ( int hWnd, int hParent);

      

    }
}
