namespace Financial_Control
{
    partial class FormIncome
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
            this.textDescription = new System.Windows.Forms.TextBox();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.panelDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDescription
            // 
            this.textDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textDescription.BackColor = System.Drawing.Color.White;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(0, 4);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(155, 51);
            this.textDescription.TabIndex = 0;
            this.textDescription.Text = "Income";
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.Color.White;
            this.panelDescription.Controls.Add(this.textDescription);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDescription.Location = new System.Drawing.Point(0, 0);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(800, 58);
            this.panelDescription.TabIndex = 3;
            // 
            // FormIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDescription);
            this.Name = "FormIncome";
            this.Text = "FormIncome";
            this.Load += new System.EventHandler(this.FormIncome_Load);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Panel panelDescription;
    }
}