namespace Micro_Finance
{
    partial class frmDayEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayEnd));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_bal = new System.Windows.Forms.TextBox();
            this.c_month = new System.Windows.Forms.ComboBox();
            this.c_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_out = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_in = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_open = new System.Windows.Forms.TextBox();
            this.dgv = new Micro_Finance.Class.MyDatagridView(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_print_daily = new System.Windows.Forms.Button();
            this.b_print_monthly_sum = new System.Windows.Forms.Button();
            this.b_print_monthly_det = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1325, 29);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Micro_Finance.Properties.Resources.download;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(75, 26);
            this.tsbAdd.Text = "បង្កើតថ្មី";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(0, 26);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "ខែ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label8.Location = new System.Drawing.Point(946, 395);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 44;
            this.label8.Text = "ទឹកប្រាក់ចុងគ្រា";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_bal
            // 
            this.t_bal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_bal.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_bal.Location = new System.Drawing.Point(1073, 395);
            this.t_bal.Margin = new System.Windows.Forms.Padding(4);
            this.t_bal.Name = "t_bal";
            this.t_bal.ReadOnly = true;
            this.t_bal.Size = new System.Drawing.Size(239, 29);
            this.t_bal.TabIndex = 6;
            // 
            // c_month
            // 
            this.c_month.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_month.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_month.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_month.FormattingEnabled = true;
            this.c_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.c_month.Location = new System.Drawing.Point(49, 32);
            this.c_month.Name = "c_month";
            this.c_month.Size = new System.Drawing.Size(84, 30);
            this.c_month.TabIndex = 0;
            // 
            // c_year
            // 
            this.c_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_year.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_year.FormattingEnabled = true;
            this.c_year.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.c_year.Location = new System.Drawing.Point(176, 32);
            this.c_year.Name = "c_year";
            this.c_year.Size = new System.Drawing.Size(84, 30);
            this.c_year.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "ឆ្នាំ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label3.Location = new System.Drawing.Point(946, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "សរុបទឹកប្រាក់ចេញ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_out
            // 
            this.t_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_out.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_out.Location = new System.Drawing.Point(1073, 358);
            this.t_out.Margin = new System.Windows.Forms.Padding(4);
            this.t_out.Name = "t_out";
            this.t_out.ReadOnly = true;
            this.t_out.Size = new System.Drawing.Size(239, 29);
            this.t_out.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label4.Location = new System.Drawing.Point(946, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 68;
            this.label4.Text = "សរុបទឹកប្រាក់ចូល";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_in
            // 
            this.t_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_in.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_in.Location = new System.Drawing.Point(1073, 321);
            this.t_in.Margin = new System.Windows.Forms.Padding(4);
            this.t_in.Name = "t_in";
            this.t_in.ReadOnly = true;
            this.t_in.Size = new System.Drawing.Size(239, 29);
            this.t_in.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.label5.Location = new System.Drawing.Point(946, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 70;
            this.label5.Text = "ទឹកប្រាក់ដើមគ្រា";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_open
            // 
            this.t_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_open.Font = new System.Drawing.Font("Khmer OS System", 9F);
            this.t_open.Location = new System.Drawing.Point(1073, 284);
            this.t_open.Margin = new System.Windows.Forms.Padding(4);
            this.t_open.Name = "t_open";
            this.t_open.ReadOnly = true;
            this.t_open.Size = new System.Drawing.Size(239, 29);
            this.t_open.TabIndex = 3;
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
            this.usertype,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 68);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 35;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1301, 208);
            this.dgv.TabIndex = 2;
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
            this.cid.HeaderText = "លេខសំគាល់";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // uname
            // 
            this.uname.HeaderText = "កាលបរិច្ឆេទ";
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
            // usertype
            // 
            this.usertype.HeaderText = "ទឹកប្រាក់ដើមគ្រា";
            this.usertype.Name = "usertype";
            this.usertype.ReadOnly = true;
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
            // Column4
            // 
            this.Column4.HeaderText = "ទឹកប្រាក់ចុងគ្រា";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // b_print_daily
            // 
            this.b_print_daily.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_print_daily.Location = new System.Drawing.Point(266, 32);
            this.b_print_daily.Name = "b_print_daily";
            this.b_print_daily.Size = new System.Drawing.Size(197, 30);
            this.b_print_daily.TabIndex = 71;
            this.b_print_daily.Text = "Print Daily Cash Book";
            this.b_print_daily.UseVisualStyleBackColor = true;
            // 
            // b_print_monthly_sum
            // 
            this.b_print_monthly_sum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_print_monthly_sum.Location = new System.Drawing.Point(672, 32);
            this.b_print_monthly_sum.Name = "b_print_monthly_sum";
            this.b_print_monthly_sum.Size = new System.Drawing.Size(197, 30);
            this.b_print_monthly_sum.TabIndex = 72;
            this.b_print_monthly_sum.Text = "Print Monthly By Day";
            this.b_print_monthly_sum.UseVisualStyleBackColor = true;
            // 
            // b_print_monthly_det
            // 
            this.b_print_monthly_det.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_print_monthly_det.Location = new System.Drawing.Point(469, 32);
            this.b_print_monthly_det.Name = "b_print_monthly_det";
            this.b_print_monthly_det.Size = new System.Drawing.Size(197, 30);
            this.b_print_monthly_det.TabIndex = 73;
            this.b_print_monthly_det.Text = "Print Monthly By Account";
            this.b_print_monthly_det.UseVisualStyleBackColor = true;
            // 
            // frmDayEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 437);
            this.Controls.Add(this.b_print_monthly_det);
            this.Controls.Add(this.b_print_monthly_sum);
            this.Controls.Add(this.b_print_daily);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_open);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_out);
            this.Controls.Add(this.c_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_month);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t_bal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Khmer OS System", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDayEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day End";
            this.Load += new System.EventHandler(this.frmCus_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Class.MyDatagridView dgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_bal;
        public System.Windows.Forms.ComboBox c_month;
        public System.Windows.Forms.ComboBox c_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_out;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_open;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button b_print_daily;
        private System.Windows.Forms.Button b_print_monthly_sum;
        private System.Windows.Forms.Button b_print_monthly_det;
    }
}