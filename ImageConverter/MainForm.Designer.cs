namespace ImageConverter {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlDropZone = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBulkConvert = new System.Windows.Forms.Button();
            this.btnBulkImport = new System.Windows.Forms.Button();
            this.lstBulk = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlDropZone.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.Location = new System.Drawing.Point(6, 6);
            this.picPreview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(822, 417);
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 430);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 120);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlDropZone);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(814, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlDropZone
            // 
            this.pnlDropZone.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDropZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDropZone.Controls.Add(this.label1);
            this.pnlDropZone.Location = new System.Drawing.Point(589, 14);
            this.pnlDropZone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlDropZone.Name = "pnlDropZone";
            this.pnlDropZone.Size = new System.Drawing.Size(216, 74);
            this.pnlDropZone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop Zone!";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 39);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 22);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(8, 7);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(115, 22);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import HEIC...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.btnBulkConvert);
            this.tabPage2.Controls.Add(this.btnBulkImport);
            this.tabPage2.Controls.Add(this.lstBulk);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(814, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bulk Operations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PNG",
            "JPEG"});
            this.comboBox1.Location = new System.Drawing.Point(391, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // btnBulkConvert
            // 
            this.btnBulkConvert.Location = new System.Drawing.Point(391, 59);
            this.btnBulkConvert.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBulkConvert.Name = "btnBulkConvert";
            this.btnBulkConvert.Size = new System.Drawing.Size(136, 22);
            this.btnBulkConvert.TabIndex = 2;
            this.btnBulkConvert.Text = "Convert";
            this.btnBulkConvert.UseVisualStyleBackColor = true;
            this.btnBulkConvert.Click += new System.EventHandler(this.btnBulkConvert_Click);
            // 
            // btnBulkImport
            // 
            this.btnBulkImport.Location = new System.Drawing.Point(391, 10);
            this.btnBulkImport.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBulkImport.Name = "btnBulkImport";
            this.btnBulkImport.Size = new System.Drawing.Size(136, 22);
            this.btnBulkImport.TabIndex = 1;
            this.btnBulkImport.Text = "Import Folder";
            this.btnBulkImport.UseVisualStyleBackColor = true;
            this.btnBulkImport.Click += new System.EventHandler(this.btnBulkImport_Click);
            // 
            // lstBulk
            // 
            this.lstBulk.FormattingEnabled = true;
            this.lstBulk.ItemHeight = 15;
            this.lstBulk.Location = new System.Drawing.Point(530, 10);
            this.lstBulk.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lstBulk.Name = "lstBulk";
            this.lstBulk.Size = new System.Drawing.Size(266, 79);
            this.lstBulk.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG Files|*.png";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "HEIC Files|*.heic";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 555);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.picPreview);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.Text = "Image Converter";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlDropZone.ResumeLayout(false);
            this.pnlDropZone.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBulkConvert;
        private System.Windows.Forms.Button btnBulkImport;
        private System.Windows.Forms.ListBox lstBulk;
        private System.Windows.Forms.Panel pnlDropZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

