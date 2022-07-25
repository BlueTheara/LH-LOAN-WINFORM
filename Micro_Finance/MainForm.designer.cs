namespace Micro_Finance
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.b_close = new System.Windows.Forms.ToolStripMenuItem();
            this.humanResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_cus = new System.Windows.Forms.ToolStripMenuItem();
            this.b_co = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_loan = new System.Windows.Forms.ToolStripMenuItem();
            this.b_pay = new System.Windows.Forms.ToolStripMenuItem();
            this.b_daily = new System.Windows.Forms.ToolStripMenuItem();
            this.b_capital = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.b_income = new System.Windows.Forms.ToolStripMenuItem();
            this.b_new_cus_mas = new System.Windows.Forms.ToolStripMenuItem();
            this.b_new_cus_det = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_coa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.b_exp = new System.Windows.Forms.ToolStripMenuItem();
            this.b_other_income = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.b_deposit = new System.Windows.Forms.ToolStripMenuItem();
            this.b_withdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.b_advance = new System.Windows.Forms.ToolStripMenuItem();
            this.b_advance_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.b_day_end = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.humanResourceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.financeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.b_close});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // b_close
            // 
            this.b_close.Image = global::Micro_Finance.Properties.Resources.deletered;
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(100, 22);
            this.b_close.Text = "Exit";
            // 
            // humanResourceToolStripMenuItem
            // 
            this.humanResourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_cus,
            this.b_co});
            this.humanResourceToolStripMenuItem.Name = "humanResourceToolStripMenuItem";
            this.humanResourceToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.humanResourceToolStripMenuItem.Text = "&Human Resource";
            // 
            // b_cus
            // 
            this.b_cus.Image = global::Micro_Finance.Properties.Resources.group_fav_256;
            this.b_cus.Name = "b_cus";
            this.b_cus.Size = new System.Drawing.Size(232, 22);
            this.b_cus.Text = "&Customer Management";
            // 
            // b_co
            // 
            this.b_co.Image = global::Micro_Finance.Properties.Resources.Employee_Management;
            this.b_co.Name = "b_co";
            this.b_co.Size = new System.Drawing.Size(232, 22);
            this.b_co.Text = "&CO Management";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_loan,
            this.b_pay,
            this.b_daily,
            this.b_capital,
            this.toolStripSeparator2,
            this.b_income,
            this.b_new_cus_mas,
            this.b_new_cus_det});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.transactionToolStripMenuItem.Text = "&Transaction";
            // 
            // b_loan
            // 
            this.b_loan.Name = "b_loan";
            this.b_loan.Size = new System.Drawing.Size(282, 22);
            this.b_loan.Text = "&Borrow Processing";
            // 
            // b_pay
            // 
            this.b_pay.Name = "b_pay";
            this.b_pay.Size = new System.Drawing.Size(282, 22);
            this.b_pay.Text = "Repayment";
            // 
            // b_daily
            // 
            this.b_daily.Name = "b_daily";
            this.b_daily.Size = new System.Drawing.Size(282, 22);
            this.b_daily.Text = "Daily Payment";
            // 
            // b_capital
            // 
            this.b_capital.Name = "b_capital";
            this.b_capital.Size = new System.Drawing.Size(282, 22);
            this.b_capital.Text = "Capital Info";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // b_income
            // 
            this.b_income.Name = "b_income";
            this.b_income.Size = new System.Drawing.Size(282, 22);
            this.b_income.Text = "CO Income";
            // 
            // b_new_cus_mas
            // 
            this.b_new_cus_mas.Name = "b_new_cus_mas";
            this.b_new_cus_mas.Size = new System.Drawing.Size(282, 22);
            this.b_new_cus_mas.Text = "CO\'s New Customer Summary";
            // 
            // b_new_cus_det
            // 
            this.b_new_cus_det.Name = "b_new_cus_det";
            this.b_new_cus_det.Size = new System.Drawing.Size(282, 22);
            this.b_new_cus_det.Text = "CO\'s New Customer Details";
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_coa,
            this.toolStripSeparator3,
            this.b_exp,
            this.b_other_income,
            this.toolStripSeparator4,
            this.b_deposit,
            this.b_withdraw,
            this.toolStripSeparator5,
            this.b_advance,
            this.b_advance_clear,
            this.toolStripSeparator6,
            this.b_day_end});
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // b_coa
            // 
            this.b_coa.Name = "b_coa";
            this.b_coa.Size = new System.Drawing.Size(237, 22);
            this.b_coa.Text = "Chart of Account";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(234, 6);
            // 
            // b_exp
            // 
            this.b_exp.Name = "b_exp";
            this.b_exp.Size = new System.Drawing.Size(237, 22);
            this.b_exp.Text = "Expenses";
            // 
            // b_other_income
            // 
            this.b_other_income.Name = "b_other_income";
            this.b_other_income.Size = new System.Drawing.Size(237, 22);
            this.b_other_income.Text = "Other Incomes";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(234, 6);
            // 
            // b_deposit
            // 
            this.b_deposit.Name = "b_deposit";
            this.b_deposit.Size = new System.Drawing.Size(237, 22);
            this.b_deposit.Text = "Capital Deposit";
            // 
            // b_withdraw
            // 
            this.b_withdraw.Name = "b_withdraw";
            this.b_withdraw.Size = new System.Drawing.Size(237, 22);
            this.b_withdraw.Text = "Capital Withdrawal";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(234, 6);
            // 
            // b_advance
            // 
            this.b_advance.Name = "b_advance";
            this.b_advance.Size = new System.Drawing.Size(237, 22);
            this.b_advance.Text = "Staff Advance";
            // 
            // b_advance_clear
            // 
            this.b_advance_clear.Name = "b_advance_clear";
            this.b_advance_clear.Size = new System.Drawing.Size(237, 22);
            this.b_advance_clear.Text = "Staff Advance Clearance";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(234, 6);
            // 
            // b_day_end
            // 
            this.b_day_end.Name = "b_day_end";
            this.b_day_end.Size = new System.Drawing.Size(237, 22);
            this.b_day_end.Text = "Day End";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 515);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem b_close;
        private System.Windows.Forms.ToolStripMenuItem humanResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b_co;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b_loan;
        private System.Windows.Forms.ToolStripMenuItem b_cus;
        private System.Windows.Forms.ToolStripMenuItem b_capital;
        private System.Windows.Forms.ToolStripMenuItem b_income;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem b_new_cus_mas;
        private System.Windows.Forms.ToolStripMenuItem b_daily;
        private System.Windows.Forms.ToolStripMenuItem b_new_cus_det;
        private System.Windows.Forms.ToolStripMenuItem b_pay;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b_coa;
        private System.Windows.Forms.ToolStripMenuItem b_exp;
        private System.Windows.Forms.ToolStripMenuItem b_other_income;
        private System.Windows.Forms.ToolStripMenuItem b_deposit;
        private System.Windows.Forms.ToolStripMenuItem b_withdraw;
        private System.Windows.Forms.ToolStripMenuItem b_advance;
        private System.Windows.Forms.ToolStripMenuItem b_advance_clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem b_day_end;

    }
}