namespace Financial_Control
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panelDescription = new System.Windows.Forms.Panel();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.panelDescription.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.Color.White;
            this.panelDescription.Controls.Add(this.textDescription);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDescription.Location = new System.Drawing.Point(0, 0);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(800, 58);
            this.panelDescription.TabIndex = 2;
            // 
            // textDescription
            // 
            this.textDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textDescription.BackColor = System.Drawing.Color.White;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(0, 4);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(125, 51);
            this.textDescription.TabIndex = 0;
            this.textDescription.Text = "About";
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.White;
            this.panelAbout.Controls.Add(this.textBoxAbout);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAbout.Location = new System.Drawing.Point(0, 58);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(800, 392);
            this.panelAbout.TabIndex = 3;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.AllowDrop = true;
            this.textBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbout.Location = new System.Drawing.Point(0, 0);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(800, 392);
            this.textBoxAbout.TabIndex = 0;
            this.textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelDescription);
            this.Name = "FormAbout";
            this.Text = "About";
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.TextBox textBoxAbout;
    }
}