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
            this._testConnectionButton = new System.Windows.Forms.Button();
            this.loadDBsBtn = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            this.setConnectionControl1 = new RServicesClient.Controls.SetConnectionControl();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(9, 205);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // _testConnectionButton
            // 
            this._testConnectionButton.Location = new System.Drawing.Point(90, 205);
            this._testConnectionButton.Name = "_testConnectionButton";
            this._testConnectionButton.Size = new System.Drawing.Size(107, 23);
            this._testConnectionButton.TabIndex = 2;
            this._testConnectionButton.Text = "Test connection";
            this._testConnectionButton.UseVisualStyleBackColor = true;
            this._testConnectionButton.Click += new System.EventHandler(this._testConnectionButton_Click);
            // 
            // loadDBsBtn
            // 
            this.loadDBsBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loadDBsBtn.Location = new System.Drawing.Point(298, 162);
            this.loadDBsBtn.Name = "loadDBsBtn";
            this.loadDBsBtn.Size = new System.Drawing.Size(39, 23);
            this.loadDBsBtn.TabIndex = 29;
            this.loadDBsBtn.Text = "Load";
            this.loadDBsBtn.UseVisualStyleBackColor = true;
            this.loadDBsBtn.Click += new System.EventHandler(this.loadDBsBtn_Click);
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Enabled = false;
            this._cancelBtn.Location = new System.Drawing.Point(249, 205);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(88, 23);
            this._cancelBtn.TabIndex = 30;
            this._cancelBtn.Text = "Cancel";
            this._cancelBtn.UseVisualStyleBackColor = true;
            this._cancelBtn.Click += new System.EventHandler(this._cancelBtn_Click);
            // 
            // setConnectionControl1
            // 
            this.setConnectionControl1.Location = new System.Drawing.Point(2, 1);
            this.setConnectionControl1.Name = "setConnectionControl1";
            this.setConnectionControl1.Size = new System.Drawing.Size(297, 203);
            this.setConnectionControl1.TabIndex = 0;
            this.setConnectionControl1.Text = "Connection settings";
            // 
            // SetConnectionForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 240);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this.loadDBsBtn);
            this.Controls.Add(this._testConnectionButton);
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
        private System.Windows.Forms.Button _testConnectionButton;
        private System.Windows.Forms.Button loadDBsBtn;
        private System.Windows.Forms.Button _cancelBtn;
    }
}