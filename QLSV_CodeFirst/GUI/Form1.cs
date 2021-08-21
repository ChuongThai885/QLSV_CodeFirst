using QLSV_CodeFirst.BLL;
using QLSV_CodeFirst.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_CodeFirst.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB_LSH();
            setCBB_Sort();
        }
        public void SetCBB_LSH()
        {
            List<LSH> list = BLL_CSDL.Instance.GetAllLSH_BLL();
            comboBoxLSH.Items.Add(new LSH
            {
                ID = 0,
                NameLop = "All"
            });
            foreach (LSH i in list)
            {
                comboBoxLSH.Items.Add(i);
            }
            comboBoxLSH.SelectedIndex = 0;
            comboBoxLSH.DisplayMember = "NameLop";
        }
        public void setCBB_Sort()
        {
            var names = typeof(SV_GUI).GetProperties().Select(p => p.Name);
            foreach(var i in names)
            {
                comboBoxSort.Items.Add(i);
            }
            comboBoxSort.SelectedIndex = 0;
        }
        public void RefreshDataSource()
        {
            textBox1.Text = "";
            int ID_Lop = ((LSH)comboBoxLSH.SelectedItem).ID;
            dataGridView.DataSource = BLL_CSDL.Instance.GetListSV_GUI_BLL(ID_Lop, "");
        }
        private void butShow_Click(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(true,"");
            f.ReloadData = new Form2.MyDel(RefreshDataSource);
            f.Show();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView.DataSource = BLL_CSDL.Instance.GetListSV_BLL(((LSH)comboBoxLSH.SelectedItem).ID, textBox1.Text);
            }
            else MessageBox.Show("Nhap ten SV vao !");
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rs = dataGridView.SelectedRows;
            if(rs.Count > 0)
            {
                foreach(DataGridViewRow i in rs)
                {
                    Form2 f2 = new Form2(false, BLL_CSDL.Instance.GetMSSV(i));
                    f2.ReloadData = new Form2.MyDel(RefreshDataSource);
                    f2.Show();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                foreach (DataGridViewRow i in rows)
                {
                    BLL_CSDL.Instance.DeleteRow_BLL(i);
                }
                RefreshDataSource();
            }
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = BLL_CSDL.Instance.Sort(comboBoxSort.SelectedIndex, ((LSH)comboBoxLSH.SelectedItem).ID, textBox1.Text);
        }
    }
}
