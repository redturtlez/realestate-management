using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        //OpenFileDialog openFile = new OpenFileDialog();
        
   
        public static bool auth = false;
        public Form1()
        {
            InitializeComponent();
        }
        

       
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Jonathan"|| textBox1.Text == "Simone") && textBox2.Text == "password")
            {/*test to see if user login is true*/
                auth = true;

                this.Hide();
                Form3 main2 = new Form3();
                main2.ShowDialog();
                this.Close();
               
            }
            else { label4.Text = "Invalid information"; }
        }

        private void label3_Click(object sender, EventArgs e)
        {/*move on to non auth users section*/
            this.Hide();
            Form2 main = new Form2();
            main.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {/*hide password*/
            textBox2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {/*allow password to be seen to make sure its spelled right*/
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {/*Stop windows ring sound*/
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
                
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {/*Stop windows ring sound*/
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.PerformClick();
               
            }
        }
    }
}
