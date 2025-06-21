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
            dgvCrudOperations = new DataGridView();
            lblCrudOperations = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCrudOperations).BeginInit();
            SuspendLayout();
            // 
            // btnBackToMainCrud
            // 
            btnBackToMainCrud.Location = new Point(727, 559);
            btnBackToMainCrud.Name = "btnBackToMainCrud";
            btnBackToMainCrud.Size = new Size(175, 29);
            btnBackToMainCrud.TabIndex = 2;
            btnBackToMainCrud.Text = "Back to Main";
            btnBackToMainCrud.UseVisualStyleBackColor = true;
            btnBackToMainCrud.Click += btnBackToMainCrud_Click;
            // 
            // dgvCrudOperations
            // 
            dgvCrudOperations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCrudOperations.Location = new Point(12, 48);
            dgvCrudOperations.Name = "dgvCrudOperations";
            dgvCrudOperations.RowHeadersWidth = 51;
            dgvCrudOperations.Size = new Size(890, 505);
            dgvCrudOperations.TabIndex = 3;
            // 
            // lblCrudOperations
            // 
            lblCrudOperations.AutoSize = true;
            lblCrudOperations.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrudOperations.Location = new Point(12, 4);
            lblCrudOperations.Name = "lblCrudOperations";
            lblCrudOperations.Size = new Size(252, 41);
            lblCrudOperations.TabIndex = 4;
            lblCrudOperations.Text = "CRUD Operations";
            // 
            // frmCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(914, 600);
            Controls.Add(lblCrudOperations);
            Controls.Add(dgvCrudOperations);
            Controls.Add(btnBackToMainCrud);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCrud";
            Text = "Edit Users";
            Load += frmCrud_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCrudOperations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackToMainCrud;
        private DataGridView dgvCrudOperations;
        private Label lblCrudOperations;
    }
}