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
    public partial class Form4 : Form
    {
        bool dupe = false, added = false;
        bool looper = true;
        string type, line;
        int test, idx, newid;
        List<int> IDs = new List<int>();

        Random rnd = new Random();
        public Form4()
        {/*load up ID's of all properties so when new one is added, no dupes are made*/
            InitializeComponent();
            StreamReader IDH = new StreamReader("Houselog.txt");
            StreamReader IDA = new StreamReader("Apartmentlog.txt");
            while (line != null)
            {
                for (int i = 0; i < 17; i++)
                {
                    line = IDH.ReadLine();
                    if (line != null)
                    {
                        switch (i)
                        {
                            case 0:
                                if (int.TryParse(line, out test)) { idx = test; }
                                break;
                           
                        }
                    }
                }
                if (line != null)
                {
                    IDs.Add(idx);
                }
            }
            IDH.Close();
            line = "";
            {
                for (int i = 0; i < 18; i++)
                {
                    line = IDA.ReadLine();
                    if (line != null)
                    {
                        switch (i)
                        {
                            case 0:
                                if (int.TryParse(line, out test)) { idx = test; }
                                break;

                        }
                    }
                }
                if (line != null)
                {
                    IDs.Add(idx);
                }
            }
            IDA.Close();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {/*clear all fields*/
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {/*select property type*/
            label10.Text = "";
            type = "house";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {/*select property type*/
            label10.Text = "per month";
            type = "apt";
        }

        private void button1_Click(object sender, EventArgs e)
        {/*add house to log*/
            if (type == "house")
            {
                using (StreamWriter hLog = File.AppendText("Houselog.txt"))
                {
                    //hLog.WriteLine("test");//works; write all info to file. Modify read in from form2
                    while (looper)
                    {
                        dupe = false;
                        newid = rnd.Next(1, 500);
                        foreach (int id in IDs)
                        {
                            if (id == newid)
                            {
                                dupe = true ;
                            }

                        }
                        if (!dupe) { looper = false; }
                    }
                    looper = true;
                    dupe = false;

                    hLog.WriteLine(newid);
                    hLog.WriteLine(textBox7.Text);
                    hLog.WriteLine(textBox9.Text);
                    hLog.WriteLine(textBox10.Text);
                    hLog.WriteLine(textBox11.Text);
                    hLog.WriteLine(textBox8.Text);
                    hLog.WriteLine(textBox1.Text);
                    hLog.WriteLine(textBox2.Text);
                    hLog.WriteLine(textBox3.Text);
                    hLog.WriteLine(textBox4.Text);
                    hLog.WriteLine(textBox5.Text);
                    hLog.WriteLine(textBox6.Text);
                    hLog.WriteLine(textBox13.Text);
                    hLog.WriteLine(textBox14.Text);
                    hLog.WriteLine(textBox15.Text);
                    hLog.WriteLine(textBox16.Text);
                    hLog.WriteLine(textBox17.Text);
                    added = true;
                    IDs.Add(newid);
                }
            }
                if (type == "apt") {
                using (StreamWriter ALog = File.AppendText("Apartmentlog.txt"))
                {/*add apartment to log*/
                    
                    while (looper)
                    {
                        dupe = false;
                        newid = rnd.Next(1, 500);
                        foreach (int id in IDs)
                        {
                            if (id == newid)
                            {
                                dupe = true;
                            }

                        }
                        if (!dupe) { looper = false; }
                    }
                    looper = true;
                    dupe = false;

                    ALog.WriteLine(newid);
                    ALog.WriteLine(textBox7.Text);
                    ALog.WriteLine(textBox9.Text);
                    ALog.WriteLine(textBox10.Text);
                    ALog.WriteLine(textBox11.Text);
                    ALog.WriteLine(textBox8.Text);
                    ALog.WriteLine(textBox1.Text);
                    ALog.WriteLine(textBox2.Text);
                    ALog.WriteLine(textBox3.Text);
                    ALog.WriteLine(textBox4.Text);
                    ALog.WriteLine(textBox5.Text);
                    ALog.WriteLine(textBox6.Text);
                    ALog.WriteLine(textBox13.Text);
                    ALog.WriteLine(textBox14.Text);
                    ALog.WriteLine(textBox15.Text);
                    ALog.WriteLine(textBox16.Text);
                    ALog.WriteLine(textBox17.Text);
                    ALog.WriteLine(textBox12.Text);
                    added = true;
                    IDs.Add(newid);
                }
            }
                if (type != "house" && type != "apt") {}

            if (added)
            {
                MessageBox.Show("Property added!", "Confirmation");
            }
            else {
                MessageBox.Show("There was an issue adding the property", "Confirmation");
            }
            added = false;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 main2 = new Form3();
            main2.ShowDialog();
            this.Close();
        }
    }
}
