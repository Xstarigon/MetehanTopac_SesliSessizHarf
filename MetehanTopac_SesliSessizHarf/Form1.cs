using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetehanTopac_SesliSessizHarf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sesli = new string[8]
            {
                "a", "e", "ı", "i", "o", "ö", "u", "ü"
            };
        string[] sessiz = new string[21]
            {
                "z", "y", "v", "t", "ş", "s", "r", "p", "n", "r", "m", "l", "k", "h", "j", "ğ", "g", "d", "ç", "c", "b"
            };
        string kelime = "";
        private void button1_Click(object sender, EventArgs e)
        {
            kelime = textBox1.Text.ToLower();
            if(comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
          {
                if (comboBox1.SelectedIndex == 1)
                {
                    foreach (var harf in sesli)
                    {
                        if (kelime.Contains(harf))
                        {
                            listBox1.Items.Add(harf);
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    foreach (var harf in sessiz)
                    {
                        if (kelime.Contains(harf))
                        {
                            listBox1.Items.Add(harf);
                        }
                    }
                }
          } else
            {
                MessageBox.Show("Lütfen bir tercih yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("-- Seçiniz --");
            comboBox1.Items.Add("Sesliler");
            comboBox1.Items.Add("Sessizler");
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
