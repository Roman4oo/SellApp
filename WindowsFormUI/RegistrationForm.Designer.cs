namespace WindowsFormUI
{
    partial class RegistrationForm
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
            this.lname_box = new System.Windows.Forms.TextBox();
            this.fname_box = new System.Windows.Forms.TextBox();
            this.pas_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.pas_lbl = new System.Windows.Forms.Label();
            this.fname_lbl = new System.Windows.Forms.Label();
            this.lname_lbl = new System.Windows.Forms.Label();
            this.backToLogin_btn = new System.Windows.Forms.Button();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lname_box
            // 
            this.lname_box.Location = new System.Drawing.Point(316, 219);
            this.lname_box.Name = "lname_box";
            this.lname_box.Size = new System.Drawing.Size(167, 20);
            this.lname_box.TabIndex = 1;
            // 
            // fname_box
            // 
            this.fname_box.Location = new System.Drawing.Point(316, 187);
            this.fname_box.Name = "fname_box";
            this.fname_box.Size = new System.Drawing.Size(167, 20);
            this.fname_box.TabIndex = 2;
            // 
            // pas_box
            // 
            this.pas_box.Location = new System.Drawing.Point(316, 151);
            this.pas_box.Name = "pas_box";
            this.pas_box.Size = new System.Drawing.Size(167, 20);
            this.pas_box.TabIndex = 3;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(316, 116);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(167, 20);
            this.email_box.TabIndex = 4;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(252, 119);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(32, 13);
            this.email_lbl.TabIndex = 5;
            this.email_lbl.Text = "Email";
            // 
            // pas_lbl
            // 
            this.pas_lbl.AutoSize = true;
            this.pas_lbl.Location = new System.Drawing.Point(252, 154);
            this.pas_lbl.Name = "pas_lbl";
            this.pas_lbl.Size = new System.Drawing.Size(53, 13);
            this.pas_lbl.TabIndex = 6;
            this.pas_lbl.Text = "Password";
            // 
            // fname_lbl
            // 
            this.fname_lbl.AutoSize = true;
            this.fname_lbl.Location = new System.Drawing.Point(252, 190);
            this.fname_lbl.Name = "fname_lbl";
            this.fname_lbl.Size = new System.Drawing.Size(57, 13);
            this.fname_lbl.TabIndex = 7;
            this.fname_lbl.Text = "First Name";
            // 
            // lname_lbl
            // 
            this.lname_lbl.AutoSize = true;
            this.lname_lbl.Location = new System.Drawing.Point(252, 222);
            this.lname_lbl.Name = "lname_lbl";
            this.lname_lbl.Size = new System.Drawing.Size(58, 13);
            this.lname_lbl.TabIndex = 8;
            this.lname_lbl.Text = "Last Name";
            // 
            // backToLogin_btn
            // 
            this.backToLogin_btn.Location = new System.Drawing.Point(428, 281);
            this.backToLogin_btn.Name = "backToLogin_btn";
            this.backToLogin_btn.Size = new System.Drawing.Size(97, 23);
            this.backToLogin_btn.TabIndex = 9;
            this.backToLogin_btn.Text = "Back to Login";
            this.backToLogin_btn.UseVisualStyleBackColor = true;
            this.backToLogin_btn.Click += new System.EventHandler(this.backToLogin_btn_Click);
            // 
            // signUp_btn
            // 
            this.signUp_btn.Location = new System.Drawing.Point(255, 281);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(97, 23);
            this.signUp_btn.TabIndex = 10;
            this.signUp_btn.Text = "Sign Up";
            this.signUp_btn.UseVisualStyleBackColor = true;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 488);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.backToLogin_btn);
            this.Controls.Add(this.lname_lbl);
            this.Controls.Add(this.fname_lbl);
            this.Controls.Add(this.pas_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.pas_box);
            this.Controls.Add(this.fname_box);
            this.Controls.Add(this.lname_box);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lname_box;
        private System.Windows.Forms.TextBox fname_box;
        private System.Windows.Forms.TextBox pas_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label pas_lbl;
        private System.Windows.Forms.Label fname_lbl;
        private System.Windows.Forms.Label lname_lbl;
        private System.Windows.Forms.Button backToLogin_btn;
        private System.Windows.Forms.Button signUp_btn;
    }
}