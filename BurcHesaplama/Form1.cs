using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurcHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string burc;
            int gun = Convert.ToInt32(comboBox2.Text);
            string ay = Convert.ToString(comboBox1.Text);
            if ((gun >= 22 && ay == "Aralık") || (gun <= 20 && ay =="Ocak"))
            {
                burc = "Oğlak";
                textBox3.Text = burc;
               
            }
           if ((gun >= 21 && ay == "Ocak") ||( gun <= 19 && ay == "Şubat"))
            {
                burc = "Kova";
                textBox3.Text = burc;
            }
            if ((gun >= 20 && ay == "Şubat") || (gun <= 20 && ay == "Mart"))
            {
                burc = "Balık";
                textBox3.Text = burc;
            }
            if ((gun >= 21 && ay == "Mart") || (gun <= 20 && ay == "Nisan"))
            {
                burc = "Koç";
                textBox3.Text = burc;
            }
             if ((gun >= 20 && ay == "Nisan") || (gun <= 20 && ay == "Mayıs"))
            {
                burc = "Boğa";
                textBox3.Text = burc;
            //    pictureBox1.Image = Image.FromFile(C:\\Users\melek.sagir\Pictures\Screenshots);
            }
            if ((gun >= 21 && ay == "Mayıs") || (gun <= 21 &&  ay == "Haziran"))
            {
                burc = "İkizler";
                textBox3.Text = burc;
            }
            if ((gun >= 23 && ay == "Haziran" )|| (gun <= 22 &&  ay == "Temmuz"))
            {
                burc = "Yengeç";
                textBox3.Text = burc;

            }
            if ((gun >= 22 && ay == "Temmuz") || (gun <= 23 &&  ay == "Ağustos"))
            {
                burc = "Aslan";
                textBox3.Text = burc;
            }
             if ((gun >= 23 && ay == "Ağustos" )||( gun <= 23 && ay == "Eylül"))
            {
                burc = "Başak";
                textBox3.Text = burc;
            }
            if ((gun >= 23 && ay == "Eylül") ||( gun <= 23 &&ay == "Ekim"))
            {
                burc = "Terazi";
                textBox3.Text = burc;
            }
            if ((gun >= 23 && ay == "Ekim") ||( gun <= 22 && ay == "Kasım"))
            {
                burc = "Akrep";
                textBox3.Text = burc;
            }
            if((gun >= 22 && ay == "Kasım") || (gun <= 21 && ay == "Aralık"))
            {
                burc = "Yay";
                textBox3.Text = burc;
            }

        }
    }
}
