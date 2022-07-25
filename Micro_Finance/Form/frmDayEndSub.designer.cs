namespace Micro_Finance
{
    partial class frmDayEndSub
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayEndSub));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.t_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new Micro_Finance.Class.MyDatagridView(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.t_open = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_in = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_out = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_bal = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(824, 608);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "ចាកចេញ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(712, 608);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // t_desc
            // 
            this.t_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_desc.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_desc.Location = new System.Drawing.Point(430, 9);
            this.t_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_desc.Name = "t_desc";
            this.t_desc.Size = new System.Drawing.Size(492, 29);
            this.t_desc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "បរិយាយ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_date
            // 
            this.t_date.CustomFormat = "dd-MM-yyyy";
            this.t_date.Enabled = false;
            this.t_date.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_date.Location = new System.Drawing.Point(160, 9);
            this.t_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_date.Name = "t_date";
            this.t_date.Size = new System.Drawing.Size(188, 29);
            this.t_date.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 306;
            this.label3.Text = "កាលបរិច្ឆេទ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cid,
            this.uname,
            this.pwd,
            this.Column2,
            this.Column3});
            this.dgv.Location = new System.Drawing.Point(10, 48);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 35;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(912, 445);
            this.dgv.TabIndex = 307;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label5.Location = new System.Drawing.Point(13, 503);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 315;
            this.label5.Text = "ទឹកប្រាក់ដើមគ្រា";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_open
            // 
            this.t_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_open.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_open.Location = new System.Drawing.Point(140, 503);
            this.t_open.Margin = new System.Windows.Forms.Padding(4);
            this.t_open.Name = "t_open";
            this.t_open.ReadOnly = true;
            this.t_open.Size = new System.Drawing.Size(239, 29);
            this.t_open.TabIndex = 308;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label1.Location = new System.Drawing.Point(13, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 314;
            this.label1.Text = "សរុបទឹកប្រាក់ចូល";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_in
            // 
            this.t_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_in.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_in.Location = new System.Drawing.Point(140, 540);
            this.t_in.Margin = new System.Windows.Forms.Padding(4);
            this.t_in.Name = "t_in";
            this.t_in.ReadOnly = true;
            this.t_in.Size = new System.Drawing.Size(239, 29);
            this.t_in.TabIndex = 309;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label2.Location = new System.Drawing.Point(13, 577);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 313;
            this.label2.Text = "សរុបទឹកប្រាក់ចេញ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_out
            // 
            this.t_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_out.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_out.Location = new System.Drawing.Point(140, 577);
            this.t_out.Margin = new System.Windows.Forms.Padding(4);
            this.t_out.Name = "t_out";
            this.t_out.ReadOnly = true;
            this.t_out.Size = new System.Drawing.Size(239, 29);
            this.t_out.TabIndex = 310;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label8.Location = new System.Drawing.Point(13, 614);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 312;
            this.label8.Text = "ទឹកប្រាក់ចុងគ្រា";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_bal
            // 
            this.t_bal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_bal.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_bal.Location = new System.Drawing.Point(140, 614);
            this.t_bal.Margin = new System.Windows.Forms.Padding(4);
            this.t_bal.Name = "t_bal";
            this.t_bal.ReadOnly = true;
            this.t_bal.Size = new System.Drawing.Size(239, 29);
            this.t_bal.TabIndex = 311;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "ល.រ";
            this.Column1.MinimumWidth = 3;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cid
            // 
            this.cid.HeaderText = "លេខគណនី";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // uname
            // 
            this.uname.HeaderText = "ឈ្មោះគណនី";
            this.uname.Name = "uname";
            this.uname.ReadOnly = true;
            // 
            // pwd
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.pwd.DefaultCellStyle = dataGridViewCellStyle2;
            this.pwd.HeaderText = "បរិយាយ";
            this.pwd.Name = "pwd";
            this.pwd.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ទឹកប្រាក់ចូល";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ទឹកប្រាក់ចេញ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmDayEndSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_out);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t_bal);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_date);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.t_desc);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Khmer OS System", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDayEndSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day End";
            this.Load += new System.EventHandler(this.frmCOSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox t_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker t_date;
        public Class.MyDatagridView dgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_out;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_bal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}