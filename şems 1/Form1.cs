using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şems_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas, bitis, b1, b2;
            
            bitis = Convert.ToInt32(txbxBit.Text);
            bas = Convert.ToInt32(txbxİlk.Text);
            b1 = Convert.ToInt32(txbx1Bol.Text);
            b2 = Convert.ToInt32(txbx2Bol.Text);
            for (int i = bas; i < bitis; i++ )
            {
                if (i % b1 == 0)
                {
                    lxbx1.Items.Add(i);
                }
                if (i % b2 == 0)
                {
                    lxbx2.Items.Add(i);
                }
               

            }


        }


    }
}
