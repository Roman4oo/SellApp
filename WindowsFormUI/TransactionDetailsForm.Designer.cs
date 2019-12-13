namespace WindowsFormUI
{
    partial class TransactionDetailsForm
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
            this.transactionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delete_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.transactionsViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TransactionGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sellAppDataSet11 = new WindowsFormUI.SellAppDataSet1();
            this.transactionsViewTableAdapter = new WindowsFormUI.SellAppDataSet1TableAdapters.TransactionsViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transactionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAppDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionViewBindingSource
            // 
            this.transactionViewBindingSource.DataMember = "TransactionView";
            // 
            // transactionsViewBindingSource
            // 
            this.transactionsViewBindingSource.DataMember = "Transactions_View";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(665, 59);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(123, 36);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete Transaction by Id";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_btn.Location = new System.Drawing.Point(665, 296);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(123, 36);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // transactionsViewBindingSource1
            // 
            this.transactionsViewBindingSource1.DataMember = "Transactions_View";
            // 
            // TransactionGridView1
            // 
            this.TransactionGridView1.AutoGenerateColumns = false;
            this.TransactionGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.productIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn10});
            this.TransactionGridView1.DataSource = this.transactionsViewBindingSource2;
            this.TransactionGridView1.Location = new System.Drawing.Point(12, 59);
            this.TransactionGridView1.Name = "TransactionGridView1";
            this.TransactionGridView1.Size = new System.Drawing.Size(645, 273);
            this.TransactionGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn9.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TransactionID";
            this.dataGridViewTextBoxColumn10.HeaderText = "TransactionID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // transactionsViewBindingSource2
            // 
            this.transactionsViewBindingSource2.DataMember = "TransactionsView";
            this.transactionsViewBindingSource2.DataSource = this.sellAppDataSet11;
            // 
            // sellAppDataSet11
            // 
            this.sellAppDataSet11.DataSetName = "SellAppDataSet1";
            this.sellAppDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsViewTableAdapter
            // 
            this.transactionsViewTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TransactionGridView1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.delete_btn);
            this.Name = "TransactionDetailsForm";
            this.Text = "TransactionDetailsForm";
            this.Load += new System.EventHandler(this.TransactionDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAppDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource transactionViewBindingSource;
        private SellAppDataSet sellAppDataSet;
        private System.Windows.Forms.BindingSource transactionsViewBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        protected internal System.Windows.Forms.Button delete_btn;
        protected internal System.Windows.Forms.Button back_btn;
        private SellAppDataSet sellAppDataSet1;
        private SellAppDataSet sellAppDataSet2;
        private System.Windows.Forms.BindingSource transactionsViewBindingSource1;
 
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TransactionGridView1;
        private SellAppDataSet1 sellAppDataSet11;
        private System.Windows.Forms.BindingSource transactionsViewBindingSource2;
        private SellAppDataSet1TableAdapters.TransactionsViewTableAdapter transactionsViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}