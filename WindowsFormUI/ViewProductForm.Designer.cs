namespace WindowsFormUI
{
    partial class ViewProductForm
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
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSoldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sellAppDataSet1 = new WindowsFormUI.SellAppDataSet1();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new WindowsFormUI.SellAppDataSet1TableAdapters.ProductsTableAdapter();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.trans_ditails_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.isSoldDataGridViewCheckBoxColumn});
            this.ProductGridView.DataSource = this.productsBindingSource1;
            this.ProductGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ProductGridView.Location = new System.Drawing.Point(12, 180);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(344, 145);
            this.ProductGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // isSoldDataGridViewCheckBoxColumn
            // 
            this.isSoldDataGridViewCheckBoxColumn.DataPropertyName = "IsSold";
            this.isSoldDataGridViewCheckBoxColumn.HeaderText = "IsSold";
            this.isSoldDataGridViewCheckBoxColumn.Name = "isSoldDataGridViewCheckBoxColumn";
            // 
            // sellAppDataSet1
            // 
            this.sellAppDataSet1.DataSetName = "SellAppDataSet1";
            this.sellAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.sellAppDataSet1;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 139);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(344, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(516, 139);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(120, 20);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(516, 180);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 38);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // trans_ditails_btn
            // 
            this.trans_ditails_btn.Location = new System.Drawing.Point(658, 180);
            this.trans_ditails_btn.Name = "trans_ditails_btn";
            this.trans_ditails_btn.Size = new System.Drawing.Size(120, 38);
            this.trans_ditails_btn.TabIndex = 5;
            this.trans_ditails_btn.Text = "View Transaction Ditails";
            this.trans_ditails_btn.UseVisualStyleBackColor = true;
            this.trans_ditails_btn.Click += new System.EventHandler(this.trans_ditails_btn_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(658, 139);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(120, 20);
            this.sort_btn.TabIndex = 6;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseVisualStyleBackColor = true;
            // 
            // ViewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.trans_ditails_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ProductGridView);
            this.Name = "ViewProductForm";
            this.Text = "ViewProductForm";
            this.Load += new System.EventHandler(this.ViewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSoldDataGridViewCheckBoxColumn;
        private SellAppDataSet1 sellAppDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private SellAppDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button trans_ditails_btn;
        private System.Windows.Forms.Button sort_btn;
    }
}