namespace MifareTopUp
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
            this.components = new System.ComponentModel.Container();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnBalance = new System.Windows.Forms.Button();
            this.txtboxBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCOM
            // 
            this.cbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(169, 25);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(78, 21);
            this.cbCOM.Sorted = true;
            this.cbCOM.TabIndex = 3;
            this.cbCOM.DropDown += new System.EventHandler(this.cbCOM_DropDown);
            this.cbCOM.SelectedIndexChanged += new System.EventHandler(this.cbCOM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin:";
            // 
            // txtboxPW
            // 
            this.txtboxPW.Location = new System.Drawing.Point(12, 26);
            this.txtboxPW.Name = "txtboxPW";
            this.txtboxPW.Size = new System.Drawing.Size(100, 20);
            this.txtboxPW.TabIndex = 6;
            this.txtboxPW.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 52);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.btnDeduct);
            this.gbAction.Controls.Add(this.btnTopUp);
            this.gbAction.Controls.Add(this.btnZero);
            this.gbAction.Controls.Add(this.rb50);
            this.gbAction.Controls.Add(this.rb30);
            this.gbAction.Controls.Add(this.rb10);
            this.gbAction.Enabled = false;
            this.gbAction.Location = new System.Drawing.Point(12, 92);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(235, 98);
            this.gbAction.TabIndex = 8;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action";
            // 
            // btnDeduct
            // 
            this.btnDeduct.Location = new System.Drawing.Point(128, 63);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(104, 23);
            this.btnDeduct.TabIndex = 1;
            this.btnDeduct.Text = "Deduct";
            this.btnDeduct.UseVisualStyleBackColor = true;
            this.btnDeduct.Click += new System.EventHandler(this.btnDeduct_Click);
            // 
            // btnTopUp
            // 
            this.btnTopUp.Location = new System.Drawing.Point(128, 40);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(104, 23);
            this.btnTopUp.TabIndex = 1;
            this.btnTopUp.Text = "Top Up";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(128, 17);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(104, 23);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "Zero Credit";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Location = new System.Drawing.Point(7, 66);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(54, 17);
            this.rb50.TabIndex = 0;
            this.rb50.TabStop = true;
            this.rb50.Text = "RM50";
            this.rb50.UseVisualStyleBackColor = true;
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Location = new System.Drawing.Point(7, 43);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(54, 17);
            this.rb30.TabIndex = 0;
            this.rb30.TabStop = true;
            this.rb30.Text = "RM30";
            this.rb30.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(7, 20);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(54, 17);
            this.rb10.TabIndex = 0;
            this.rb10.TabStop = true;
            this.rb10.Text = "RM10";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.ReadTimeout = 1000;
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(15, 214);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(113, 23);
            this.btnBalance.TabIndex = 9;
            this.btnBalance.Text = "Read Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // txtboxBalance
            // 
            this.txtboxBalance.BackColor = System.Drawing.Color.Black;
            this.txtboxBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBalance.ForeColor = System.Drawing.Color.Lime;
            this.txtboxBalance.Location = new System.Drawing.Point(183, 211);
            this.txtboxBalance.Name = "txtboxBalance";
            this.txtboxBalance.ReadOnly = true;
            this.txtboxBalance.Size = new System.Drawing.Size(62, 26);
            this.txtboxBalance.TabIndex = 10;
            this.txtboxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv1.Location = new System.Drawing.Point(12, 255);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(289, 150);
            this.dgv1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "DateTime";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "NUID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 59;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Balance";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 71;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 417);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxBalance);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCOM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxBalance;
        private System.Windows.Forms.Button btnBalance;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Button btnDeduct;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtboxPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

