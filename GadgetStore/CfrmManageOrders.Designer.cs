namespace WindowsFormsApp1
{
    partial class CfrmManageOrders
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oCustomerGV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.oProductsGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtoCustomerId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtoOrderId = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.MaskedTextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.oOrderGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotAmount = new System.Windows.Forms.Label();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCustomerGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOrderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 656);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1199, 15);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 100);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1169, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(328, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gadget Store Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // oCustomerGV
            // 
            this.oCustomerGV.BackgroundColor = System.Drawing.Color.White;
            this.oCustomerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oCustomerGV.Location = new System.Drawing.Point(10, 129);
            this.oCustomerGV.Name = "oCustomerGV";
            this.oCustomerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oCustomerGV.Size = new System.Drawing.Size(418, 223);
            this.oCustomerGV.TabIndex = 17;
            this.oCustomerGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oCustomerGV_CellContentClick);
            this.oCustomerGV.Click += new System.EventHandler(this.oCustomerGV_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(142, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Customer List";
            // 
            // oProductsGV
            // 
            this.oProductsGV.BackgroundColor = System.Drawing.Color.White;
            this.oProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oProductsGV.Location = new System.Drawing.Point(435, 129);
            this.oProductsGV.Name = "oProductsGV";
            this.oProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oProductsGV.Size = new System.Drawing.Size(754, 223);
            this.oProductsGV.TabIndex = 19;
            this.oProductsGV.Click += new System.EventHandler(this.oProductsGV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(36, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Customer ID";
            // 
            // txtoCustomerId
            // 
            this.txtoCustomerId.Location = new System.Drawing.Point(119, 417);
            this.txtoCustomerId.Name = "txtoCustomerId";
            this.txtoCustomerId.Size = new System.Drawing.Size(207, 20);
            this.txtoCustomerId.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(57, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Order ID";
            // 
            // txtoOrderId
            // 
            this.txtoOrderId.Location = new System.Drawing.Point(119, 391);
            this.txtoOrderId.Name = "txtoOrderId";
            this.txtoOrderId.Size = new System.Drawing.Size(207, 20);
            this.txtoOrderId.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(7, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 473);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // cmboCategory
            // 
            this.cmboCategory.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.Location = new System.Drawing.Point(435, 106);
            this.cmboCategory.Name = "cmboCategory";
            this.cmboCategory.Size = new System.Drawing.Size(168, 21);
            this.cmboCategory.TabIndex = 49;
            this.cmboCategory.Text = "Select Category";
            this.cmboCategory.SelectedIndexChanged += new System.EventHandler(this.cmboCategory_SelectedIndexChanged);
            this.cmboCategory.SelectionChangeCommitted += new System.EventHandler(this.cmboCategory_SelectionChangeCommitted);
            this.cmboCategory.SelectedValueChanged += new System.EventHandler(this.cmboCategory_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(432, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(492, 363);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(207, 20);
            this.txtQty.TabIndex = 50;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Teal;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(707, 356);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(124, 31);
            this.btnAddOrder.TabIndex = 52;
            this.btnAddOrder.Text = "Add To Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // oOrderGV
            // 
            this.oOrderGV.BackgroundColor = System.Drawing.Color.White;
            this.oOrderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oOrderGV.Location = new System.Drawing.Point(435, 391);
            this.oOrderGV.Name = "oOrderGV";
            this.oOrderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.oOrderGV.Size = new System.Drawing.Size(754, 197);
            this.oOrderGV.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(16, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Customer Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(119, 443);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(207, 20);
            this.txtCusName.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(703, 600);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "Total Amount";
            // 
            // lblTotAmount
            // 
            this.lblTotAmount.AutoSize = true;
            this.lblTotAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotAmount.Location = new System.Drawing.Point(831, 600);
            this.lblTotAmount.Name = "lblTotAmount";
            this.lblTotAmount.Size = new System.Drawing.Size(0, 18);
            this.lblTotAmount.TabIndex = 57;
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.BackColor = System.Drawing.Color.Teal;
            this.btnInsertOrder.FlatAppearance.BorderSize = 0;
            this.btnInsertOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOrder.ForeColor = System.Drawing.Color.White;
            this.btnInsertOrder.Location = new System.Drawing.Point(119, 520);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(105, 36);
            this.btnInsertOrder.TabIndex = 58;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.UseVisualStyleBackColor = false;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.Teal;
            this.btnViewOrders.FlatAppearance.BorderSize = 0;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.Location = new System.Drawing.Point(231, 520);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(104, 36);
            this.btnViewOrders.TabIndex = 59;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(161, 566);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(124, 34);
            this.btnHome.TabIndex = 60;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CfrmManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 671);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.lblTotAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.oOrderGV);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cmboCategory);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtoCustomerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtoOrderId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oProductsGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.oCustomerGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CfrmManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.CfrmManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCustomerGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOrderGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView oCustomerGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView oProductsGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtoCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtoOrderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtQty;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView oOrderGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCusName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotAmount;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnHome;
    }
}