namespace BigBucksBank
{
    partial class dlgWithdraw
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
            this.textBoxWithdrawal = new System.Windows.Forms.TextBox();
            this.lblAcctNum = new System.Windows.Forms.Label();
            this.lblWithdrawal = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWithdrawal
            // 
            this.textBoxWithdrawal.Location = new System.Drawing.Point(176, 47);
            this.textBoxWithdrawal.Name = "textBoxWithdrawal";
            this.textBoxWithdrawal.Size = new System.Drawing.Size(136, 20);
            this.textBoxWithdrawal.TabIndex = 1;
            this.textBoxWithdrawal.Tag = "Withdrawal Amt";
            this.textBoxWithdrawal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWithdrawal_KeyDown);
            // 
            // lblAcctNum
            // 
            this.lblAcctNum.AutoSize = true;
            this.lblAcctNum.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAcctNum.Location = new System.Drawing.Point(7, 14);
            this.lblAcctNum.Name = "lblAcctNum";
            this.lblAcctNum.Size = new System.Drawing.Size(119, 20);
            this.lblAcctNum.TabIndex = 2;
            this.lblAcctNum.Text = "Account Number:";
            // 
            // lblWithdrawal
            // 
            this.lblWithdrawal.AutoSize = true;
            this.lblWithdrawal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWithdrawal.Location = new System.Drawing.Point(37, 48);
            this.lblWithdrawal.Name = "lblWithdrawal";
            this.lblWithdrawal.Size = new System.Drawing.Size(86, 20);
            this.lblWithdrawal.TabIndex = 3;
            this.lblWithdrawal.Text = "Withdrawal:";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(46, 82);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            this.btOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btOK_KeyDown);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(208, 82);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Finish";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cbAccounts
            // 
            this.cbAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(150, 16);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(162, 21);
            this.cbAccounts.TabIndex = 0;
            this.cbAccounts.Tag = "Account";
            this.cbAccounts.SelectedIndexChanged += new System.EventHandler(this.cbAccounts_SelectedIndexChanged);
            this.cbAccounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbAccounts_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlgWithdraw
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(333, 117);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lblWithdrawal);
            this.Controls.Add(this.lblAcctNum);
            this.Controls.Add(this.textBoxWithdrawal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dlgWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrawal";
            this.Load += new System.EventHandler(this.dlgWithdraw_FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWithdrawal;
        private System.Windows.Forms.Label lblAcctNum;
        private System.Windows.Forms.Label lblWithdrawal;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Button button1;
    }
}