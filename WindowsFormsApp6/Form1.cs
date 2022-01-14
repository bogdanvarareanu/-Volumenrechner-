using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private Quader test1 = new Quader();
        private Zylinder test2 = new Zylinder();

        public Form1()
        {
            InitializeComponent();
        }
        private int x;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        
                        Quader.Visible = true;
                        Zylinder.Visible = false;
                        numericUpDown3.Visible = true;
                        label3.Visible = true;
                        label1.Text = "a";
                        label2.Text = "b";
                            label3.Text = "c";
                        x = 0;
                        label4.Text = "";


                    }
                    break;
                case 1:
                    {
                        Zylinder.Visible = true;
                        Quader.Visible = false;
                        numericUpDown3.Visible = false;
                        label3.Visible = false;
                        label1.Text = "r";
                        label2.Text = "h";
                        x = 1;
                        label4.Text = "";
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { if(x==0)
            { test1.set_Laenge(Convert.ToDouble(numericUpDown1.Value));
                test1.set_Breite(Convert.ToDouble(numericUpDown2.Value));
                test1.set_Hoehe1(Convert.ToDouble(numericUpDown3.Value));

                label4.Text = Convert.ToString(test1.get_VolQ()) + " cm³";




            }
            if (x == 1)
            {
                test2.set_Radius(Convert.ToDouble(numericUpDown1.Value));
                test2.set_Hoehe(Convert.ToDouble(numericUpDown2.Value));
               

                label4.Text = Convert.ToString(test2.get_VolZ()) + " cm³";




            }

        }

        private void Zylinder_Click(object sender, EventArgs e)
        {

        }
    }
}
