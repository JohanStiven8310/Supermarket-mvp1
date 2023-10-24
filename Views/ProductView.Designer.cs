namespace Supermarket_mvp.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProductList = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgProduct = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageProductDetail = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProductPrice = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtProductObservation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.tabPageProductDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket_mvp.Properties.Resources.products;
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProductList);
            this.tabControl1.Controls.Add(this.tabPageProductDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            this.tabPageProductList.Controls.Add(this.BtnClose);
            this.tabPageProductList.Controls.Add(this.BtnDelete);
            this.tabPageProductList.Controls.Add(this.BtnEdit);
            this.tabPageProductList.Controls.Add(this.BtnNew);
            this.tabPageProductList.Controls.Add(this.DgProduct);
            this.tabPageProductList.Controls.Add(this.BtnSearch);
            this.tabPageProductList.Controls.Add(this.TxtSearch);
            this.tabPageProductList.Controls.Add(this.label2);
            this.tabPageProductList.Location = new System.Drawing.Point(4, 24);
            this.tabPageProductList.Name = "tabPageProductList";
            this.tabPageProductList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductList.Size = new System.Drawing.Size(792, 363);
            this.tabPageProductList.TabIndex = 0;
            this.tabPageProductList.Text = "Product List";
            this.tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Image = global::Supermarket_mvp.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(585, 288);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(180, 59);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Image = global::Supermarket_mvp.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(585, 214);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(180, 58);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Image = global::Supermarket_mvp.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(585, 141);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(180, 59);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Image = global::Supermarket_mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(585, 70);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(180, 59);
            this.BtnNew.TabIndex = 12;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            this.DgProduct.AllowUserToAddRows = false;
            this.DgProduct.AllowUserToDeleteRows = false;
            this.DgProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProduct.Location = new System.Drawing.Point(27, 70);
            this.DgProduct.Name = "DgProduct";
            this.DgProduct.ReadOnly = true;
            this.DgProduct.RowTemplate.Height = 25;
            this.DgProduct.Size = new System.Drawing.Size(540, 277);
            this.DgProduct.TabIndex = 11;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Image = global::Supermarket_mvp.Properties.Resources.search_small;
            this.BtnSearch.Location = new System.Drawing.Point(523, 25);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(44, 39);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(27, 34);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(490, 23);
            this.TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            this.tabPageProductDetail.Controls.Add(this.label6);
            this.tabPageProductDetail.Controls.Add(this.TxtProductPrice);
            this.tabPageProductDetail.Controls.Add(this.BtnCancel);
            this.tabPageProductDetail.Controls.Add(this.BtnSave);
            this.tabPageProductDetail.Controls.Add(this.TxtProductObservation);
            this.tabPageProductDetail.Controls.Add(this.label5);
            this.tabPageProductDetail.Controls.Add(this.label4);
            this.tabPageProductDetail.Controls.Add(this.TxtProductName);
            this.tabPageProductDetail.Controls.Add(this.label3);
            this.tabPageProductDetail.Controls.Add(this.TxtProductId);
            this.tabPageProductDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPageProductDetail.Name = "tabPageProductDetail";
            this.tabPageProductDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductDetail.Size = new System.Drawing.Size(792, 363);
            this.tabPageProductDetail.TabIndex = 1;
            this.tabPageProductDetail.Text = "Product Detail";
            this.tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // TxtProductPrice
            // 
            this.TxtProductPrice.Location = new System.Drawing.Point(29, 151);
            this.TxtProductPrice.Name = "TxtProductPrice";
            this.TxtProductPrice.PlaceholderText = "Enter Price";
            this.TxtProductPrice.Size = new System.Drawing.Size(278, 23);
            this.TxtProductPrice.TabIndex = 9;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarket_mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(138, 297);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(88, 41);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarket_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(30, 297);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 41);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductObservation
            // 
            this.TxtProductObservation.Location = new System.Drawing.Point(29, 207);
            this.TxtProductObservation.Multiline = true;
            this.TxtProductObservation.Name = "TxtProductObservation";
            this.TxtProductObservation.PlaceholderText = "Product Observation";
            this.TxtProductObservation.Size = new System.Drawing.Size(278, 66);
            this.TxtProductObservation.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product Observation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Id";
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(32, 102);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.PlaceholderText = "Product Name";
            this.TxtProductName.Size = new System.Drawing.Size(278, 23);
            this.TxtProductName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // TxtProductId
            // 
            this.TxtProductId.Location = new System.Drawing.Point(29, 53);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.ReadOnly = true;
            this.TxtProductId.Size = new System.Drawing.Size(157, 23);
            this.TxtProductId.TabIndex = 1;
            this.TxtProductId.Text = "0";
            this.TxtProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductView";
            this.Text = "Product Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageProductList.ResumeLayout(false);
            this.tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.tabPageProductDetail.ResumeLayout(false);
            this.tabPageProductDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductObservation;
        private Label label5;
        private Label label4;
        private TextBox TxtProductName;
        private Label label3;
        private TextBox TxtProductId;
        private TabPage tabPageProductList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Label label6;
        private TextBox TxtProductPrice;
    }
}