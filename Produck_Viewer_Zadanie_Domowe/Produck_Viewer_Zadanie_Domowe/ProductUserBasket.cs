using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Produck_Viewer_Zadanie_Domowe.Models;

namespace Produck_Viewer_Zadanie_Domowe
{
    public partial class ProductUserBasket : UserControl
    {
        #region INICJALIZACJA ZMIENNYCH
        int numerPrzycisku = 0;
        decimal totalPrice = 0;

        #endregion

        #region FUNKCJE
        public ProductUserBasket()
        {
            InitializeComponent();
        }
        public void UpdateBasket(string name, decimal price, int produkt, int ilosc, string url)
        {
            List<Label> lblProdukt = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblProdukt")).OrderBy(a => a.Name).ToList();
            for (int i = 0; i < Form1.koszyk.Count; i++)
            {
                if (lblProdukt[i].Visible == false)
                {
                    Wyswietlanie(produkt, name, ilosc, price, url);
                }
            }
        }
        public void DeleteBasket(string name, decimal price, int produkt, string url)
        {
            Czyszczenie(produkt);
            
        }
        public void RefreshBasket()
        {
            for (int i = 0; i < 10; i++)
            {
                Czyszczenie(i);
            }

            totalPrice = 0;
        }
        public void LabelPriceBasket(int labelNumber)
        {
            List<Label> lblPriceBasket = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblPriceBasket")).OrderBy(a => a.Name).ToList();
            lblPriceBasket[labelNumber - 1].Text = ((Form1.koszyk[labelNumber - 1].Ilosc * Form1.koszyk[labelNumber - 1].Price).ToString() + "zł");
        }
        public void LabelIlosc(int labelNumber)
        {
            List<Label> lblIloscSztuk = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblIloscSztuk")).OrderBy(a => a.Name).ToList();
            lblIloscSztuk[labelNumber - 1].Text = Form1.koszyk[labelNumber - 1].Ilosc.ToString();
        }
        public void DodajIlosc(int pozycjaKoszyka)
        {
            int DodajIlosc = Form1.koszyk[pozycjaKoszyka - 1].Ilosc + 1;
            Form1.koszyk[pozycjaKoszyka - 1].Ilosc = DodajIlosc;
        }
        public void OdejmijIlosc(int pozycjaKoszyka)
        {
            int odejmijIlosc = Form1.koszyk[pozycjaKoszyka - 1].Ilosc - 1;
            Form1.koszyk[pozycjaKoszyka - 1].Ilosc = odejmijIlosc;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.koszyk.Count == 0)
            {
                RefreshBasket();
            }
            if (lblTotal.Text == "0zł")
            {
                lblTotal.Visible = false;
                label2.Visible = false;
            }
            else
            {
                lblTotal.Visible = true;
                label2.Visible = true;
            }
            TotalPrice();
        }
        public void Czyszczenie(int pozycjaKoszyka)
        {
            List<Label> lblIloscSztuk = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblIloscSztuk")).OrderBy(a => a.Name).ToList();
            List<Label> lblPriceBasket = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblPriceBasket")).OrderBy(a => a.Name).ToList();
            List<Label> lblProdukt = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblProdukt")).OrderBy(a => a.Name).ToList();
            List<Label> lblIloscText = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblIloscText")).OrderBy(a => a.Name).ToList();
            List<Label> lblPriceText = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblPriceText")).OrderBy(a => a.Name).ToList();
            List<Button> btnMinus = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btnMinus")).OrderBy(a => a.Name).ToList();
            List<Button> btnPlus = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btnPlus")).OrderBy(a => a.Name).ToList();
            List<PictureBox> pbx = this.Controls.OfType<PictureBox>().Where(a => a.Name.StartsWith("pbx")).OrderBy(a => a.Name).ToList();
            lblIloscSztuk[pozycjaKoszyka].ResetText();
            lblPriceBasket[pozycjaKoszyka].ResetText();
            lblProdukt[pozycjaKoszyka].ResetText();
            btnMinus[pozycjaKoszyka].Visible = false;
            btnPlus[pozycjaKoszyka].Visible = false;
            lblIloscText[pozycjaKoszyka].Visible = false;
            lblPriceText[pozycjaKoszyka].Visible = false;
            pbx[pozycjaKoszyka].Visible = false;
        }
        public void Wyswietlanie(int pozycjaKoszyka, string name, int ilosc, decimal price, string url)
        {
            List<Label> lblIloscSztuk = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblIloscSztuk")).OrderBy(a => a.Name).ToList();
            List<Label> lblPriceBasket = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblPriceBasket")).OrderBy(a => a.Name).ToList();
            List<Label> lblProdukt = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblProdukt")).OrderBy(a => a.Name).ToList();
            List<Label> lblIloscText = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblIloscText")).OrderBy(a => a.Name).ToList();
            List<Label> lblPriceText = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblPriceText")).OrderBy(a => a.Name).ToList();
            List<Button> btnMinus = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btnMinus")).OrderBy(a => a.Name).ToList();
            List<Button> btnPlus = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btnPlus")).OrderBy(a => a.Name).ToList();
            List<PictureBox> pbx = this.Controls.OfType<PictureBox>().Where(a => a.Name.StartsWith("pbx")).OrderBy(a => a.Name).ToList();
            lblProdukt[pozycjaKoszyka].Text = name;
            lblProdukt[pozycjaKoszyka].Visible = true;
            lblIloscSztuk[pozycjaKoszyka].Text = ilosc.ToString();
            lblIloscSztuk[pozycjaKoszyka].Visible = true;
            lblPriceBasket[pozycjaKoszyka].Text = (price.ToString() + "zł");
            lblPriceBasket[pozycjaKoszyka].Visible = true;
            lblIloscText[pozycjaKoszyka].Visible = true;
            lblPriceText[pozycjaKoszyka].Visible = true;
            btnMinus[pozycjaKoszyka].Visible = true;
            btnPlus[pozycjaKoszyka].Visible = true;
            pbx[pozycjaKoszyka].Load(url);
            pbx[pozycjaKoszyka].Visible = true;
        }
        public void ButtonPlus(int numerPrzycisku)
        {
            DodajIlosc(numerPrzycisku);
            LabelIlosc(numerPrzycisku);
            LabelPriceBasket(numerPrzycisku);
        }
        public void ButtonMinus(int numerPrzycisku)
        {
            if (Form1.koszyk[numerPrzycisku - 1].Ilosc > 1)
            {
                OdejmijIlosc(numerPrzycisku);
                LabelIlosc(numerPrzycisku);
                LabelPriceBasket(numerPrzycisku);
            }
            else
            {
                string tresc = "Czy na pewno chcesz usunąć ten przedmiot z koszyka?";
                string tytul = "Usuń Produkt.";
                DialogResult wiadomosc;
                wiadomosc = MessageBox.Show(tresc, tytul, MessageBoxButtons.YesNo);
                if (wiadomosc == DialogResult.Yes)
                {
                    
                    for (int i = 0; i < Form1.koszyk.Count;i++)
                    {
                        Czyszczenie(i);
                    }
                    Form1.koszyk.RemoveAt(numerPrzycisku - 1);
                    Form1.counter = Form1.counter - 1;
                    for (int i = 0; i < Form1.koszyk.Count; i++)
                    {
                        Wyswietlanie(i, Form1.koszyk[i].Name, Form1.koszyk[i].Ilosc, Form1.koszyk[i].Price, Form1.koszyk[i].ImgUrl);
                    }
                }
            }
        }
        public void SprawdzaniePozycjiKoszyka(int pozycjaKoszyka)
        {
            List<Label> lblIloscSztuk = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblIloscSztuk")).OrderBy(a => a.Name).ToList();
            List<Label> lblPriceBasket = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblPriceBasket")).OrderBy(a => a.Name).ToList();
            List<Label> lblProdukt = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblProdukt")).OrderBy(a => a.Name).ToList();
            List<Label> lblIloscText = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblIloscText")).OrderBy(a => a.Name).ToList();
            List<Label> lblPriceText = this.Controls.OfType<Label>().Where(a => a.Name.StartsWith("lblPriceText")).OrderBy(a => a.Name).ToList();
            List<Button> btnMinus = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btnMinus")).OrderBy(a => a.Name).ToList();
            List<Button> btnPlus = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btnPlus")).OrderBy(a => a.Name).ToList();
            for (int i = 0; i < Form1.koszyk.Count; i++)
            {
                if(lblProdukt[i].Text != Form1.koszyk[i].Name)
                {

                }
            }
        }
        public void TotalPrice()
        {
            bool promocja = false;
            decimal cena = 0;
            bool czyPromocjaWgKategorii = false;
            for (int i = 0; i < Form1.koszyk.Count; i++)
            {
                bool czyRabat = false;

                for (int a = 0; a < ProductsOnSale.ProductOnSale.Count; a++)
                {
                    if (Form1.koszyk[i].Name == ProductsOnSale.ProductOnSale[a].Name && Form1.koszyk[i].Ilosc >= ProductsOnSale.ProductOnSale[a].IloscWyaganaDoPromocji)
                    {
                        cena = cena + ObliczaniePromocji(Form1.koszyk[i].Price * Form1.koszyk[i].Ilosc, ProductsOnSale.ProductOnSale[a].Promocja);
                        czyRabat = true;
                        promocja = true;
                        break;
                    }
                    if (i > 0 && Form1.koszyk[i].Kategoria != Form1.koszyk[i - 1].Kategoria)
                    {
                        czyPromocjaWgKategorii = true;
                    }
                }
                if (czyRabat == false)
                {
                    cena = cena + Form1.koszyk[i].Price * Form1.koszyk[i].Ilosc;
                }
            }
            if (czyPromocjaWgKategorii == true || promocja == true)
            {
                lblCenaBezPromocji.Visible = true;
                lblCenaBezPromocjiText.Visible = true;
                TotalPriceNoPromo();
            }
            else
            {
                lblCenaBezPromocji.Visible = false;
                lblCenaBezPromocjiText.Visible = false;
            }
            if (czyPromocjaWgKategorii == true)
            {
                decimal wartoscPromocjiWgKategorii = 0.10m;
                cena = ObliczaniePromocji(cena, wartoscPromocjiWgKategorii);
            }
            lblTotal.Text = (Math.Round(cena, 2).ToString() + "zł");
        }
        public void TotalPriceNoPromo()
        {
            decimal totalPriceNoPromo = 0;
            for(int i = 0; i < Form1.koszyk.Count;i++)
            {
                totalPriceNoPromo = totalPriceNoPromo + (Form1.koszyk[i].Price * Form1.koszyk[i].Ilosc);
            }
            lblCenaBezPromocji.Text = totalPriceNoPromo.ToString() + "zł";
        }
        public decimal ObliczaniePromocji(decimal cena, decimal promocja)
        {
            return cena - (cena * promocja);
        }
        #endregion;

        #region BUTTON +/-
        private void btnMinus1_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 1;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 1;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus2_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 2;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 2;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus3_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 3;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 3;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus4_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 4;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus4_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 4;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus5_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 5;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 5;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus6_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 6;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus6_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 6;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus7_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 7;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus7_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 7;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus8_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 8;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus8_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 8;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus9_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 9;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus9_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 9;
            ButtonPlus(numerPrzycisku);
        }
        private void btnMinus10_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 10;
            ButtonMinus(numerPrzycisku);
        }

        private void btnPlus10_Click(object sender, EventArgs e)
        {
            numerPrzycisku = 10;
            ButtonPlus(numerPrzycisku);
        }
        #endregion

    }
}

