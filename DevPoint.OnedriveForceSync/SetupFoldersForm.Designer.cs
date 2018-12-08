namespace DevPoint.OnedriveForceSync
{
    partial class SetupFoldersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupFoldersForm));
            this.txtFolders = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.folderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFolders
            // 
            this.txtFolders.Location = new System.Drawing.Point(28, 46);
            this.txtFolders.Multiline = true;
            this.txtFolders.Name = "txtFolders";
            this.txtFolders.Size = new System.Drawing.Size(1451, 745);
            this.txtFolders.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(804, 815);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(675, 67);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(28, 815);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(675, 67);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.Text = "Add Onedrive Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Onedrive foler, 1 per line";
            // 
            // SetupFoldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1517, 901);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFolders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetupFoldersForm";
            this.Text = "Onedrive Force Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolders;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderPicker;
        private System.Windows.Forms.Label label1;
    }
}

