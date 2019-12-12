namespace WindowsFormUI
{
    partial class ProductOnAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Price";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(163, 49);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(140, 20);
            this.name_box.TabIndex = 2;
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(163, 81);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(140, 20);
            this.price_box.TabIndex = 3;
            // 
            // add_btn
            // 
            this.add_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.add_btn.Location = new System.Drawing.Point(163, 128);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(54, 23);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(249, 128);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(54, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // ProductOnAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 201);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductOnAddForm";
            this.Text = "ProductOnAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        protected internal System.Windows.Forms.TextBox name_box;
        protected internal System.Windows.Forms.TextBox price_box;
    }
}