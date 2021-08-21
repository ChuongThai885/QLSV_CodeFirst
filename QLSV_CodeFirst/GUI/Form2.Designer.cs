
namespace QLSV_CodeFirst.GUI
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxLSH = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textMSSV = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButFemale = new System.Windows.Forms.RadioButton();
            this.radioButMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.comboBoxLSH);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.textMSSV);
            this.groupBox1.Controls.Add(this.groupBoxGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 24);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(363, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(115, 191);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 33);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxLSH
            // 
            this.comboBoxLSH.FormattingEnabled = true;
            this.comboBoxLSH.Location = new System.Drawing.Point(87, 108);
            this.comboBoxLSH.Name = "comboBoxLSH";
            this.comboBoxLSH.Size = new System.Drawing.Size(141, 24);
            this.comboBoxLSH.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(87, 69);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(141, 22);
            this.textName.TabIndex = 5;
            // 
            // textMSSV
            // 
            this.textMSSV.Location = new System.Drawing.Point(87, 32);
            this.textMSSV.Name = "textMSSV";
            this.textMSSV.Size = new System.Drawing.Size(141, 22);
            this.textMSSV.TabIndex = 4;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButFemale);
            this.groupBoxGender.Controls.Add(this.radioButMale);
            this.groupBoxGender.Location = new System.Drawing.Point(263, 85);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(278, 90);
            this.groupBoxGender.TabIndex = 3;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButFemale
            // 
            this.radioButFemale.AutoSize = true;
            this.radioButFemale.Location = new System.Drawing.Point(140, 43);
            this.radioButFemale.Name = "radioButFemale";
            this.radioButFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButFemale.TabIndex = 1;
            this.radioButFemale.TabStop = true;
            this.radioButFemale.Text = "Female";
            this.radioButFemale.UseVisualStyleBackColor = true;
            // 
            // radioButMale
            // 
            this.radioButMale.AutoSize = true;
            this.radioButMale.Location = new System.Drawing.Point(39, 43);
            this.radioButMale.Name = "radioButMale";
            this.radioButMale.Size = new System.Drawing.Size(59, 21);
            this.radioButMale.TabIndex = 0;
            this.radioButMale.TabStop = true;
            this.radioButMale.Text = "Male";
            this.radioButMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp SH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 295);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButMale;
        private System.Windows.Forms.RadioButton radioButFemale;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textMSSV;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxLSH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}