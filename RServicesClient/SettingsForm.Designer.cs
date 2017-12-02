namespace RServicesClient
{
    partial class SettingsForm
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
            this._saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._timeOutTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._timeOutTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _saveBtn
            // 
            this._saveBtn.Location = new System.Drawing.Point(68, 111);
            this._saveBtn.Name = "_saveBtn";
            this._saveBtn.Size = new System.Drawing.Size(75, 23);
            this._saveBtn.TabIndex = 0;
            this._saveBtn.Text = "Save";
            this._saveBtn.UseVisualStyleBackColor = true;
            this._saveBtn.Click += new System.EventHandler(this._saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _timeOutTextBox
            // 
            this._timeOutTextBox.Location = new System.Drawing.Point(83, 7);
            this._timeOutTextBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._timeOutTextBox.Name = "_timeOutTextBox";
            this._timeOutTextBox.Size = new System.Drawing.Size(60, 20);
            this._timeOutTextBox.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this._saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 146);
            this.Controls.Add(this._timeOutTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._saveBtn);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this._timeOutTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _timeOutTextBox;
    }
}