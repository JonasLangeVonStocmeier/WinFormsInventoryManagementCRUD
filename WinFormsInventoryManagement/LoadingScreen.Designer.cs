namespace WinFormsInventoryManagement
{
    partial class LoadingScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            loadingProgressbar = new ProgressBar();
            label2 = new Label();
            lblLoadingProgress = new Label();
            loadingbarTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // loadingProgressbar
            // 
            loadingProgressbar.Anchor = AnchorStyles.Bottom;
            loadingProgressbar.Location = new Point(14, 59);
            loadingProgressbar.Name = "loadingProgressbar";
            loadingProgressbar.Size = new Size(776, 23);
            loadingProgressbar.Step = 20;
            loadingProgressbar.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(354, 40);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Loading";
            // 
            // lblLoadingProgress
            // 
            lblLoadingProgress.Anchor = AnchorStyles.Bottom;
            lblLoadingProgress.AutoSize = true;
            lblLoadingProgress.Location = new Point(410, 40);
            lblLoadingProgress.Name = "lblLoadingProgress";
            lblLoadingProgress.Size = new Size(23, 15);
            lblLoadingProgress.TabIndex = 2;
            lblLoadingProgress.Text = "0%";
            // 
            // loadingbarTimer
            // 
            loadingbarTimer.Tick += LoadingbarTimer_Tick;
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 91);
            ControlBox = false;
            Controls.Add(lblLoadingProgress);
            Controls.Add(label2);
            Controls.Add(loadingProgressbar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingScreen";
            Text = "Inventory Management System";
            Load += LoadingScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar loadingProgressbar;
        private Label label2;
        private Label lblLoadingProgress;
        private System.Windows.Forms.Timer loadingbarTimer;
    }
}
