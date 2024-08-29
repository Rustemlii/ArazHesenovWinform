using System.Data;
using System.Data.SqlClient;
using ArazHesenovWinform.Crud.GetAllForm;
using ArazHesenovWinform.Crud.Insert;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        decimal sum = 0;
        public Form1()
        {
            InitializeComponent();
          

        }

        void Sifirlama()
        {
            cmbName.Text = null;
            cmbType.Text = null;
            txtPrice.Clear();
            numericUpDown1.Value = 0;
        }
        //Yaddawda saxlamaqdan oteri qlobalda yazilir

        DataTable dt = new DataTable();
        decimal total;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text != string.Empty)
            {
                con.Open();
                int quantity = Convert.ToInt32(numericUpDown1.Value);
                decimal price = Convert.ToDecimal(txtPrice.Text);
                string selectedType = cmbType.Text;//Texti DatagridView-ayazdirmaq ucun bu metoddan istifade eledim cunki deyer bura integer
                                                   //kimi gelir classdan selected value etdiyim ucun
                string script = @$"select
                p.Id,
                c.Ad as [Malın adı],
                Tip=@tip,
                Say=@say,
                Qiymet,
                Qiymet * @say as [Yekun Qiymet]
                from
                Products p inner join Category c
                on p.categoryId=c.Id
                where
                p.Tip=@tip";

                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.Add("@tip", SqlDbType.NVarChar).Value = selectedType;
                cmd.Parameters.Add("@say", SqlDbType.Int).Value = quantity;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false; // Sütunu gizle
                dataGridView1.Columns["Malın adı"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns["Tip"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns["Say"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns["Qiymet"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns["Yekun Qiymet"].SortMode = DataGridViewColumnSortMode.NotSortable;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["Malın adı"].ReadOnly = true;
                    row.Cells["Tip"].ReadOnly = true;
                    row.Cells["Say"].ReadOnly = true;
                    row.Cells["Yekun Qiymet"].ReadOnly = true;
                }

                con.Close();
                Sifirlama();
                total = total + price;
                lblPrice.Text = total.ToString() + " Azn";





            }
            else
            {
                MessageBox.Show("Xana Bosh ola bilmez", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategory1 get = new GetCategory1(cmbName);
            txtPrice.ReadOnly = true;
            cmbName.Text = null;
            cmbName.DropDownHeight = 120;
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPrice.Text = null;
            txtPrice.ReadOnly = true;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;




        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbType.Text = string.Empty;
            txtPrice.Text = string.Empty;
            numericUpDown1.Value = 0;


            GetAllProductForForm get = new GetAllProductForForm(cmbName, cmbType);

            cmbType.Text = null;
            cmbType.DropDownHeight = 120;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;



        }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            if(numericUpDown1.Value > 0)
            {
                total = sum * numericUpDown1.Value;
                txtPrice.Text = total.ToString();
            }

        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            admin.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            lblPrice.Text = null;
            Sifirlama();
        }
        int quantity = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Columns.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        con.Open();
                        quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
                        string script = $"Update Products Set Say=Say-{quantity} where Id={row.Cells[0].Value}";
                        SqlCommand cmd = new SqlCommand(script, con);
                        cmd.ExecuteNonQuery();
                        AddSales add = new AddSales(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), Convert.ToInt32(row.Cells[3].Value), Convert.ToDecimal(row.Cells[4].Value), Convert.ToDecimal(row.Cells[5].Value));
                        con.Close();
                    }

                }
                MessageBox.Show("Satıldı", "Bildiris");
                total = 0;
                lblPrice.Text = null;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dt.Clear();
            }
           

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            if (cmbType.SelectedItem != null)
            {
                int TipID = Convert.ToInt32(cmbType.SelectedValue);
                int categoryId = Convert.ToInt32(cmbName.SelectedValue);
             

                try
                {
                    con.Open();
                    string script = $"SELECT Qiymet FROM Products WHERE Id=@id and CategoryId=@categoryId ";
                    SqlCommand cmd = new SqlCommand(script, con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = TipID;
                    cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    con.Close();
                    txtPrice.Text = dt.Rows[0]["Qiymet"].ToString();
                    numericUpDown1.Value = 1;
                    sum = Convert.ToDecimal(txtPrice.Text);//bunu burda yazmiyanda bawi qacir sehv isliyir

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                txtPrice.Text = string.Empty;
            }
        }
    }
}
