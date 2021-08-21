
namespace QLSV_CodeFirst.GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLSH = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.butShow = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butSort = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp Sinh Hoạt";
            // 
            // comboBoxLSH
            // 
            this.comboBoxLSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLSH.FormattingEnabled = true;
            this.comboBoxLSH.Location = new System.Drawing.Point(141, 28);
            this.comboBoxLSH.Name = "comboBoxLSH";
            this.comboBoxLSH.Size = new System.Drawing.Size(153, 26);
            this.comboBoxLSH.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(379, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 24);
            this.textBox1.TabIndex = 2;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(566, 32);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 3;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(27, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(612, 262);
            this.dataGridView.TabIndex = 0;
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(27, 397);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 23);
            this.butShow.TabIndex = 5;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(125, 397);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(219, 397);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 7;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(420, 397);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(75, 23);
            this.butSort.TabIndex = 8;
            this.butSort.Text = "Sort";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(520, 396);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSort.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(320, 397);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 449);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.butSort);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxLSH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLSH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Button buttonDelete;
    }
}

