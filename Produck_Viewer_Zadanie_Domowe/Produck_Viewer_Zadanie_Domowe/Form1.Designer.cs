namespace Produck_Viewer_Zadanie_Domowe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProduct1 = new System.Windows.Forms.Button();
            this.btnProduct2 = new System.Windows.Forms.Button();
            this.btnProduct4 = new System.Windows.Forms.Button();
            this.btnProduct3 = new System.Windows.Forms.Button();
            this.btnProduct6 = new System.Windows.Forms.Button();
            this.btnProduct5 = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.btnDeleteFromBasket = new System.Windows.Forms.Button();
            this.btnCancelBasket = new System.Windows.Forms.Button();
            this.productUserBasket1 = new Produck_Viewer_Zadanie_Domowe.ProductUserBasket();
            this.productUserControl1 = new Produck_Viewer_Zadanie_Domowe.ProductUserControl();
            this.SuspendLayout();
            // 
            // btnProduct1
            // 
            this.btnProduct1.Location = new System.Drawing.Point(12, 108);
            this.btnProduct1.Name = "btnProduct1";
            this.btnProduct1.Size = new System.Drawing.Size(98, 23);
            this.btnProduct1.TabIndex = 0;
            this.btnProduct1.Text = "Produkt 1";
            this.btnProduct1.UseVisualStyleBackColor = true;
            this.btnProduct1.Click += new System.EventHandler(this.btnProduct1_Click);
            // 
            // btnProduct2
            // 
            this.btnProduct2.Location = new System.Drawing.Point(12, 198);
            this.btnProduct2.Name = "btnProduct2";
            this.btnProduct2.Size = new System.Drawing.Size(98, 23);
            this.btnProduct2.TabIndex = 1;
            this.btnProduct2.Text = "Produkt 2";
            this.btnProduct2.UseVisualStyleBackColor = true;
            this.btnProduct2.Click += new System.EventHandler(this.btnProduct2_Click);
            // 
            // btnProduct4
            // 
            this.btnProduct4.Location = new System.Drawing.Point(12, 383);
            this.btnProduct4.Name = "btnProduct4";
            this.btnProduct4.Size = new System.Drawing.Size(98, 23);
            this.btnProduct4.TabIndex = 3;
            this.btnProduct4.Text = "Produkt 4";
            this.btnProduct4.UseVisualStyleBackColor = true;
            this.btnProduct4.Click += new System.EventHandler(this.btnProduct4_Click);
            // 
            // btnProduct3
            // 
            this.btnProduct3.Location = new System.Drawing.Point(12, 287);
            this.btnProduct3.Name = "btnProduct3";
            this.btnProduct3.Size = new System.Drawing.Size(98, 23);
            this.btnProduct3.TabIndex = 2;
            this.btnProduct3.Text = "Produkt 3";
            this.btnProduct3.UseVisualStyleBackColor = true;
            this.btnProduct3.Click += new System.EventHandler(this.btnProduct3_Click);
            // 
            // btnProduct6
            // 
            this.btnProduct6.Location = new System.Drawing.Point(12, 569);
            this.btnProduct6.Name = "btnProduct6";
            this.btnProduct6.Size = new System.Drawing.Size(98, 23);
            this.btnProduct6.TabIndex = 5;
            this.btnProduct6.Text = "Produkt 6";
            this.btnProduct6.UseVisualStyleBackColor = true;
            this.btnProduct6.Click += new System.EventHandler(this.btnProduct6_Click);
            // 
            // btnProduct5
            // 
            this.btnProduct5.Location = new System.Drawing.Point(12, 473);
            this.btnProduct5.Name = "btnProduct5";
            this.btnProduct5.Size = new System.Drawing.Size(98, 23);
            this.btnProduct5.TabIndex = 4;
            this.btnProduct5.Text = "Produkt 5";
            this.btnProduct5.UseVisualStyleBackColor = true;
            this.btnProduct5.Click += new System.EventHandler(this.btnProduct5_Click);
            // 
            // btnStore
            // 
            this.btnStore.AutoSize = true;
            this.btnStore.Location = new System.Drawing.Point(207, 24);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 27);
            this.btnStore.TabIndex = 7;
            this.btnStore.Text = "Sklep";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.AutoSize = true;
            this.btnBasket.Location = new System.Drawing.Point(350, 24);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(75, 27);
            this.btnBasket.TabIndex = 8;
            this.btnBasket.Text = "Koszyk";
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.AutoSize = true;
            this.btnAddToBasket.Location = new System.Drawing.Point(455, 24);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(132, 27);
            this.btnAddToBasket.TabIndex = 11;
            this.btnAddToBasket.Text = "Dodaj do Koszyka";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // btnDeleteFromBasket
            // 
            this.btnDeleteFromBasket.AutoSize = true;
            this.btnDeleteFromBasket.Location = new System.Drawing.Point(592, 57);
            this.btnDeleteFromBasket.Name = "btnDeleteFromBasket";
            this.btnDeleteFromBasket.Size = new System.Drawing.Size(171, 27);
            this.btnDeleteFromBasket.TabIndex = 14;
            this.btnDeleteFromBasket.Text = "Usuń ostatnie z koszyka";
            this.btnDeleteFromBasket.UseVisualStyleBackColor = true;
            this.btnDeleteFromBasket.Click += new System.EventHandler(this.btnDeleteFromBasket_Click);
            // 
            // btnCancelBasket
            // 
            this.btnCancelBasket.AutoSize = true;
            this.btnCancelBasket.Location = new System.Drawing.Point(593, 24);
            this.btnCancelBasket.Name = "btnCancelBasket";
            this.btnCancelBasket.Size = new System.Drawing.Size(170, 27);
            this.btnCancelBasket.TabIndex = 15;
            this.btnCancelBasket.Text = "Anuluj cały koszyk";
            this.btnCancelBasket.UseVisualStyleBackColor = true;
            this.btnCancelBasket.Click += new System.EventHandler(this.btnTestCancel_Click);
            // 
            // productUserBasket1
            // 
            this.productUserBasket1.Location = new System.Drawing.Point(168, 92);
            this.productUserBasket1.Name = "productUserBasket1";
            this.productUserBasket1.Size = new System.Drawing.Size(733, 500);
            this.productUserBasket1.TabIndex = 13;
            this.productUserBasket1.Visible = false;
            // 
            // productUserControl1
            // 
            this.productUserControl1.Location = new System.Drawing.Point(168, 108);
            this.productUserControl1.Name = "productUserControl1";
            this.productUserControl1.Size = new System.Drawing.Size(575, 500);
            this.productUserControl1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 697);
            this.Controls.Add(this.btnCancelBasket);
            this.Controls.Add(this.btnDeleteFromBasket);
            this.Controls.Add(this.productUserBasket1);
            this.Controls.Add(this.productUserControl1);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnProduct6);
            this.Controls.Add(this.btnProduct5);
            this.Controls.Add(this.btnProduct4);
            this.Controls.Add(this.btnProduct3);
            this.Controls.Add(this.btnProduct2);
            this.Controls.Add(this.btnProduct1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProduct1;
        private System.Windows.Forms.Button btnProduct2;
        private System.Windows.Forms.Button btnProduct4;
        private System.Windows.Forms.Button btnProduct3;
        private System.Windows.Forms.Button btnProduct6;
        private System.Windows.Forms.Button btnProduct5;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.Button btnAddToBasket;
        private ProductUserControl productUserControl1;
        private ProductUserBasket productUserBasket1;
        private System.Windows.Forms.Button btnDeleteFromBasket;
        private System.Windows.Forms.Button btnCancelBasket;
    }
}

