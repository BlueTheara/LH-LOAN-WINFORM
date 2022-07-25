namespace Micro_Finance
{
    partial class frmWithdrawSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdrawSub));
            this.t_amt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.t_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_title = new System.Windows.Forms.Label();
            this.t_date = new System.Windows.Forms.DateTimePicker();
            this.c_coa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_amt
            // 
            this.t_amt.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_amt.Location = new System.Drawing.Point(165, 230);
            this.t_amt.Name = "t_amt";
            this.t_amt.Size = new System.Drawing.Size(298, 29);
            this.t_amt.TabIndex = 4;
            this.t_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_amt_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "ទឹកប្រាក់";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "ចាកចេញ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(253, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = "លេខសំគាល់";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_desc
            // 
            this.t_desc.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_desc.Location = new System.Drawing.Point(165, 195);
            this.t_desc.Name = "t_desc";
            this.t_desc.Size = new System.Drawing.Size(298, 29);
            this.t_desc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "បរិយាយ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_id
            // 
            this.t_id.Enabled = false;
            this.t_id.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id.Location = new System.Drawing.Point(165, 89);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(298, 29);
            this.t_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "គណនី";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l_title
            // 
            this.l_title.BackColor = System.Drawing.Color.LightSeaGreen;
            this.l_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_title.Font = new System.Drawing.Font("Khmer OS System", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_title.ForeColor = System.Drawing.Color.Black;
            this.l_title.Location = new System.Drawing.Point(0, 0);
            this.l_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(484, 83);
            this.l_title.TabIndex = 303;
            this.l_title.Text = "ពត៍មាន ដកប្រាក់";
            this.l_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_date
            // 
            this.t_date.CustomFormat = "dd-MM-yyyy";
            this.t_date.Enabled = false;
            this.t_date.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_date.Location = new System.Drawing.Point(165, 124);
            this.t_date.Name = "t_date";
            this.t_date.Size = new System.Drawing.Size(298, 29);
            this.t_date.TabIndex = 1;
            // 
            // c_coa
            // 
            this.c_coa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.c_coa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.c_coa.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_coa.FormattingEnabled = true;
            this.c_coa.Items.AddRange(new object[] {
            "ប្រុស",
            "ស្រី"});
            this.c_coa.Location = new System.Drawing.Point(165, 159);
            this.c_coa.Name = "c_coa";
            this.c_coa.Size = new System.Drawing.Size(298, 30);
            this.c_coa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Khmer OS System", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 306;
            this.label3.Text = "កាលបរិច្ឆេទ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmWithdrawSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_date);
            this.Controls.Add(this.c_coa);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.t_amt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWithdrawSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capital Withdraw";
            this.Load += new System.EventHandler(this.frmCOSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox t_amt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox t_desc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_title;
        public System.Windows.Forms.ComboBox c_coa;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker t_date;
    }
}