namespace WebApp
{
    partial class EditHomePage
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
            this.enter_page_url_label = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.save_button_form_edit = new System.Windows.Forms.Button();
            this.cancel_button_form = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enter_page_url_label
            // 
            this.enter_page_url_label.AutoSize = true;
            this.enter_page_url_label.BackColor = System.Drawing.Color.Transparent;
            this.enter_page_url_label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enter_page_url_label.Location = new System.Drawing.Point(39, 108);
            this.enter_page_url_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enter_page_url_label.Name = "enter_page_url_label";
            this.enter_page_url_label.Size = new System.Drawing.Size(238, 23);
            this.enter_page_url_label.TabIndex = 0;
            this.enter_page_url_label.Text = "Enter home page URL";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(297, 102);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(267, 31);
            this.tb1.TabIndex = 1;
            // 
            // save_button_form_edit
            // 
            this.save_button_form_edit.BackColor = System.Drawing.Color.Black;
            this.save_button_form_edit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_button_form_edit.ForeColor = System.Drawing.Color.White;
            this.save_button_form_edit.Location = new System.Drawing.Point(127, 187);
            this.save_button_form_edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_button_form_edit.Name = "save_button_form_edit";
            this.save_button_form_edit.Size = new System.Drawing.Size(107, 38);
            this.save_button_form_edit.TabIndex = 2;
            this.save_button_form_edit.Text = "Save";
            this.save_button_form_edit.UseVisualStyleBackColor = false;
            this.save_button_form_edit.Click += new System.EventHandler(this.SaveButtonHomePageEdit);
            // 
            // cancel_button_form
            // 
            this.cancel_button_form.BackColor = System.Drawing.Color.Black;
            this.cancel_button_form.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button_form.ForeColor = System.Drawing.Color.White;
            this.cancel_button_form.Location = new System.Drawing.Point(365, 187);
            this.cancel_button_form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel_button_form.Name = "cancel_button_form";
            this.cancel_button_form.Size = new System.Drawing.Size(107, 38);
            this.cancel_button_form.TabIndex = 3;
            this.cancel_button_form.Text = "Cancel";
            this.cancel_button_form.UseVisualStyleBackColor = false;
            this.cancel_button_form.Click += new System.EventHandler(this.CancelButtonHomePageEdit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 53);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Home Page";
            // 
            // FormEditHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(616, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_button_form);
            this.Controls.Add(this.save_button_form_edit);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.enter_page_url_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEditHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditHomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label enter_page_url_label;
        private TextBox tb1;
        private Button save_button_form_edit;
        private Button cancel_button_form;
        private Panel panel1;
        private Label label1;
    }
}