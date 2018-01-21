namespace RServicesClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._scriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this._inputScriptTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._execTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._serverStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._dbNameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSQLScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openRScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openRServicesFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rServicesFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsDBStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.execute_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._currentScriptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._scriptTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._inputScriptTextBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _scriptTextBox
            // 
            this._scriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._scriptTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this._scriptTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this._scriptTextBox.BackBrush = null;
            this._scriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._scriptTextBox.CharHeight = 14;
            this._scriptTextBox.CharWidth = 8;
            this._scriptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._scriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._scriptTextBox.IsReplaceMode = false;
            this._scriptTextBox.Location = new System.Drawing.Point(3, 16);
            this._scriptTextBox.Name = "_scriptTextBox";
            this._scriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this._scriptTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._scriptTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_scriptTextBox.ServiceColors")));
            this._scriptTextBox.Size = new System.Drawing.Size(834, 170);
            this._scriptTextBox.TabIndex = 0;
            this._scriptTextBox.Zoom = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 62);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this._scriptTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._inputScriptTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(842, 382);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Script:";
            // 
            // _inputScriptTextBox
            // 
            this._inputScriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._inputScriptTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this._inputScriptTextBox.AutoIndentCharsPatterns = "";
            this._inputScriptTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this._inputScriptTextBox.BackBrush = null;
            this._inputScriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._inputScriptTextBox.CharHeight = 14;
            this._inputScriptTextBox.CharWidth = 8;
            this._inputScriptTextBox.CommentPrefix = "--";
            this._inputScriptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._inputScriptTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._inputScriptTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this._inputScriptTextBox.IsReplaceMode = false;
            this._inputScriptTextBox.Language = FastColoredTextBoxNS.Language.SQL;
            this._inputScriptTextBox.LeftBracket = '(';
            this._inputScriptTextBox.Location = new System.Drawing.Point(3, 16);
            this._inputScriptTextBox.Name = "_inputScriptTextBox";
            this._inputScriptTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this._inputScriptTextBox.RightBracket = ')';
            this._inputScriptTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._inputScriptTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_inputScriptTextBox.ServiceColors")));
            this._inputScriptTextBox.Size = new System.Drawing.Size(834, 166);
            this._inputScriptTextBox.TabIndex = 1;
            this._inputScriptTextBox.Zoom = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SQL:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._execTimeLabel,
            this._serverStatusLabel1,
            this._dbNameStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _execTimeLabel
            // 
            this._execTimeLabel.Name = "_execTimeLabel";
            this._execTimeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // _serverStatusLabel1
            // 
            this._serverStatusLabel1.Name = "_serverStatusLabel1";
            this._serverStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this._serverStatusLabel1.Text = "Server:";
            // 
            // _dbNameStatusLabel
            // 
            this._dbNameStatusLabel.Name = "_dbNameStatusLabel";
            this._dbNameStatusLabel.Size = new System.Drawing.Size(25, 17);
            this._dbNameStatusLabel.Text = "DB:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.execute_MenuItem,
            this.cancelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newWindowToolStripMenuItem.Text = "New window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSQLScriptToolStripMenuItem1,
            this.openRScriptToolStripMenuItem1,
            this.openRServicesFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openSQLScriptToolStripMenuItem1
            // 
            this.openSQLScriptToolStripMenuItem1.Name = "openSQLScriptToolStripMenuItem1";
            this.openSQLScriptToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.openSQLScriptToolStripMenuItem1.Text = "SQL script";
            this.openSQLScriptToolStripMenuItem1.Click += new System.EventHandler(this.openSQLScriptToolStripMenuItem1_Click);
            // 
            // openRScriptToolStripMenuItem1
            // 
            this.openRScriptToolStripMenuItem1.Name = "openRScriptToolStripMenuItem1";
            this.openRScriptToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.openRScriptToolStripMenuItem1.Text = "R script";
            this.openRScriptToolStripMenuItem1.Click += new System.EventHandler(this.openRScriptToolStripMenuItem1_Click);
            // 
            // openRServicesFileToolStripMenuItem
            // 
            this.openRServicesFileToolStripMenuItem.Name = "openRServicesFileToolStripMenuItem";
            this.openRServicesFileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openRServicesFileToolStripMenuItem.Text = "R Services file";
            this.openRServicesFileToolStripMenuItem.Click += new System.EventHandler(this.openRServicesFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rScriptToolStripMenuItem,
            this.sQLScriptToolStripMenuItem,
            this.rServicesFileToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // rScriptToolStripMenuItem
            // 
            this.rScriptToolStripMenuItem.Name = "rScriptToolStripMenuItem";
            this.rScriptToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rScriptToolStripMenuItem.Text = "R Script";
            this.rScriptToolStripMenuItem.Click += new System.EventHandler(this.rScriptToolStripMenuItem_Click);
            // 
            // sQLScriptToolStripMenuItem
            // 
            this.sQLScriptToolStripMenuItem.Name = "sQLScriptToolStripMenuItem";
            this.sQLScriptToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sQLScriptToolStripMenuItem.Text = "SQL Script";
            this.sQLScriptToolStripMenuItem.Click += new System.EventHandler(this.sQLScriptToolStripMenuItem_Click);
            // 
            // rServicesFileToolStripMenuItem
            // 
            this.rServicesFileToolStripMenuItem.Name = "rServicesFileToolStripMenuItem";
            this.rServicesFileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rServicesFileToolStripMenuItem.Text = "R Services file";
            this.rServicesFileToolStripMenuItem.Click += new System.EventHandler(this.rServicesFileToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.setConnectionToolStripMenuItem,
            this.scriptsDBStorageToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // setConnectionToolStripMenuItem
            // 
            this.setConnectionToolStripMenuItem.Name = "setConnectionToolStripMenuItem";
            this.setConnectionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.setConnectionToolStripMenuItem.Text = "Set connection";
            this.setConnectionToolStripMenuItem.Click += new System.EventHandler(this.setConnectionToolStripMenuItem_Click);
            // 
            // scriptsDBStorageToolStripMenuItem
            // 
            this.scriptsDBStorageToolStripMenuItem.Name = "scriptsDBStorageToolStripMenuItem";
            this.scriptsDBStorageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.scriptsDBStorageToolStripMenuItem.Text = "Scripts DB storage";
            this.scriptsDBStorageToolStripMenuItem.Click += new System.EventHandler(this.scriptsDBStorageToolStripMenuItem_Click);
            // 
            // execute_MenuItem
            // 
            this.execute_MenuItem.Name = "execute_MenuItem";
            this.execute_MenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.execute_MenuItem.Size = new System.Drawing.Size(59, 20);
            this.execute_MenuItem.Text = "Execute";
            this.execute_MenuItem.Click += new System.EventHandler(this.execute_MenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Results type";
            // 
            // _currentScriptLabel
            // 
            this._currentScriptLabel.AutoSize = true;
            this._currentScriptLabel.Location = new System.Drawing.Point(214, 34);
            this._currentScriptLabel.Name = "_currentScriptLabel";
            this._currentScriptLabel.Size = new System.Drawing.Size(103, 13);
            this._currentScriptLabel.TabIndex = 9;
            this._currentScriptLabel.Text = "Script is not from DB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 469);
            this.Controls.Add(this._currentScriptLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "R Services ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._scriptTextBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._inputScriptTextBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox _scriptTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox _inputScriptTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _execTimeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem execute_MenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem setConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel _serverStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel _dbNameStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSQLScriptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openRScriptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openRServicesFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rServicesFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptsDBStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Label _currentScriptLabel;
    }
}