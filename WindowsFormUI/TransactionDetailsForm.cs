using BLL;
using BLL.Services.Abstract;
using System;
using System.Windows.Forms;

namespace WindowsFormUI
{
    public partial class TransactionDetailsForm : Form
    {
        private readonly ITransactionService _transactionService;
        public TransactionDetailsForm(ITransactionService transactionService)
        {
            _transactionService = transactionService;
            InitializeComponent();
        }

        private void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellAppDataSet3.Transactions_View' table. You can move, or remove it, as needed.
            this.transactions_ViewTableAdapter2.Fill(this.sellAppDataSet3.Transactions_View);
            // TODO: This line of code loads data into the 'sellAppDataSet2.Transactions_View' table. You can move, or remove it, as needed.





        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            DeleteByIdForm deleteByIdForm = DependencyInjectorUnity.Resolve<DeleteByIdForm>();
            DialogResult result = deleteByIdForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            int id = Convert.ToInt32(deleteByIdForm.id_box.Text);

            _transactionService.Delete(id);
            this.transactions_ViewTableAdapter2.Fill(this.sellAppDataSet3.Transactions_View);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
