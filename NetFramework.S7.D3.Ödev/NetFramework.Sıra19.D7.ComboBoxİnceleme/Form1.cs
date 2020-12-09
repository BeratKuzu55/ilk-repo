using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Sıra19.D7.ComboBoxİnceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            comboBoxDoldurV2();
        }

        private void comboBoxDoldurV2()
        {
            
            comboBoxÜrünListe.DataSource = Database.ürünTablo;
        }

        //comboBox ı nasıl doldurabiliriz 
        void comboBoxDoldur()
        {
            foreach (var item in Database.ürünTablo)
            {
                comboBoxÜrünListe.Items.Add(item);
                /*eğer combo box içerisinde mevcut bir data var ise ve mevcut data nın üzerine 
                 * farklı bir data bloğuyla data eklemek istiyorsanız items.Add() metodunu kullanabilirsiniz 
                 * eski değerim kabolmasın diye 
                 */
            }
        }

        private void comboBoxÜrünListe_SelectedIndexChanged(object sender, EventArgs e)
        {

           



            //selected index changed => combo box ın seçili olan indexi değişti olayı çalışır 
            //bu çalıştığında biz bu combo box ı nasıl yakalayabilir ve seçilen değeri nasıl 
            //elde edebiliriz 

            //1. yöntem
            object o1 = comboBoxÜrünListe.SelectedItem; //sectiğimiz ürüne ulaştık ulaştık 
            Ürün ürün1 = (Ürün)o1;






            pictureBox1.Image = Image.FromFile(ürün1.ürünResim);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            textBoxÜrünAdı.Text = ürün1.urunAdı;
            textBoxKategori.Text = ürün1.urunKategori;
            textBoxStokAdedi.Text = ürün1.stokAdet.ToString();
            textBoxYazar.Text = ürün1.yazar;
            TextBoxÜrünAçıklama.Text = ürün1.açıklama;
            




            

        }
    }
}
