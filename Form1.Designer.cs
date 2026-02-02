namespace Wk3Assignment3._4
{
    partial class Form1
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
            dgMenu = new DataGridView();
            lblMenu = new Label();
            lblName = new Label();
            lblSize = new Label();
            lblIce = new Label();
            lblSugar = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            cbSize = new ComboBox();
            cbIce = new ComboBox();
            cbSugar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgMenu).BeginInit();
            SuspendLayout();
            // 
            // dgMenu
            // 
            dgMenu.BackgroundColor = SystemColors.GradientActiveCaption;
            dgMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMenu.GridColor = SystemColors.InfoText;
            dgMenu.Location = new Point(26, 75);
            dgMenu.Name = "dgMenu";
            dgMenu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgMenu.Size = new Size(734, 150);
            dgMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(335, 18);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(108, 37);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Stencil", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.Location = new Point(67, 278);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 18);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Stencil", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(67, 320);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 18);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            // 
            // lblIce
            // 
            lblIce.AutoSize = true;
            lblIce.Font = new Font("Stencil", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIce.Location = new Point(67, 357);
            lblIce.Name = "lblIce";
            lblIce.Size = new Size(32, 18);
            lblIce.TabIndex = 4;
            lblIce.Text = "Ice";
            // 
            // lblSugar
            // 
            lblSugar.AutoSize = true;
            lblSugar.Font = new Font("Stencil", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugar.Location = new Point(67, 401);
            lblSugar.Name = "lblSugar";
            lblSugar.Size = new Size(54, 18);
            lblSugar.TabIndex = 5;
            lblSugar.Text = "Sugar";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.Location = new Point(138, 241);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add to Menu";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(488, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 43);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Location = new Point(121, 273);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 23);
            txtName.TabIndex = 8;
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(158, 319);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(121, 23);
            cbSize.TabIndex = 9;
            // 
            // cbIce
            // 
            cbIce.FormattingEnabled = true;
            cbIce.Location = new Point(158, 357);
            cbIce.Name = "cbIce";
            cbIce.Size = new Size(121, 23);
            cbIce.TabIndex = 10;
            // 
            // cbSugar
            // 
            cbSugar.FormattingEnabled = true;
            cbSugar.Location = new Point(158, 396);
            cbSugar.Name = "cbSugar";
            cbSugar.Size = new Size(121, 23);
            cbSugar.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSugar);
            Controls.Add(cbIce);
            Controls.Add(cbSize);
            Controls.Add(txtName);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblSugar);
            Controls.Add(lblIce);
            Controls.Add(lblSize);
            Controls.Add(lblName);
            Controls.Add(lblMenu);
            Controls.Add(dgMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMenu;
        private Label lblMenu;
        private Label lblName;
        private Label lblSize;
        private Label lblIce;
        private Label lblSugar;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtName;
        private ComboBox cbSize;
        private ComboBox cbIce;
        private ComboBox cbSugar;
    }
}
