using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Başkenti neresidir?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmaradaki ilimiz?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü hangi gündür?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamı?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü ilimiz";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında meşhur çicek festivali";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk Şairi";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuç gibi sebzelerle yapılan yemek";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın sultanı";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan ne demek?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "İki kişinin oynadığı bir şans oyunu";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir besini?";
                button24.BackColor = Color.Yellow;
            }
            if (soruno >= 25)
            {
                MessageBox.Show("Sorular bitti!!"+" " + "Toplam Doğru:" + dogru +" " + "Toplam Yanlış:" + yanlis+" "+ "Boş sayısı"+(soruno-dogru-yanlis-1));
                return;
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    //Cevap 1
                    case 1:
                        if (textBox1.Text == "Ankara")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 2
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 3
                    case 3:
                        if (textBox1.Text=="Cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 4
                    case 4:
                        if (textBox1.Text == "Diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 5
                    case 5:
                        if (textBox1.Text == "Eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 6
                    case 6:
                        if (textBox1.Text == "Ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 7
                    case 7:
                        if (textBox1.Text == "Güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 8
                    case 8:
                        if (textBox1.Text == "Halı")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 9
                    case 9:
                        if (textBox1.Text == "Isparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 10
                    case 10:
                        if (textBox1.Text == "İçel")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 11
                    case 11:
                        if (textBox1.Text == "Jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 12
                    case 12:
                        if (textBox1.Text == "Kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 13
                    case 13:
                        if (textBox1.Text == "Lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 14
                    case 14:
                        if (textBox1.Text == "Mart")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 15
                    case 15:
                        if (textBox1.Text == "Ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 16
                    case 16:
                        if (textBox1.Text == "Ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 17
                    case 17:
                        if (textBox1.Text == "Pırasa")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 18
                    case 18:
                        if (textBox1.Text == "Ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 19
                    case 19:
                        if (textBox1.Text == "Snake")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 20
                    case 20:
                        if (textBox1.Text == "Tavla")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 21
                    case 21:
                        if (textBox1.Text == "Umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 22
                    case 22:
                        if (textBox1.Text == "Van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 23
                    case 23:
                        if (textBox1.Text == "Yıldırım")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 24
                    case 24:
                        if (textBox1.Text == "Zeytin")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                        
                }
            }
        }
    }
}