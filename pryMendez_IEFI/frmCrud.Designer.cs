namespace pryMendez_IEFI
{
    partial class frmCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrud));
            btnBackToMainCrud = new Button();
            SuspendLayout();
            // 
            // btnBackToMainCrud
            // 
            btnBackToMainCrud.Location = new Point(659, 541);
            btnBackToMainCrud.Name = "btnBackToMainCrud";
            btnBackToMainCrud.Size = new Size(175, 29);
            btnBackToMainCrud.TabIndex = 2;
            btnBackToMainCrud.Text = "Back to Main";
            btnBackToMainCrud.UseVisualStyleBackColor = true;
            btnBackToMainCrud.Click += btnBackToMainCrud_Click;
            // 
            // frmCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(914, 600);
            Controls.Add(btnBackToMainCrud);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCrud";
            Text = "Edit Users";
            Load += frmCrud_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackToMainCrud;
    }
}