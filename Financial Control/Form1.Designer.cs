namespace Financial_Control
{
    partial class formFinantialControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFinantialControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOverall = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnWalletEvolution = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnOverall);
            this.panel1.Controls.Add(this.btnExpenses);
            this.panel1.Controls.Add(this.btnIncome);
            this.panel1.Controls.Add(this.btnWalletEvolution);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 537);
            this.panel1.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.Snow;
            this.btnAbout.Location = new System.Drawing.Point(0, 345);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(161, 49);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Snow;
            this.btnHelp.Location = new System.Drawing.Point(0, 296);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(161, 49);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnOverall
            // 
            this.btnOverall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverall.FlatAppearance.BorderSize = 0;
            this.btnOverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverall.ForeColor = System.Drawing.Color.Snow;
            this.btnOverall.Location = new System.Drawing.Point(0, 247);
            this.btnOverall.Name = "btnOverall";
            this.btnOverall.Size = new System.Drawing.Size(161, 49);
            this.btnOverall.TabIndex = 4;
            this.btnOverall.Text = "Overall";
            this.btnOverall.UseVisualStyleBackColor = true;
            // 
            // btnExpenses
            // 
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.ForeColor = System.Drawing.Color.Snow;
            this.btnExpenses.Location = new System.Drawing.Point(0, 198);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(161, 49);
            this.btnExpenses.TabIndex = 3;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.UseVisualStyleBackColor = true;
            // 
            // btnIncome
            // 
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.ForeColor = System.Drawing.Color.Snow;
            this.btnIncome.Location = new System.Drawing.Point(0, 149);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(161, 49);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            // 
            // btnWalletEvolution
            // 
            this.btnWalletEvolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWalletEvolution.FlatAppearance.BorderSize = 0;
            this.btnWalletEvolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWalletEvolution.ForeColor = System.Drawing.Color.Snow;
            this.btnWalletEvolution.Location = new System.Drawing.Point(0, 100);
            this.btnWalletEvolution.Name = "btnWalletEvolution";
            this.btnWalletEvolution.Size = new System.Drawing.Size(161, 49);
            this.btnWalletEvolution.TabIndex = 1;
            this.btnWalletEvolution.Text = "Wallet Evolution";
            this.btnWalletEvolution.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 100);
            this.panel2.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(161, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(847, 537);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(161, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // formFinantialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "formFinantialControl";
            this.Text = "Finantial Control";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnOverall;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnWalletEvolution;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

