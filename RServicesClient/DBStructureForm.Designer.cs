namespace DataAnalyzer
{
    partial class DBStructureForm
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
            this._statusLabel = new System.Windows.Forms.Label();
            this._initStructureBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._categoriesList = new System.Windows.Forms.ListBox();
            this._addCategoryBtn = new System.Windows.Forms.Button();
            this._upCategoriesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._scriptsList = new System.Windows.Forms.ListBox();
            this._addScriptBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._loadBtn = new System.Windows.Forms.Button();
            this._saveCurrent = new System.Windows.Forms.Button();
            this.contextMenuScripts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuScripts.SuspendLayout();
            this.contextMenuCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // _statusLabel
            // 
            this._statusLabel.AutoSize = true;
            this._statusLabel.Location = new System.Drawing.Point(12, 9);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(35, 13);
            this._statusLabel.TabIndex = 0;
            this._statusLabel.Text = "status";
            // 
            // _initStructureBtn
            // 
            this._initStructureBtn.Location = new System.Drawing.Point(15, 25);
            this._initStructureBtn.Name = "_initStructureBtn";
            this._initStructureBtn.Size = new System.Drawing.Size(131, 29);
            this._initStructureBtn.TabIndex = 1;
            this._initStructureBtn.Text = "Init storage structure";
            this._initStructureBtn.UseVisualStyleBackColor = true;
            this._initStructureBtn.Visible = false;
            this._initStructureBtn.Click += new System.EventHandler(this._initStructureBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(15, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._categoriesList);
            this.splitContainer1.Panel1.Controls.Add(this._addCategoryBtn);
            this.splitContainer1.Panel1.Controls.Add(this._upCategoriesBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._scriptsList);
            this.splitContainer1.Panel2.Controls.Add(this._addScriptBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(504, 279);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 2;
            // 
            // _categoriesList
            // 
            this._categoriesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._categoriesList.ContextMenuStrip = this.contextMenuCategories;
            this._categoriesList.FormattingEnabled = true;
            this._categoriesList.Location = new System.Drawing.Point(4, 32);
            this._categoriesList.Name = "_categoriesList";
            this._categoriesList.Size = new System.Drawing.Size(260, 238);
            this._categoriesList.TabIndex = 4;
            this._categoriesList.SelectedIndexChanged += new System.EventHandler(this._categoriesList_SelectedIndexChanged);
            this._categoriesList.DoubleClick += new System.EventHandler(this._categoriesList_DoubleClick);
            // 
            // _addCategoryBtn
            // 
            this._addCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._addCategoryBtn.Location = new System.Drawing.Point(204, 4);
            this._addCategoryBtn.Name = "_addCategoryBtn";
            this._addCategoryBtn.Size = new System.Drawing.Size(25, 22);
            this._addCategoryBtn.TabIndex = 3;
            this._addCategoryBtn.Text = "+";
            this._addCategoryBtn.UseVisualStyleBackColor = true;
            this._addCategoryBtn.Click += new System.EventHandler(this._addCategoryBtn_Click);
            // 
            // _upCategoriesBtn
            // 
            this._upCategoriesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._upCategoriesBtn.Location = new System.Drawing.Point(235, 4);
            this._upCategoriesBtn.Name = "_upCategoriesBtn";
            this._upCategoriesBtn.Size = new System.Drawing.Size(25, 22);
            this._upCategoriesBtn.TabIndex = 2;
            this._upCategoriesBtn.Text = "..";
            this._upCategoriesBtn.UseVisualStyleBackColor = true;
            this._upCategoriesBtn.Click += new System.EventHandler(this._categoryUpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // _scriptsList
            // 
            this._scriptsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._scriptsList.ContextMenuStrip = this.contextMenuScripts;
            this._scriptsList.FormattingEnabled = true;
            this._scriptsList.Location = new System.Drawing.Point(7, 31);
            this._scriptsList.Name = "_scriptsList";
            this._scriptsList.Size = new System.Drawing.Size(218, 238);
            this._scriptsList.TabIndex = 5;
            this._scriptsList.DoubleClick += new System.EventHandler(this._scriptsList_DoubleClick);
            // 
            // _addScriptBtn
            // 
            this._addScriptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._addScriptBtn.Location = new System.Drawing.Point(200, 4);
            this._addScriptBtn.Name = "_addScriptBtn";
            this._addScriptBtn.Size = new System.Drawing.Size(25, 22);
            this._addScriptBtn.TabIndex = 4;
            this._addScriptBtn.Text = "+";
            this._addScriptBtn.UseVisualStyleBackColor = true;
            this._addScriptBtn.Click += new System.EventHandler(this._addScriptBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scripts";
            // 
            // _loadBtn
            // 
            this._loadBtn.Location = new System.Drawing.Point(15, 25);
            this._loadBtn.Name = "_loadBtn";
            this._loadBtn.Size = new System.Drawing.Size(57, 29);
            this._loadBtn.TabIndex = 3;
            this._loadBtn.Text = "Reload";
            this._loadBtn.UseVisualStyleBackColor = true;
            this._loadBtn.Visible = false;
            this._loadBtn.Click += new System.EventHandler(this._loadBtn_Click);
            // 
            // _saveCurrent
            // 
            this._saveCurrent.Location = new System.Drawing.Point(78, 25);
            this._saveCurrent.Name = "_saveCurrent";
            this._saveCurrent.Size = new System.Drawing.Size(83, 29);
            this._saveCurrent.TabIndex = 4;
            this._saveCurrent.Text = "Save current";
            this._saveCurrent.UseVisualStyleBackColor = true;
            this._saveCurrent.Visible = false;
            this._saveCurrent.Click += new System.EventHandler(this._saveCurrent_Click);
            // 
            // contextMenuScripts
            // 
            this.contextMenuScripts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuScripts.Name = "contextMenuScripts";
            this.contextMenuScripts.Size = new System.Drawing.Size(118, 48);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuCategories
            // 
            this.contextMenuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuCategories.Name = "contextMenuScripts";
            this.contextMenuCategories.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Rename";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Delete";
            // 
            // DBStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 351);
            this.Controls.Add(this._saveCurrent);
            this.Controls.Add(this._loadBtn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._initStructureBtn);
            this.Controls.Add(this._statusLabel);
            this.Name = "DBStructureForm";
            this.Text = "DB Storage";
            this.Load += new System.EventHandler(this.DBStructureForm_Load);
            this.Shown += new System.EventHandler(this.DBStructureForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuScripts.ResumeLayout(false);
            this.contextMenuCategories.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _statusLabel;
        private System.Windows.Forms.Button _initStructureBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _upCategoriesBtn;
        private System.Windows.Forms.Button _loadBtn;
        private System.Windows.Forms.Button _addCategoryBtn;
        private System.Windows.Forms.Button _addScriptBtn;
        private System.Windows.Forms.Button _saveCurrent;
        private System.Windows.Forms.ListBox _categoriesList;
        private System.Windows.Forms.ListBox _scriptsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuCategories;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuScripts;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}