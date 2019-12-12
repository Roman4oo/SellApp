using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void view_sold_products_btn_Click(object sender, EventArgs e)
        {
            ViewProductForm viewSoldProductsForm = DependencyInjectorUnity.Resolve<ViewProductForm>();
            viewSoldProductsForm.Show();
            this.Hide();
        }
    }
}
