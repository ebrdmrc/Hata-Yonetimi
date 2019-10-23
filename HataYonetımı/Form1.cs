using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataYonetımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHatayonetimsiz_Click(object sender, EventArgs e)
        {
            int telefonNumarasi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
        }

        private void BtnhataYonetimli_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
            }
            catch
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatlagiriniz");


            }

        }

        private void BtnhataYonetimliMesaj1_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatlagiriniz");
                //loglama 
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnhataYonetimliMesaj2_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
            }
            catch (DivideByZeroException ex) //sıfıra bölünme hatası
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatlagiriniz");
                //loglama 
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex) //format hatası
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatlagiriniz");
                //loglama 
                MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatlagiriniz");
                //loglama 
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnhataYonetimliFinally_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, Telefon numaranı sisteme girebildin!");
            }
            catch
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatlagiriniz");
}
            finally
            {
                MessageBox.Show("Bu alan içerisinde yer alan kod blokları her zaman çalışacaktır.");
            }
        }
    }
}