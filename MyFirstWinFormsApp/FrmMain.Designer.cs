

namespace MyFirstWinFormsApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOK = new Button();
            txtDescription = new TextBox();
            txtTextField = new TextBox();
            chbEnableText = new CheckBox();
            cbxNames = new ComboBox();
            btnGrid = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(184, 62);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            btnOK.MouseEnter += btnOK_MouseEnter;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 62);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(155, 23);
            txtDescription.TabIndex = 1;
            txtDescription.TextChanged += txtDescription_TextChanged;
            txtDescription.KeyPress += txtDescription_KeyPress;
            // 
            // txtTextField
            // 
            txtTextField.Location = new Point(12, 105);
            txtTextField.Multiline = true;
            txtTextField.Name = "txtTextField";
            txtTextField.ScrollBars = ScrollBars.Vertical;
            txtTextField.Size = new Size(247, 231);
            txtTextField.TabIndex = 2;
            // 
            // chbEnableText
            // 
            chbEnableText.AutoSize = true;
            chbEnableText.Location = new Point(20, 33);
            chbEnableText.Name = "chbEnableText";
            chbEnableText.Size = new Size(100, 19);
            chbEnableText.TabIndex = 3;
            chbEnableText.Text = "Zablokuj tekst";
            chbEnableText.UseVisualStyleBackColor = true;
            chbEnableText.CheckedChanged += chbEnableText_CheckedChanged;
            // 
            // cbxNames
            // 
            cbxNames.FormattingEnabled = true;
            cbxNames.Location = new Point(324, 63);
            cbxNames.Name = "cbxNames";
            cbxNames.Size = new Size(218, 23);
            cbxNames.TabIndex = 4;
            cbxNames.SelectedIndexChanged += cbxNames_SelectedIndexChanged;
            // 
            // btnGrid
            // 
            btnGrid.Location = new Point(520, 410);
            btnGrid.Name = "btnGrid";
            btnGrid.Size = new Size(75, 23);
            btnGrid.TabIndex = 5;
            btnGrid.Text = "Nowy";
            btnGrid.UseVisualStyleBackColor = true;
            btnGrid.Click += btnGrid_Click;
            // 
            // button1
            // 
            button1.Location = new Point(481, 371);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 6;
            button1.Text = "File Manager";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(button1);
            Controls.Add(btnGrid);
            Controls.Add(cbxNames);
            Controls.Add(chbEnableText);
            Controls.Add(txtTextField);
            Controls.Add(txtDescription);
            Controls.Add(btnOK);
            Name = "FrmMain";
            Text = "WinfForms tests";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnOK;
        private TextBox txtDescription;
        private TextBox txtTextField;
        private CheckBox chbEnableText;
        private ComboBox cbxNames;
        private Button btnGrid;
        private Button button1;
    }
}
