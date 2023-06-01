using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
            int kasa = Convert.ToInt32(label8.Text);
            int bahis = Convert.ToInt32(textBox1.Text);
            label8.Text = Convert.ToString(kasa - bahis);
            if (Convert.ToInt32(label8.Text) < 0)
            {
                label8.Text = Convert.ToString(100);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int kasa = Convert.ToInt32(label8.Text);
            int bahis = Convert.ToInt32(textBox1.Text);
            pictureBox1.Left = pictureBox1.Left + rand.Next(5, 30);
            pictureBox2.Left = pictureBox2.Left + rand.Next(5, 30);
            pictureBox3.Left = pictureBox3.Left + rand.Next(5, 30);
            if(pictureBox1.Left + pictureBox1.Width >= label5.Left)
            {
                if (radioButton1.Checked == true)
                {
                    timer1.Stop();
                    kasa = bahis * 2 + kasa+bahis;
                    label12.Text = ("Kazandınız!!");
                    label14.Text = Convert.ToString(bahis * 2);
                    label8.Text=Convert.ToString(kasa);

                }
                if (radioButton2.Checked == true)
                {
                    timer1.Stop();
                    kasa = kasa;
                    label12.Text = ("Kaybettiniz!!");
                    label14.Text = Convert.ToString(0);
                    label8.Text = Convert.ToString(kasa);

                }
                else if (radioButton3.Checked == true)
                {
                    timer1.Stop();
                    kasa = kasa;
                    label12.Text = ("Kaybettiniz!!");
                    label14.Text = Convert.ToString(0);
                    label8.Text = Convert.ToString(kasa);

                }
                timer1.Stop();
                
                MessageBox.Show("1. At kazandı!");
                listBox1.Items.Add("1. At");
            }
            
            else if (pictureBox2.Left + pictureBox2.Width >= label5.Left)
            {
                if (radioButton2.Checked == true)
                {
                    timer1.Stop();
                    kasa = bahis * 2 + kasa + bahis;
                    label12.Text = ("Kazandınız!!");
                    label14.Text = Convert.ToString(bahis * 2);
                    label8.Text = Convert.ToString(kasa);

                }
                else if (radioButton1.Checked == true)
                {
                    timer1.Stop();
                    kasa = kasa;
                    label12.Text = ("Kaybettiniz!!");
                    label14.Text = Convert.ToString(0);
                    label8.Text = Convert.ToString(kasa);

                }
                else if (radioButton3.Checked == true)
                {
                    timer1.Stop();
                    kasa = kasa;
                    label12.Text = ("Kaybettiniz!!");
                    label14.Text = Convert.ToString(0);
                    label8.Text = Convert.ToString(kasa);

                }
                timer1.Stop();
                MessageBox.Show("2. At kazandı!");
                listBox1.Items.Add("2. At");
            }
            else if (pictureBox3.Left + pictureBox3.Width >= label5.Left)
            {
                if (radioButton3.Checked == true)
                {
                    timer1.Stop();
                    kasa = bahis * 2 + kasa + bahis;
                    label12.Text = ("Kazandınız!!");
                    label14.Text = Convert.ToString(bahis * 2);
                    label8.Text = Convert.ToString(kasa);

                }
                if (radioButton2.Checked == true)
                {
                    timer1.Stop();
                    kasa = kasa;
                    label12.Text = ("Kaybettiniz!!");
                    label14.Text = Convert.ToString(0);
                    label8.Text = Convert.ToString(kasa);

                }
                if (radioButton1.Checked == true)
                {
                    timer1.Stop();
                    kasa = kasa;
                    label12.Text = ("Kaybettiniz!!");
                    label14.Text = Convert.ToString(0);
                    label8.Text = Convert.ToString(kasa);

                }
                timer1.Stop();
                MessageBox.Show("3. At kazandı!");
                listBox1.Items.Add("3. At");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(-1, 46);
            pictureBox2.Location = new Point(-1, 244);
            pictureBox3.Location = new Point(-1, 418);
        }
    }
}
