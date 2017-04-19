namespace LogViewer
{
    partial class NLogViewer
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
            this.logGrid = new System.Windows.Forms.DataGridView();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.loadFile = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // logGrid
            // 
            this.logGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGrid.Location = new System.Drawing.Point(12, 34);
            this.logGrid.Name = "logGrid";
            this.logGrid.Size = new System.Drawing.Size(1203, 367);
            this.logGrid.TabIndex = 0;
            this.logGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(598, 5);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(75, 23);
            this.loadFile.TabIndex = 1;
            this.loadFile.Text = "Load File";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(13, 5);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 13);
            this.fileName.TabIndex = 2;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(517, 5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Visible = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // NLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 413);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.logGrid);
            this.Name = "NLogViewer";
            this.Text = "NLogViewer";
            this.Load += new System.EventHandler(this.NLogViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView logGrid;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button refresh;
    }
}

