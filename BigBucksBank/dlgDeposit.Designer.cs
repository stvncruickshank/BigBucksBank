namespace BigBucksBank
{
    partial class dlgDeposit
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
            this.btOK2 = new System.Windows.Forms.Button();
            this.btCancel2 = new System.Windows.Forms.Button();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.lblAcctNum2 = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOK2
            // 
            this.btOK2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK2.Location = new System.Drawing.Point(30, 96);
            this.btOK2.Name = "btOK2";
            this.btOK2.Size = new System.Drawing.Size(75, 23);
            this.btOK2.TabIndex = 2;
            this.btOK2.Text = "OK";
            this.btOK2.UseVisualStyleBackColor = true;
            this.btOK2.Click += new System.EventHandler(this.btOK2_Click);
            // 
            // btCancel2
            // 
            this.btCancel2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel2.Location = new System.Drawing.Point(111, 96);
            this.btCancel2.Name = "btCancel2";
            this.btCancel2.Size = new System.Drawing.Size(75, 23);
            this.btCancel2.TabIndex = 1;
            this.btCancel2.Text = "Clear";
            this.btCancel2.UseVisualStyleBackColor = true;
            this.btCancel2.Click += new System.EventHandler(this.btCancel2_Click);
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(190, 55);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeposit.TabIndex = 1;
            this.textBoxDeposit.Tag = "Deposit";
            this.textBoxDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDeposit_KeyDown);
            // 
            // lblAcctNum2
            // 
            this.lblAcctNum2.AutoSize = true;
            this.lblAcctNum2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAcctNum2.Location = new System.Drawing.Point(3, 28);
            this.lblAcctNum2.Name = "lblAcctNum2";
            this.lblAcctNum2.Size = new System.Drawing.Size(119, 20);
            this.lblAcctNum2.TabIndex = 4;
            this.lblAcctNum2.Text = "Account Number:";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDeposit.Location = new System.Drawing.Point(57, 56);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(63, 20);
            this.lblDeposit.TabIndex = 5;
            this.lblDeposit.Text = "Deposit:";
            // 
            // cbAccounts
            // 
            this.cbAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(123, 28);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(167, 21);
            this.cbAccounts.TabIndex = 0;
            this.cbAccounts.SelectedIndexChanged += new System.EventHandler(this.cbAccounts_SelectedIndexChanged);
            this.cbAccounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbAccounts_KeyDown);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(192, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlgDeposit
            // 
            this.AcceptButton = this.btOK2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelButton = this.btCancel2;
            this.ClientSize = new System.Drawing.Size(298, 133);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblAcctNum2);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.btCancel2);
            this.Controls.Add(this.btOK2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dlgDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.dlgForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOK2;
        private System.Windows.Forms.Button btCancel2;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Label lblAcctNum2;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Button button1;
    }
}