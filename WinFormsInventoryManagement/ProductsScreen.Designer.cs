namespace WinFormsInventoryManagement
{
    partial class ProductsScreen
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
            label1 = new Label();
            textBoxProductName = new TextBox();
            textBoxProductBrand = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxPrice = new TextBox();
            label4 = new Label();
            comboBoxCategory = new ComboBox();
            btnProductSave = new Button();
            btnProductEdit = new Button();
            btnProductDelete = new Button();
            btnProductClear = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBoxProductName
            // 
            textBoxProductName.BackColor = SystemColors.ControlLightLight;
            textBoxProductName.BorderStyle = BorderStyle.None;
            textBoxProductName.Location = new Point(75, 9);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(236, 16);
            textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductBrand
            // 
            textBoxProductBrand.BackColor = SystemColors.ControlLightLight;
            textBoxProductBrand.BorderStyle = BorderStyle.None;
            textBoxProductBrand.Location = new Point(75, 37);
            textBoxProductBrand.Name = "textBoxProductBrand";
            textBoxProductBrand.Size = new Size(151, 16);
            textBoxProductBrand.TabIndex = 3;
            textBoxProductBrand.TextChanged += TextBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.ControlLightLight;
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Location = new Point(75, 93);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(74, 16);
            textBoxPrice.TabIndex = 7;
            textBoxPrice.TextChanged += TextBoxPrice_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FlatStyle = FlatStyle.System;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Dairy", "Drinks", "Drugs", "Fish", "Meat", "Vegetables", "" });
            comboBoxCategory.Location = new Point(75, 62);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 23);
            comboBoxCategory.TabIndex = 8;
            // 
            // btnProductSave
            // 
            btnProductSave.Location = new Point(74, 121);
            btnProductSave.Name = "btnProductSave";
            btnProductSave.Size = new Size(75, 23);
            btnProductSave.TabIndex = 9;
            btnProductSave.Text = "Save";
            btnProductSave.UseVisualStyleBackColor = true;
            btnProductSave.Click += BtnProductSave_Click;
            // 
            // btnProductEdit
            // 
            btnProductEdit.Location = new Point(155, 121);
            btnProductEdit.Name = "btnProductEdit";
            btnProductEdit.Size = new Size(75, 23);
            btnProductEdit.TabIndex = 10;
            btnProductEdit.Text = "Edit";
            btnProductEdit.UseVisualStyleBackColor = true;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Location = new Point(317, 121);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(75, 23);
            btnProductDelete.TabIndex = 11;
            btnProductDelete.Text = "Delete";
            btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // btnProductClear
            // 
            btnProductClear.Location = new Point(236, 121);
            btnProductClear.Name = "btnProductClear";
            btnProductClear.Size = new Size(75, 23);
            btnProductClear.TabIndex = 12;
            btnProductClear.Text = "Clear";
            btnProductClear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(775, 292);
            dataGridView1.TabIndex = 13;
            // 
            // ProductsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImgBgProducts;
            ClientSize = new Size(799, 461);
            Controls.Add(dataGridView1);
            Controls.Add(btnProductClear);
            Controls.Add(btnProductDelete);
            Controls.Add(btnProductEdit);
            Controls.Add(btnProductSave);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxProductBrand);
            Controls.Add(label2);
            Controls.Add(textBoxProductName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductsScreen";
            Text = "ProductsScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxProductName;
        private TextBox textBoxProductBrand;
        private Label label2;
        private Label label3;
        private TextBox textBoxPrice;
        private Label label4;
        private ComboBox comboBoxCategory;
        private Button btnProductSave;
        private Button btnProductEdit;
        private Button btnProductDelete;
        private Button btnProductClear;
        private DataGridView dataGridView1;
    }
}