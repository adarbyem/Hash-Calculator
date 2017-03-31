namespace HashCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.introLabel = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonMD5 = new System.Windows.Forms.Button();
            this.buttonSHA256 = new System.Windows.Forms.Button();
            this.buttonSHA512 = new System.Windows.Forms.Button();
            this.labelHash = new System.Windows.Forms.Label();
            this.labelHashGenerated = new System.Windows.Forms.TextBox();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.labelHashCompare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.Location = new System.Drawing.Point(12, 9);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(295, 55);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = resources.GetString("introLabel.Text");
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(12, 67);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(201, 20);
            this.textBoxFile.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(229, 65);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonMD5
            // 
            this.buttonMD5.Location = new System.Drawing.Point(26, 93);
            this.buttonMD5.Name = "buttonMD5";
            this.buttonMD5.Size = new System.Drawing.Size(75, 23);
            this.buttonMD5.TabIndex = 3;
            this.buttonMD5.Text = "MD5";
            this.buttonMD5.UseVisualStyleBackColor = true;
            this.buttonMD5.Click += new System.EventHandler(this.buttonMD5_Click);
            // 
            // buttonSHA256
            // 
            this.buttonSHA256.Location = new System.Drawing.Point(120, 93);
            this.buttonSHA256.Name = "buttonSHA256";
            this.buttonSHA256.Size = new System.Drawing.Size(75, 23);
            this.buttonSHA256.TabIndex = 4;
            this.buttonSHA256.Text = "SHA256";
            this.buttonSHA256.UseVisualStyleBackColor = true;
            this.buttonSHA256.Click += new System.EventHandler(this.buttonSHA256_Click);
            // 
            // buttonSHA512
            // 
            this.buttonSHA512.Location = new System.Drawing.Point(214, 94);
            this.buttonSHA512.Name = "buttonSHA512";
            this.buttonSHA512.Size = new System.Drawing.Size(75, 23);
            this.buttonSHA512.TabIndex = 5;
            this.buttonSHA512.Text = "SHA512";
            this.buttonSHA512.UseVisualStyleBackColor = true;
            this.buttonSHA512.Click += new System.EventHandler(this.buttonSHA512_Click);
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHash.Location = new System.Drawing.Point(105, 156);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(99, 13);
            this.labelHash.TabIndex = 6;
            this.labelHash.Text = "Generated Hash";
            // 
            // labelHashGenerated
            // 
            this.labelHashGenerated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelHashGenerated.Location = new System.Drawing.Point(12, 172);
            this.labelHashGenerated.Multiline = true;
            this.labelHashGenerated.Name = "labelHashGenerated";
            this.labelHashGenerated.ReadOnly = true;
            this.labelHashGenerated.Size = new System.Drawing.Size(292, 60);
            this.labelHashGenerated.TabIndex = 7;
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(57, 122);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(194, 21);
            this.comboBoxMenu.TabIndex = 8;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // labelHashCompare
            // 
            this.labelHashCompare.AutoSize = true;
            this.labelHashCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHashCompare.Location = new System.Drawing.Point(105, 156);
            this.labelHashCompare.Name = "labelHashCompare";
            this.labelHashCompare.Size = new System.Drawing.Size(108, 13);
            this.labelHashCompare.TabIndex = 9;
            this.labelHashCompare.Text = "Enter Hash Below";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 249);
            this.Controls.Add(this.labelHashCompare);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.labelHashGenerated);
            this.Controls.Add(this.labelHash);
            this.Controls.Add(this.buttonSHA512);
            this.Controls.Add(this.buttonSHA256);
            this.Controls.Add(this.buttonMD5);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.introLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Calculator v1.1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonMD5;
        private System.Windows.Forms.Button buttonSHA256;
        private System.Windows.Forms.Button buttonSHA512;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.TextBox labelHashGenerated;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelHashCompare;
    }
}

