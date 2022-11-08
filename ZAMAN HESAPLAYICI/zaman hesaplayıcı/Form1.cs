using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaman_hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int saatyazdır, dakikayazdır,saatyazdır2,dakikayazdır2,saniyeyazdır2;
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile("saat.ico");
            button4.Enabled = false;

            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;


            comboBox7.Text = "1x";

            comboBox7.Items.Add("2x");
            comboBox7.Items.Add("1.5x");
            comboBox7.Items.Add("1x");
            comboBox7.Items.Add("0.75x");
            comboBox7.Items.Add("0.50x");
            comboBox7.Items.Add("0.25x");

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            
            comboBox6.Text = "SEÇ";
            comboBox6.Items.Add("Çılgın");
            comboBox6.Items.Add("Sakin");
            comboBox6.Items.Add("Radyoaktif");
            comboBox6.Items.Add("Çılgın Koro");

            timer1.Enabled = true;

            for (dakikayazdır = 00; dakikayazdır <= 59; dakikayazdır++)
            {
                comboBox1.Items.Add(dakikayazdır.ToString());
            }

            for (saatyazdır = 00; saatyazdır <= 23; saatyazdır++)
            {
                comboBox2.Items.Add(saatyazdır.ToString());
            }

            for (saatyazdır2 = 0; saatyazdır2 <= 24; saatyazdır2++)
            {
                comboBox3.Items.Add(saatyazdır2.ToString());
            }

            for (dakikayazdır2 = 0; dakikayazdır2 <= 59; dakikayazdır2++)
            {
                comboBox4.Items.Add(dakikayazdır2.ToString());
            }

            for(saniyeyazdır2=0;saniyeyazdır2<=59;saniyeyazdır2++)
            {
                comboBox5.Items.Add(saniyeyazdır2.ToString());
            }

            comboBox1.Text = "00";
            comboBox2.Text = "00";

            comboBox3.Text = "00";
            comboBox4.Text = "00";
            comboBox5.Text = "00";
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.Day.ToString();
            label6.Text = DateTime.Now.Hour.ToString();
            label7.Text = DateTime.Now.Minute.ToString();
            label8.Text = DateTime.Now.Second.ToString();
            label10.Text = DateTime.Now.Month.ToString();
            label12.Text = DateTime.Now.Year.ToString();
            label13.Text = DateTime.Now.DayOfYear.ToString();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Interval = 10;
            timer2.Enabled = true;
        }
        int salise, saniye, dakika, saat;
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            label21.Text = salise.ToString();
            salise = salise + 1;
            
            if (salise == 63)
            {
                salise = 0;
                saniye++;
                label20.Text = saniye.ToString();
               

                if (saniye == 60)
                {
                    saniye = 0;
                    label20.Text = saniye.ToString();
                    dakika++;
                    label19.Text = dakika.ToString();
                    

                    if (dakika == 60)
                    {
                        dakika = 0;
                        label19.Text = dakika.ToString();
                        saat++;
                        label18.Text = saat.ToString();
                       
                        if (saat == 24)
                        {
                            timer2.Enabled = false;
                            saat = 0;
                            dakika = 0;
                            saniye = 0;
                            salise = 0;

                            label21.Text = salise.ToString();
                            label20.Text = saniye.ToString();
                            label19.Text = dakika.ToString();
                            label18.Text = saat.ToString();

                            MessageBox.Show("MAKSİMUM ZAMAN DİLİMİNE ULAŞILARAK SIFIRLANDI");
                        }
                    }
                }
            }
        }
        int b,c1,c2,l6,l7,sonuc,sonuc1,combo1,combo2;
        private void button2_Click(object sender, EventArgs e)
        {
          

            if (button2.Enabled == true && comboBox6.Text =="SEÇ")
            {
                button4.Enabled = false;
            }

            else
            {
                button4.Enabled = true;
            }

            combo1 = Convert.ToInt32(comboBox1.Text);   
            combo2 = Convert.ToInt32(comboBox2.Text);

            if(combo1 >=60 || combo2>=24 )
            {
            MessageBox.Show("saat sınırlaması");
            comboBox1.Text = "00";
            comboBox2.Text = "00";
            comboBox6.Text = "SEÇ";
            }

            else if (comboBox6.Text != "Sakin" && comboBox6.Text != "Radyoaktif" && comboBox6.Text != "Çılgın" && comboBox6.Text == "SEÇ" && comboBox6.Text != "Çılgın Koro")
            {
                MessageBox.Show("Lütfen melodi seçiniz","bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                comboBox6.Text = "SEÇ";
            }
            else
            {

                c1 = Convert.ToInt32(comboBox1.Text);
                c2 = Convert.ToInt32(comboBox2.Text);

                l6 = Convert.ToInt32(label6.Text);
                l7 = Convert.ToInt32(label7.Text);

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox6.Enabled = false;

                if (comboBox1.Text == label7.Text && comboBox2.Text == label6.Text)
                {
                    timer3.Interval = 1;
                    timer3.Enabled = false;
                    timer5.Enabled = true;
                    b = 60;
                    MessageBox.Show("24 saat sonra çalacak");
                    button2.Enabled = false;
                }

                else if (c2 == l6 && l7 < c1)
                {
                    timer3.Interval = 1;
                    timer3.Enabled = true;
                    button2.Enabled = false;

                    sonuc = c1 - l7;
                    MessageBox.Show(sonuc + " dakika kaldı");

                }

                else if (c2 == l6 && l7 > c1)
                {
                    timer3.Interval = 1;
                    timer3.Enabled = true;
                    button2.Enabled = false;

                    sonuc = 60 - l7 + c1;
                    MessageBox.Show("23 saat " + sonuc + " dakika kaldı");

                }

                else if (c2 > l6)
                {
                    timer3.Interval = 1;
                    timer3.Enabled = true;
                    button2.Enabled = false;

                    sonuc = (60 - l7) + c1;
                    if (sonuc >= 60)
                    {
                        sonuc = sonuc - 60;
                        MessageBox.Show((c2 - l6) + " saat " + sonuc + " dakika kaldı");
                    }
                    else
                    {
                        c2 = c2 - 1;
                        MessageBox.Show((c2 - l6) + " saat " + sonuc + " dakika kaldı");
                    }

                }

                else if (c2 < l6)
                {
                    timer3.Interval = 1;
                    timer3.Enabled = true;
                    button2.Enabled = false;

                    sonuc = (23 - l6) + c2;
                    sonuc1 = (60 - l7) + c1;
                    if (sonuc1 >= 60)
                    {
                        sonuc = sonuc + 1;
                        sonuc1 = sonuc1 - 60;
                        MessageBox.Show(sonuc + " saat " + sonuc1 + " dakika kaldı");

                    }
                    else
                    {

                        MessageBox.Show(sonuc + " saat " + sonuc1 + " dakika kaldı");
                    }




                }

                else
                {
                    timer3.Interval = 1;
                    timer3.Enabled = true;
                    button2.Enabled = false;
                }
            }
        }
        int a = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            a++;
            

            if (comboBox1.Text == label7.Text && comboBox2.Text == label6.Text)
            {
                timer3.Enabled = false;
                button2.Enabled = false;

                if (comboBox6.Text == "Çılgın")
                {
                    axWindowsMediaPlayer1.URL = "Çılgın.MP4";
                }

               if (comboBox6.Text == "Sakin")
                {
                    axWindowsMediaPlayer1.URL = "Sakin.mp4";
                }

                 if (comboBox6.Text == "Radyoaktif")
                {
                    axWindowsMediaPlayer1.URL = "Radyoaktif.mp4";
                }

               if (comboBox6.Text == "Çılgın Koro")
                {
                    axWindowsMediaPlayer1.URL = "Çılgın koro.mp4";
                }
               
               

                MessageBox.Show("ZAMAN DOLDU");
            

            }
        
        }
        int saniye2, dakika2, saat2, combo3, combo4, combo5;
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "00" && comboBox4.Text == "00" && comboBox5.Text == "00")
            {
                MessageBox.Show("lütfen boşlukları doldurunuz", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                button3.Enabled = false;


                comboBox7.Enabled = false;

                combo3 = Convert.ToInt32(comboBox3.Text);
                combo4 = Convert.ToInt32(comboBox4.Text);
                combo5 = Convert.ToInt32(comboBox5.Text);

                if (combo3 >= 24 || combo4 >= 60 || combo5 >= 60)
                {
                    MessageBox.Show("saat sınırlaması");

                }
                else
                {


                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;

                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;

                    label34.Text = comboBox3.Text;
                    label35.Text = comboBox4.Text;
                    label37.Text = comboBox5.Text;

                    saniye2 = Convert.ToInt32(comboBox5.Text);
                    dakika2 = Convert.ToInt32(comboBox4.Text);
                    saat2 = Convert.ToInt32(comboBox3.Text);
                }


            }

            if(label34.Text=="00"&&label35.Text=="00"&&label37.Text=="00")
            {
                timer4.Enabled = false;
            }

            else if (label34.Text != "00" || label35.Text != "00" || label37.Text != "00")
            {
                timer4.Enabled = true;

                if (comboBox7.Text == "2x")
                {
                    timer4.Interval = 500;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "1.5x")
                {
                    timer4.Interval = 750;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "1x")
                {
                    timer4.Interval = 1000;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "0.75x")
                {
                    timer4.Interval = 1250;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "0.50x")
                {
                    timer4.Interval = 1500;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "0.25x")
                {
                    timer4.Interval = 1750;
                    timer4.Enabled = true;
                }

            }


          else  if (label34.Text != "00" && label35.Text != "00" && label37.Text != "00")
            {
                timer4.Enabled = true;

                if (comboBox7.Text == "2x")
                {
                    timer4.Interval = 500;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "1.5x")
                {
                    timer4.Interval = 750;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "1x")
                {
                    timer4.Interval = 1000;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "0.75x")
                {
                    timer4.Interval = 1250;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "0.50x")
                {
                    timer4.Interval = 1500;
                    timer4.Enabled = true;
                }

                else if (comboBox7.Text == "0.25x")
                {
                    timer4.Interval = 1750;
                    timer4.Enabled = true;
                }

            }

            comboBox3.Text = "00";
            comboBox4.Text = "00";
            comboBox5.Text = "00";
           

           
        }
       
        private void timer4_Tick(object sender, EventArgs e)
        {
            if(saniye2!=0)
            {
                saniye2--;
                label37.Text = saniye2.ToString();
                if (saniye2 == 0)
                {
                    if (dakika2 != 0)
                    {
                        dakika2--;
                        saniye2 = 60;
                        label35.Text = dakika2.ToString();
                        if (dakika2 == 0)
                        {
                            if (saat2 != 0)
                            {
                                saat2--;
                                dakika2 = 60;
                                label34.Text = saat2.ToString();

                                
                            }
                        }
                    }
                }
            }



          if (saniye2 == 0)
            {
                if (dakika2 != 0)
                {
                    dakika2--;
                    saniye2 = 60;
                    label35.Text = dakika2.ToString();
                    if (dakika2 == 0)
                    {
                        if (saat2 != 0)
                        {
                            saat2--;
                            dakika2 = 60;
                            label34.Text = saat2.ToString();

                           
                        }
                    }
                }
            }



           
            if (dakika2 == 0)
                    {
                        if (saat2 != 0)
                        {
                            saat2--;
                            dakika2 = 60;
                            label34.Text = saat2.ToString();

                            
                        }
                    }


            if (saat2 == 0 && dakika2 == 0 && saniye2 == 0)
            {
                timer4.Enabled = false;
                axWindowsMediaPlayer2.URL = "Sakin.mp4";
                MessageBox.Show("SÜRE DOLDU");
                axWindowsMediaPlayer2.URL = "";
            }
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            b--;
            if(b==0)
            {
                timer5.Enabled = false;
                timer3.Enabled = true;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";

            button4.Enabled = false;
            
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox6.Enabled = true;

            timer3.Enabled = false;
            timer5.Enabled = false;
       
            button2.Enabled = true;

            comboBox1.Text = "00";
            comboBox2.Text = "00";
            comboBox6.Text = "SEÇ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;

            if (comboBox7.Text == "2x")
            {
                timer4.Interval = 500;
                timer4.Enabled = true;
            }

            else if (comboBox7.Text == "1.5x")
            {
                timer4.Interval = 750;
                timer4.Enabled = true;
            }

            else if (comboBox7.Text == "1x")
            {
                timer4.Interval = 1000;
                timer4.Enabled = true;
            }

            else if (comboBox7.Text == "0.75x")
            {
                timer4.Interval = 1250;
                timer4.Enabled = true;
            }

            else if (comboBox7.Text == "0.50x")
            {
                timer4.Interval = 1500;
                timer4.Enabled = true;
            }

            else if (comboBox7.Text == "0.25x")  //burası boş da kalabilir.
            {
                timer4.Interval = 5000;
                timer4.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "";

            if (button3.Enabled == true)
            {
                button3.Enabled = false;
                
            }

            else 
            {
                button3.Enabled = true;
                button7.Enabled = false;
            }

            comboBox7.Enabled = true;

            button5.Enabled = false;
            button6.Enabled=false;

            timer4.Enabled = false;

            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;

            comboBox3.Text = "00";
            comboBox4.Text = "00";
            comboBox5.Text = "00";

            label34.Text = "00";
            label35.Text = "00";
            label37.Text = "00";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;

            label18.Text = "00";
            label19.Text = "00";
            label20.Text = "00";
            label21.Text = "00";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult a=MessageBox.Show("kapatmaktan emin misiniz?","kapat",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
