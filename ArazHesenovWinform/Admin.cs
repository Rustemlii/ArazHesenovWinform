using ArazHesenovWinform.Crud;
using ArazHesenovWinform.Crud.Delete;
using ArazHesenovWinform.Crud.GetAllForm;
using ArazHesenovWinform.SqlConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArazHesenovWinform
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public Admin()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            GetAllProduct get = new GetAllProduct(dataGridView1);
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Malın adı"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Tip"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Say"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Qiymet"].SortMode = DataGridViewColumnSortMode.NotSortable;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Malın adı"].ReadOnly = true;
                row.Cells["Tip"].ReadOnly = true;
                row.Cells["Say"].ReadOnly = true;
                row.Cells["Qiymet"].ReadOnly = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Mal yoxdursa Popup cixsin....
            Search search = new Search(txtSearch.Text, dataGridView1);
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Ad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Tip"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Say"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Qiymet"].SortMode = DataGridViewColumnSortMode.NotSortable;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Ad"].ReadOnly = true;
                row.Cells["Tip"].ReadOnly = true;
                row.Cells["Say"].ReadOnly = true;
                row.Cells["Qiymet"].ReadOnly = true;
            }
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            string ad;
            string tip;
            if (dataGridView1.Columns.Count == 5)
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    id = Convert.ToInt32(row.Cells[0].Value.ToString());

                    Delete delete = new Delete(id);
                    GetAllProduct get = new GetAllProduct(dataGridView1);

                }
            }
            else
            {

                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    ad = item.Cells[0].Value.ToString();
                    tip = item.Cells[1].Value.ToString();
                    DeleteSales del = new DeleteSales(ad, tip);
                    GetSales get = new GetSales(dataGridView1, dateStart, dateEnd);
                }
            }


        }
        void CloseText()
        {
            txtType.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtPrice.ReadOnly = true;
        }
        void OpenText()
        {
            txtPrice.ReadOnly = false;
            txtQuantity.ReadOnly = false;
            txtType.ReadOnly = false;
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int a = 0;
            a = e.RowIndex;

            if (dataGridView1.Columns.Count == 5)
            {
                GetCategory1 get = new GetCategory1(cmbCategory);
                cmbCategory.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
                txtType.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[a].Cells[4].Value.ToString();
                cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCategory.DropDownHeight = 120;
                OpenText();
            }

        }

        void Sifirlama()
        {
            cmbCategory.Text = null;
            txtType.Text = null;
            txtQuantity.Text = null;
            txtPrice.Text = null;
            txtSearch.Text = null;
        }

        int id = 0;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                Update update = new Update(Convert.ToInt32(cmbCategory.SelectedValue), txtType.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDecimal(txtPrice.Text), id.ToString(), dataGridView1);

                Sifirlama();
            }

            CloseText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertProduct insert = new InsertProduct();
            GetCategory1 get = new GetCategory1(insert.cmbCategoryAdd);
            insert.Show();
            insert.cmbCategoryAdd.Text = string.Empty;
            insert.cmbCategoryAdd.DropDownHeight = 120;
            insert.cmbCategoryAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            insert.MaximizeBox = false;
            insert.MinimizeBox = false;
        }

        private void btnGetcategory_Click(object sender, EventArgs e)
        {
            GetAllCategory get = new GetAllCategory(dataGridView1);
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                DeleteCategory delete = new DeleteCategory(id, dataGridView1);
            }
        }

        private void btnCleanAdmin_Click(object sender, EventArgs e)
        {
            Sifirlama();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            CloseText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            decimal total = 0;
            GetSales get = new GetSales(dataGridView1, dateStart, dateEnd);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                value = Convert.ToDecimal(row.Cells[4].Value);
                total += value;
            }
            dataGridView1.Columns["Malın adı"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Tipi"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Sayı"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Qiymeti"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Toplam Yekun"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Tarix"].SortMode = DataGridViewColumnSortMode.NotSortable;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Malın adı"].ReadOnly = true;
                row.Cells["Tipi"].ReadOnly = true;
                row.Cells["Sayı"].ReadOnly = true;
                row.Cells["Qiymeti"].ReadOnly = true;
                row.Cells["Toplam Yekun"].ReadOnly = true;
                row.Cells["Tarix"].ReadOnly = true;
            }
            lblYekun.Text = total.ToString() + " " + "Azn";

        }
    }
}
