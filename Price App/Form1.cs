using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Price_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double anatoplam = 0;
        double toplam;
        
        double shipping;



        

    









        float rate = (float)(5.9);
        float usdrate = (float)(7.5);
        int x = 1;

        private void kind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kind.Text == "Fon" || kind.Text == "Curtain")
            {
                pile_cbox.Show();
            }
            else if (kind.Text == "Stor-Zebra") {

                pile_cbox.Hide();
            }
            


        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            main_box.Text = anatoplam.ToString();
            groupBox1.Show();
}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Discount_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        float main;
        private void count_Click(object sender, EventArgs e)
        {
            float a;
            
            if (d_box.Text == "")
            {
                a = 0;
            }
            else
            {
               a = float.Parse(d_box.Text);
            }






            main = float.Parse(main_box.Text) - a;
            double taxvalue = main * 0.13;
            double grandtotal = main + taxvalue;
            double deposit = (grandtotal * 0.3 );
            double balance = (grandtotal - deposit);
            
            

            total1.Text = main.ToString();
            tax1.Text = taxvalue.ToString();
            grand_t.Text =   "C$ " + String.Format("{0:0.00}", grandtotal);
            depositl.Text = ("Deposit C$ "+ String.Format("{0:0.00}", deposit));
            balancel.Text = ("Balance after deposit C$ "+ String.Format("{0:0.00}", balance));



            groupBox2.Show();


        }

        private void width_box_TextChanged(object sender, EventArgs e)
        {

        }

        public double shipping_counter( string product )
        {
            if (product == "Fon")
            {
                shipping = float.Parse(qty_box.Text) * float.Parse(pile_cbox.Text) * float.Parse(width_box.Text) * 0.8  *6* rate;
            }

            else if (product == "Curtain")
            {
                shipping = float.Parse(qty_box.Text) * float.Parse(pile_cbox.Text) * float.Parse(width_box.Text) * 0.35  *6* rate;
            }
            else { 
                shipping = float.Parse(qty_box.Text) * float.Parse(width_box.Text) * 1.5 * 6 * usdrate;
            }
            return shipping;
        }

        private void ext_button_Click(object sender, EventArgs e)
        {
                anatoplam += Int16.Parse(extra_box.Text);
                main_box.Text = anatoplam.ToString();}

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (kind.Text == "Fon" || kind.Text == "Curtain")
            {
                shipping = shipping_counter(kind.Text);
                toplam = (shipping + ( float.Parse(price_box.Text) * float.Parse(qty_box.Text) * float.Parse(width_box.Text) * float.Parse(pile_cbox.Text))) * (3 / rate);
            }
            
            else if (kind.Text == "Stor-Zebra")
            {
                
                
            
                if ((float.Parse(width_box.Text) <= 1.0) && (float.Parse(height_box.Text) <= 2.0))

                {
                    shipping = shipping_counter(kind.Text);
                    toplam = (shipping + (float.Parse(price_box.Text) * float.Parse(qty_box.Text) * 2)) * (3 / rate);

                }

                else if (float.Parse(width_box.Text) <= 1)
                {
                    shipping = shipping_counter(kind.Text);
                    toplam = (  shipping + (    (float.Parse(price_box.Text)) * (float.Parse(qty_box.Text)) * (float.Parse(height_box.Text) )    )   ) * (3 / rate);
                }

                else if (float.Parse(height_box.Text) <= 2)

                {
                    shipping = shipping_counter(kind.Text);
                    toplam = (shipping + ((float.Parse(price_box.Text)) * (float.Parse(qty_box.Text)) * (float.Parse(width_box.Text)) * 2)) * (3 / rate);
                }

                else
                {
                    shipping = shipping_counter(kind.Text);
                    toplam = (shipping + ((float.Parse(price_box.Text)) * (float.Parse(qty_box.Text)) * (float.Parse(width_box.Text)) * (float.Parse(height_box.Text)))) * (3 / rate);
                }
            }
            
            else
            {
                toplam = 0;
            }



            no_lbox.Items.Add(x);
            room_lbox.Items.Add(room_box.Text);
            width_lbox.Items.Add(width_box.Text);
            height_lbox.Items.Add(height_box.Text);
            price_lbox.Items.Add(toplam.ToString());

            anatoplam += toplam;
            main_box.Text = anatoplam.ToString();

            width_box.Clear();
            height_box.Clear();
            price_box.Clear();
            qty_box.Clear();
            x++;
        }
        private void Form1_Load(object sender, EventArgs e){}
        private void groupBox3_Enter(object sender, EventArgs e){}
        private void groupBox1_Enter(object sender, EventArgs e){}
        private void room_lbox_SelectedIndexChanged(object sender, EventArgs e){}
        int a;
        private void rem_b_Click(object sender, EventArgs e)
        {
            a = Int16.Parse(rem_bo.Text);
            string removi = price_lbox.Items[a - 1].ToString();
            anatoplam -= float.Parse(removi);
            no_lbox.Items.RemoveAt(x - 2);
            room_lbox.Items.RemoveAt(a-1);
            width_lbox.Items.RemoveAt(a-1);
            height_lbox.Items.RemoveAt(a-1);
            price_lbox.Items.RemoveAt(a-1);
            x--;
            main_box.Text = anatoplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* string url = "https://www.google.com/search?q=usd+to+tl&rlz=1C1CHBF_trCA913CA913&oq=&aqs=chrome.2.69i59i450l8.1390907014j0j7&sourceid=chrome&ie=UTF-8";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream());

            




            sr.Close();



            */
        }

        private void depositl_Click(object sender, EventArgs e)
        {

        }
    }
}