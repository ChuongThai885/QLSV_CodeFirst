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
    public partial class Form2 : Form
    {
        public string mssv { get; set; }
        public delegate void MyDel();
        public MyDel ReloadData { get; set; }
        public Form2(bool enableMSSV,string ms)
        {
            InitializeComponent();
            SetCBB_LSH();
            mssv = ms;
            textMSSV.Enabled = enableMSSV;
            if (!enableMSSV) SetGUI();
        }
        public int getValueCBB()
        {
            int a = 0;
            foreach (LSH i in comboBoxLSH.Items)
            {
                if (i.ID == ((LSH)(comboBoxLSH.SelectedItem)).ID) a = i.ID;
            }
            return a;
        }
        public void SetCBB_LSH()
        {
            List<LSH> list = BLL_CSDL.Instance.GetAllLSH_BLL();
            foreach (LSH i in list)
            {
                comboBoxLSH.Items.Add(i);
            }
            comboBoxLSH.SelectedIndex = 0;
            comboBoxLSH.DisplayMember = "NameLop";
        }
        public void SetGUI()
        {
            SV a = BLL_CSDL.Instance.GetSVbyMSSV(mssv);
            if(a != null)
            {
                textMSSV.Text = a.MSSV;
                textName.Text = a.NameSV;
                foreach (LSH item in comboBoxLSH.Items)
                {
                    if (item.ID == a.ID_Lop) comboBoxLSH.SelectedItem = item;
                }
                if (!a.Gender) radioButFemale.Checked = true;
                dateTimePicker1.Value = a.NS;
            }
        }
        private void Create_MessageBox(string message)
        {
            string caption = "Error Detected in Input";
            MessageBoxButtons butt = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, butt);
            if (result == System.Windows.Forms.DialogResult.No) Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textMSSV.Text == "" || textName.Text == "" || comboBoxLSH.SelectedItem == null)
            {
                string message = "You did not enter all the required information, do you want to continue ?";
                Create_MessageBox(message);
            }
            else
            {
                SV sv = new SV();
                sv.MSSV = textMSSV.Text;
                sv.NameSV = textName.Text;
                sv.Gender = radioButMale.Checked;
                sv.ID_Lop = getValueCBB();
                sv.NS = dateTimePicker1.Value;
                if (BLL_CSDL.Instance.Execute_AddorEDit_BLL(mssv, sv) == false)
                {
                    string message = "This MSSV is already in use , do you want to continue ?";
                    Create_MessageBox(message);
                }
                else
                {
                    ReloadData();
                    Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
