namespace WebApp
{
    partial class EditBookmark
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.title_label = new System.Windows.Forms.Label();
            this.label_URL = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(147, 82);
            this.title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(70, 23);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title";
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.BackColor = System.Drawing.Color.Transparent;
            this.label_URL.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_URL.Location = new System.Drawing.Point(161, 162);
            this.label_URL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(46, 23);
            this.label_URL.TabIndex = 1;
            this.label_URL.Text = "URL";
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(225, 76);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(243, 31);
            this.Header.TabIndex = 2;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(225, 156);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(243, 31);
            this.Address.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Black;
            this.save_button.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(147, 243);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(107, 38);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.SaveButtonEditForm);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Black;
            this.cancel_button.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(361, 243);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(107, 38);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.CancelButtonEditForm);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 53);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Bookmark";
            // 
            // EditFavourite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(616, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label_URL);
            this.Controls.Add(this.title_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditFavourite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFavourite";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title_label;
        private Label label_URL;
        private TextBox Header;
        private TextBox Address;
        private Button save_button;
        private Button cancel_button;
        private Panel panel1;
        private Label label1;
    }
}