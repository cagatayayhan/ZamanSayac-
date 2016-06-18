using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZamanSayacı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _Saniye = 0;
        int _Dakika = 0;
        int _Saat = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {

            _Saniye++;
            if (_Saniye == 60)
            {
                _Saniye = 0;
                _Dakika++;
            }


            if (_Dakika == 60)
            {
                _Dakika = 0;
                _Saat++;
            }


            // Düzenleme:
            if (_Saat == 24)
            {
                _Saat = 0;
                _Dakika = 0;
                _Saniye = 0;
            }

            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", _Saat, _Dakika, _Saniye);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Başla")
            {
                timer1.Start();
                button1.Text = "Dur";
            }
            else
            {
                // Başla butonuna her basılışında sayacı 
                // sıfırlamak için aşağıdaki kodu aktive edin:


                /*
                _Saniye = 0;
                _Dakika = 0;
                _Saat = 0;
                */

                timer1.Stop();
                button1.Text = "Başla";

            }
        }
    }
}
