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
using Produck_Viewer_Zadanie_Domowe;

namespace Produck_Viewer_Zadanie_Domowe
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }
        string nazwa;
        decimal price;
        public void Update(Product product)
        {
            lblNazwa.Text = product.Name;
            lblDescription.Text = product.Description;
            pbxImage.Load(product.ImageUrl);
            lblSource.Text = product.Source;
            lblCategory.Text = product.Category.ToString();
            lblPrice.Text = (product.Price.ToString() + " zł");
            nazwa = product.Name;
            price = product.Price;
        }

    }
}
