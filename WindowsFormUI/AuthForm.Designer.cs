using System;

namespace WindowsFormUI
{
    partial class AuthForm
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
            this.components = new System.ComponentModel.Container();
            this.email_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pas_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(308, 145);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(207, 20);
            this.email_box.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // pas_box
            // 
            this.pas_box.Location = new System.Drawing.Point(308, 197);
            this.pas_box.Name = "pas_box";
            this.pas_box.Size = new System.Drawing.Size(207, 20);
            this.pas_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // signIn_btn
            // 
            this.signIn_btn.Location = new System.Drawing.Point(308, 255);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(75, 23);
            this.signIn_btn.TabIndex = 4;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.UseVisualStyleBackColor = true;
            // 
            // signUp_btn
            // 
            this.signUp_btn.Location = new System.Drawing.Point(440, 255);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(75, 23);
            this.signUp_btn.TabIndex = 5;
            this.signUp_btn.Text = "Sign Up";
            this.signUp_btn.UseVisualStyleBackColor = true;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.signIn_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pas_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_box);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pas_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.Button signUp_btn;
    }
}

