using BLL;
using BLL.Services.Abstract;
using DAL.Models.ViewModels;
using System;
using System.Windows.Forms;

namespace WindowsFormUI
{
    public partial class ViewProductForm : Form
    {
        private readonly IProductService _productService;

        public ViewProductForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void ViewProductForm_Load(object sender, EventArgs e)
        {
            _productService.UpdateIsSoldPropertyIfNoTransaction();
            this.productsTableAdapter1.Fill(this.sellAppDataSet1.Products);


        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            ProductOnAddForm productForm = DependencyInjectorUnity.Resolve<ProductOnAddForm>();
            DialogResult result = productForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            ProductViewModel productViewModel = new ProductViewModel
            {
                Name = productForm.name_box.Text,
                Price = Convert.ToInt64(productForm.price_box.Text)
            };

            _productService.Add(productViewModel);

            MessageBox.Show("Product have been Added succesfully");


            this.productsTableAdapter1.Fill(this.sellAppDataSet1.Products);



        }

        private void trans_ditails_btn_Click(object sender, EventArgs e)
        {
            TransactionDetailsForm transactionDetailsForm = DependencyInjectorUnity.Resolve<TransactionDetailsForm>();
            transactionDetailsForm.Show();
            this.Hide();
        }
    }
}
