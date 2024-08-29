using ArazHesenovWinform.Crud.GetAllForm;
using ArazHesenovWinform.Crud.Insert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArazHesenovWinform
{
    public partial class InsertProduct : Form
    {
        public InsertProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text!=string.Empty && txtPrice.Text!=string.Empty && txtProduct.Text != string.Empty && cmbCategoryAdd.Text!=string.Empty)
            {
                AddProduct insert = new AddProduct(txtProduct.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDecimal(txtPrice.Text), cmbCategoryAdd.SelectedValue.ToString());
                txtProduct.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                txtPrice.Text = string.Empty;
                cmbCategoryAdd.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Xana bosh ola bilmez", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   

        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != string.Empty)
            {
                AddCategory category = new AddCategory(txtCategory.Text);
                txtCategory.Text = string.Empty;
                GetCategory1 get = new GetCategory1(cmbCategoryAdd);
            }
            else
            {
                MessageBox.Show("Xana bosh ola bilmez","Xeta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

           
        }
    }
}
