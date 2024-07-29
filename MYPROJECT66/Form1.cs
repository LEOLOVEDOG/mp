using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYPROJECT66
{
    public partial class Form1 : Form
    { 
        List<Panel> listpanel = new List<Panel>();
        int index  ;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void lblsign_up_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                listpanel[index].SendToBack();
                index++; ;
            }
        }

        private void lblsgin_in_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listpanel[index].SendToBack();
                index--;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 door = new Form3();
            door.ShowDialog(this);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel[index=0 ].BringToFront();    
        }
    }
}
