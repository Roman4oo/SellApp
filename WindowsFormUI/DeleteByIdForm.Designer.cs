namespace WindowsFormUI
{
    partial class DeleteByIdForm
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
            this.id_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(134, 45);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 20);
            this.id_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // ok_btn
            // 
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.Location = new System.Drawing.Point(134, 95);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(42, 23);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_btn.Location = new System.Drawing.Point(192, 95);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(42, 23);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // DeleteByIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 165);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_box);
            this.Name = "DeleteByIdForm";
            this.Text = "DeleteByIdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button ok_btn;
        protected internal System.Windows.Forms.TextBox id_box;
        protected internal System.Windows.Forms.Button back_btn;
    }
}