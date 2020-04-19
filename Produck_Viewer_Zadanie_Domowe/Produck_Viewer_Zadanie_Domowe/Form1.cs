using Produck_Viewer_Zadanie_Domowe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produck_Viewer_Zadanie_Domowe
{
    public partial class Form1 : Form
    {
        public static List<ProductsInBasket> koszyk = new List<ProductsInBasket>();
       
        private readonly ProductService _productService = new ProductService();
        int produkt = -1;
        public static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProduct1_Click(object sender, EventArgs e)
        {
            produkt = 0;
            productUserControl1.Update(_productService.Products[0]);
        }
        private void btnProduct2_Click(object sender, EventArgs e)
        {
            produkt = 1;
            productUserControl1.Update(_productService.Products[1]);
        }
        private void btnProduct3_Click(object sender, EventArgs e)
        {
            produkt = 2;
            productUserControl1.Update(_productService.Products[2]);
        }
        private void btnProduct4_Click(object sender, EventArgs e)
        {
            produkt = 3;
            productUserControl1.Update(_productService.Products[3]);
        }
        private void btnProduct5_Click(object sender, EventArgs e)
        {
            produkt = 4;
            productUserControl1.Update(_productService.Products[4]);
        }
        private void btnProduct6_Click(object sender, EventArgs e)
        {
            produkt = 5;
            productUserControl1.Update(_productService.Products[5]);
        }
        private void btnStore_Click(object sender, EventArgs e)
        {
                   
            productUserBasket1.Visible = false;
            btnProduct1.Visible = true;
            btnProduct2.Visible = true;
            btnProduct3.Visible = true;
            btnProduct4.Visible = true;
            btnProduct5.Visible = true;
            btnProduct6.Visible = true;
            btnAddToBasket.Visible = true;
            btnDeleteFromBasket.Visible = false;
            btnCancelBasket.Visible = false;

        }
        private void btnBasket_Click(object sender, EventArgs e)
        {
            productUserControl1.Visible = false;
            productUserBasket1.Visible = true;
            btnProduct1.Visible = false;
            btnProduct2.Visible = false;
            btnProduct3.Visible = false;
            btnProduct4.Visible = false;
            btnProduct5.Visible = false;
            btnProduct6.Visible = false;
            btnAddToBasket.Visible = false;
            btnDeleteFromBasket.Visible = true;
            btnCancelBasket.Visible = true;
        }
        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            bool istnieje = false;
            int pozycja = 0;
            if (produkt >= 0)
            {
                for (int i = 0; i < koszyk.Count; i++)
                {
                    if (_productService.Products[produkt].Name == koszyk[i].Name)
                    {
                        istnieje = true;
                        pozycja = i;
                    }
                }
                if (counter < 10 && istnieje == false)
                {
                    koszyk.Add(new ProductsInBasket(_productService.Products[produkt].Name, _productService.Products[produkt].Price, 1, _productService.Products[produkt].Category, _productService.Products[produkt].ImageUrl));
                    productUserBasket1.UpdateBasket(koszyk[counter].Name, koszyk[counter].Price, counter, koszyk[counter].Ilosc,koszyk[counter].ImgUrl);
                    counter++;
                }
                else if (counter < 10 && istnieje == true)
                {
                    int staraIlosc = koszyk[pozycja].Ilosc;
                    koszyk.RemoveAt(pozycja);
                    koszyk.Insert(pozycja, new ProductsInBasket(_productService.Products[produkt].Name, _productService.Products[produkt].Price, 1 + staraIlosc, _productService.Products[produkt].Category, _productService.Products[produkt].ImageUrl));
                    productUserBasket1.UpdateBasket(koszyk[pozycja].Name, koszyk[pozycja].Price * koszyk[pozycja].Ilosc, pozycja, koszyk[pozycja].Ilosc, koszyk[pozycja].ImgUrl);
                }
                else
                {
                    string message = "Maksymalna ilość rzeczy w koszyku to 10 - usuń coś z koszyka, aby dodać nową rzecz.";
                    string caption = "BŁĄD - MAX ILOŚĆ RZECZY W KOSZYKU PRZEKROCZONA";
                    DialogResult result;

                    // Displays the MessageBox
                    result = MessageBox.Show(message, caption);
                }
            }
            else
            {
                string message = "PROSZĘ WYBRAĆ PRODUKT";
                string title = "Błąd - Żaden produkt nie jest wybrany";
                DialogResult wiadomosc;
                wiadomosc = MessageBox.Show(message, title);
            }
        }

        private void btnDeleteFromBasket_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                productUserBasket1.DeleteBasket(koszyk[counter].Name, koszyk[counter].Price, counter,koszyk[counter].ImgUrl);
                koszyk.RemoveAt(counter);
            }
            else
            {
                string message = "Nie masz już co usuwać.";
                string caption = "BŁĄD -KOSZYK JEST JUŻ PUSTY";
                DialogResult result;

                // Displays the MessageBox
                result = MessageBox.Show(message, caption);
            }
        }

        private void btnTestCancel_Click(object sender, EventArgs e)
        {
            if (koszyk.Count > 0)
            {
                koszyk.Clear();
                productUserBasket1.RefreshBasket();
                counter = 0;
            }
            else
            {
                string message = "Nie masz już co usuwać.";
                string caption = "BŁĄD -KOSZYK JEST JUŻ PUSTY";
                DialogResult result;

                // Displays the MessageBox
                result = MessageBox.Show(message, caption);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (produkt >= 0 && productUserBasket1.Visible == false)
            {
                productUserControl1.Visible = true;
            }
            else productUserControl1.Visible = false;
        }
    }
}
