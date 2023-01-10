using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add( new Product()
            {
                Name=txtName.Text,
                UnitPrice=Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount=Convert.ToInt32(txtStockAmount.Text)
            });
            LoadProduct();
            MessageBox.Show("Product added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product= new Product
            {
                Id =Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name= txtUpdateName.Text.ToString(),
                UnitPrice=Convert.ToDecimal(txtUpdateUnitPrice.Text),
                StockAmount = Convert.ToInt32(txtUpdateStockAmount.Text)
            };
            _productDal.Update(product);
            LoadProduct();
            MessageBox.Show("Update");
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtUpdateStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProduct();
            MessageBox.Show("Deleted!!!");
        }
    }
}
