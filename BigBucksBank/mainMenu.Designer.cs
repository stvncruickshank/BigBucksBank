namespace BigBucksBank
{
    partial class mainMenu
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
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbCheckBal = new System.Windows.Forms.RadioButton();
            this.groupBoxTrans = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(40, 19);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(76, 21);
            this.rbDeposit.TabIndex = 1;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            this.rbDeposit.CheckedChanged += new System.EventHandler(this.rbDeposit_CheckedChanged);
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(40, 42);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(86, 21);
            this.rbWithdraw.TabIndex = 2;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            this.rbWithdraw.CheckedChanged += new System.EventHandler(this.rbWithdraw_CheckedChanged);
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Location = new System.Drawing.Point(40, 65);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(79, 21);
            this.rbTransfer.TabIndex = 3;
            this.rbTransfer.Text = "Transfer";
            this.rbTransfer.UseVisualStyleBackColor = true;
            this.rbTransfer.CheckedChanged += new System.EventHandler(this.rbTransfer_CheckedChanged);
            // 
            // rbCheckBal
            // 
            this.rbCheckBal.AutoSize = true;
            this.rbCheckBal.Location = new System.Drawing.Point(40, 88);
            this.rbCheckBal.Name = "rbCheckBal";
            this.rbCheckBal.Size = new System.Drawing.Size(122, 21);
            this.rbCheckBal.TabIndex = 4;
            this.rbCheckBal.Text = "Check Balance";
            this.rbCheckBal.UseVisualStyleBackColor = true;
            this.rbCheckBal.CheckedChanged += new System.EventHandler(this.rbCheckBal_CheckedChanged);
            this.rbCheckBal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbCheckBal_MouseDown);
            // 
            // groupBoxTrans
            // 
            this.groupBoxTrans.Controls.Add(this.rbDeposit);
            this.groupBoxTrans.Controls.Add(this.rbCheckBal);
            this.groupBoxTrans.Controls.Add(this.rbWithdraw);
            this.groupBoxTrans.Controls.Add(this.rbTransfer);
            this.groupBoxTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTrans.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxTrans.Location = new System.Drawing.Point(45, 76);
            this.groupBoxTrans.Name = "groupBoxTrans";
            this.groupBoxTrans.Size = new System.Drawing.Size(188, 122);
            this.groupBoxTrans.TabIndex = 4;
            this.groupBoxTrans.TabStop = false;
            this.groupBoxTrans.Text = "Choose Transaction:";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(12, 224);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "BigBuck$Bank Inc.";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(289, 259);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBoxTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.groupBoxTrans.ResumeLayout(false);
            this.groupBoxTrans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbCheckBal;
        private System.Windows.Forms.GroupBox groupBoxTrans;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
    }
}