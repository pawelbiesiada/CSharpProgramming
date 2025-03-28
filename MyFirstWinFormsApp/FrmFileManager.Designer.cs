namespace MyFirstWinFormsApp
{
    partial class FrmFileManager
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
            txtContent = new TextBox();
            txtFilePath = new TextBox();
            btnOpen = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 12);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(776, 368);
            txtContent.TabIndex = 0;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 399);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(345, 23);
            txtFilePath.TabIndex = 1;
            txtFilePath.Text = "C:\\Temp\\myFile.txt";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(384, 399);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(498, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmFileManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(txtFilePath);
            Controls.Add(txtContent);
            Name = "FrmFileManager";
            Text = "FrmFileManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContent;
        private TextBox txtFilePath;
        private Button btnOpen;
        private Button btnSave;
    }
}