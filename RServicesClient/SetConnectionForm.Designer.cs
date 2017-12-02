namespace RServicesClient
{
    partial class SetConnectionForm
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
            if (disposing && ( components != null ))
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
            this.applyButton = new System.Windows.Forms.Button();
            this.setConnectionControl1 = new RServicesClient.Controls.SetConnectionControl();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(176, 210);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // setConnectionControl1
            // 
            this.setConnectionControl1.Location = new System.Drawing.Point(2, 1);
            this.setConnectionControl1.Name = "setConnectionControl1";
            this.setConnectionControl1.Size = new System.Drawing.Size(269, 203);
            this.setConnectionControl1.TabIndex = 0;
            this.setConnectionControl1.Text = "Connection settings";
            // 
            // SetConnectionForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 240);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.setConnectionControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetConnectionForm";
            this.Text = "Connection settings";
            this.ResumeLayout(false);

        }

        #endregion

        private RServicesClient.Controls.SetConnectionControl setConnectionControl1;
        private System.Windows.Forms.Button applyButton;
    }
}