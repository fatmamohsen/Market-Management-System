
namespace superMerktManagementSystem
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Amtbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerNamelbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.Amtbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SellerNamelbl);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.ProdDGV1);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BillID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 571);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Amtbl
            // 
            this.Amtbl.AutoSize = true;
            this.Amtbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Amtbl.Location = new System.Drawing.Point(521, 235);
            this.Amtbl.Name = "Amtbl";
            this.Amtbl.Size = new System.Drawing.Size(29, 23);
            this.Amtbl.TabIndex = 22;
            this.Amtbl.Text = "Rs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(405, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Amount Rs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(496, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sells List";
            // 
            // OrderDGV
            // 
            this.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            this.OrderDGV.Location = new System.Drawing.Point(313, 54);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.ReadOnly = true;
            this.OrderDGV.RowHeadersVisible = false;
            this.OrderDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(446, 157);
            this.OrderDGV.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdId";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button1.Location = new System.Drawing.Point(79, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerNamelbl
            // 
            this.SellerNamelbl.AutoSize = true;
            this.SellerNamelbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.SellerNamelbl.Location = new System.Drawing.Point(58, 5);
            this.SellerNamelbl.Name = "SellerNamelbl";
            this.SellerNamelbl.Size = new System.Drawing.Size(60, 23);
            this.SellerNamelbl.TabIndex = 17;
            this.SellerNamelbl.Text = "Seller";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Datelbl.Location = new System.Drawing.Point(627, 5);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(54, 23);
            this.Datelbl.TabIndex = 16;
            this.Datelbl.Text = "Date";
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProdDGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV1.Location = new System.Drawing.Point(13, 302);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.ReadOnly = true;
            this.ProdDGV1.RowHeadersVisible = false;
            this.ProdDGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProdDGV1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV1.Size = new System.Drawing.Size(271, 252);
            this.ProdDGV1.TabIndex = 15;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.SystemColors.Control;
            this.ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdPrice.Enabled = false;
            this.ProdPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ProdPrice.Location = new System.Drawing.Point(110, 133);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ProdPrice.Multiline = true;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(174, 35);
            this.ProdPrice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantity";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button8.Location = new System.Drawing.Point(163, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 29);
            this.button8.TabIndex = 12;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // BillsDGV
            // 
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(313, 320);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.ReadOnly = true;
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BillsDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(446, 186);
            this.BillsDGV.TabIndex = 10;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button5.Location = new System.Drawing.Point(601, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button6.Location = new System.Drawing.Point(395, 512);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 42);
            this.button6.TabIndex = 6;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.CatCb.Location = new System.Drawing.Point(13, 264);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(146, 29);
            this.CatCb.TabIndex = 8;
            this.CatCb.Text = "Select Category";
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            this.CatCb.SelectionChangeCommitted += new System.EventHandler(this.CatCb_SelectionChangeCommitted);
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.SystemColors.Control;
            this.ProdQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ProdQty.Location = new System.Drawing.Point(110, 176);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ProdQty.Multiline = true;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(174, 35);
            this.ProdQty.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.SystemColors.Control;
            this.ProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdName.Enabled = false;
            this.ProdName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ProdName.Location = new System.Drawing.Point(110, 90);
            this.ProdName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.ProdName.Multiline = true;
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(174, 35);
            this.ProdName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProdName";
            // 
            // BillID
            // 
            this.BillID.BackColor = System.Drawing.SystemColors.Control;
            this.BillID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BillID.Location = new System.Drawing.Point(110, 47);
            this.BillID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.BillID.Multiline = true;
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(174, 35);
            this.BillID.TabIndex = 2;
            this.BillID.TextChanged += new System.EventHandler(this.PordId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Billid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(342, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selling";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label8.Location = new System.Drawing.Point(50, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Logout";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button4.Location = new System.Drawing.Point(913, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 38);
            this.button4.TabIndex = 23;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 629);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView BillsDGV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BillID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SellerNamelbl;
        private System.Windows.Forms.Label Amtbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
    }
}