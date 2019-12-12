namespace WindowsFormUI
{
    partial class MainForm
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
            this.view_sold_products_btn = new System.Windows.Forms.Button();
            this.log_out_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_sold_products_btn
            // 
            this.view_sold_products_btn.Location = new System.Drawing.Point(12, 12);
            this.view_sold_products_btn.Name = "view_sold_products_btn";
            this.view_sold_products_btn.Size = new System.Drawing.Size(110, 33);
            this.view_sold_products_btn.TabIndex = 0;
            this.view_sold_products_btn.Text = "View Sold Products";
            this.view_sold_products_btn.UseVisualStyleBackColor = true;
            this.view_sold_products_btn.Click += new System.EventHandler(this.view_sold_products_btn_Click);
            // 
            // log_out_btn
            // 
            this.log_out_btn.Location = new System.Drawing.Point(678, 12);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(110, 33);
            this.log_out_btn.TabIndex = 1;
            this.log_out_btn.Text = "Log Out";
            this.log_out_btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log_out_btn);
            this.Controls.Add(this.view_sold_products_btn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_sold_products_btn;
        private System.Windows.Forms.Button log_out_btn;
    }
}