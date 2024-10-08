namespace WinFormsInventoryManagement
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            btnProducts = new Button();
            btnBill = new Button();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.BackgroundImage = Properties.Resources.BtnImgProducts;
            btnProducts.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProducts.ForeColor = Color.Snow;
            btnProducts.Location = new Point(12, 12);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(275, 125);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnBill
            // 
            btnBill.BackgroundImage = (Image)resources.GetObject("btnBill.BackgroundImage");
            btnBill.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBill.ForeColor = Color.Snow;
            btnBill.Location = new Point(314, 12);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(275, 125);
            btnBill.TabIndex = 1;
            btnBill.Text = "Create Invoice";
            btnBill.UseVisualStyleBackColor = true;
            // 
            // MainMenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(601, 149);
            Controls.Add(btnBill);
            Controls.Add(btnProducts);
            Name = "MainMenuScreen";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProducts;
        private Button btnBill;
    }
}