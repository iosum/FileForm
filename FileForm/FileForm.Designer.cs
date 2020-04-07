namespace FileForm
{
    partial class FileForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ReadFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ReadLastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.UploadFileGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteFileGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WriteLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UploadFileGroupBox.SuspendLayout();
            this.WriteFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(21, 34);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(119, 26);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // ReadFirstNameTextBox
            // 
            this.ReadFirstNameTextBox.Location = new System.Drawing.Point(26, 83);
            this.ReadFirstNameTextBox.Name = "ReadFirstNameTextBox";
            this.ReadFirstNameTextBox.Size = new System.Drawing.Size(326, 32);
            this.ReadFirstNameTextBox.TabIndex = 1;
            // 
            // ReadLastNameTextBox
            // 
            this.ReadLastNameTextBox.Location = new System.Drawing.Point(26, 188);
            this.ReadLastNameTextBox.Name = "ReadLastNameTextBox";
            this.ReadLastNameTextBox.Size = new System.Drawing.Size(326, 32);
            this.ReadLastNameTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(22, 140);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(118, 26);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(226, 273);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(137, 44);
            this.UploadFileButton.TabIndex = 4;
            this.UploadFileButton.Text = "Upload";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this._uploadFileButton_click);
            // 
            // UploadFileGroupBox
            // 
            this.UploadFileGroupBox.Controls.Add(this.ReadFirstNameTextBox);
            this.UploadFileGroupBox.Controls.Add(this.UploadFileButton);
            this.UploadFileGroupBox.Controls.Add(this.FirstNameLabel);
            this.UploadFileGroupBox.Controls.Add(this.ReadLastNameTextBox);
            this.UploadFileGroupBox.Controls.Add(this.LastNameLabel);
            this.UploadFileGroupBox.Location = new System.Drawing.Point(71, 51);
            this.UploadFileGroupBox.Name = "UploadFileGroupBox";
            this.UploadFileGroupBox.Size = new System.Drawing.Size(446, 343);
            this.UploadFileGroupBox.TabIndex = 5;
            this.UploadFileGroupBox.TabStop = false;
            this.UploadFileGroupBox.Text = "Upload File";
            // 
            // WriteFileGroupBox
            // 
            this.WriteFileGroupBox.Controls.Add(this.WriteFirstNameTextBox);
            this.WriteFileGroupBox.Controls.Add(this.SaveButton);
            this.WriteFileGroupBox.Controls.Add(this.label1);
            this.WriteFileGroupBox.Controls.Add(this.WriteLastNameTextBox);
            this.WriteFileGroupBox.Controls.Add(this.label2);
            this.WriteFileGroupBox.Location = new System.Drawing.Point(603, 51);
            this.WriteFileGroupBox.Name = "WriteFileGroupBox";
            this.WriteFileGroupBox.Size = new System.Drawing.Size(446, 343);
            this.WriteFileGroupBox.TabIndex = 6;
            this.WriteFileGroupBox.TabStop = false;
            this.WriteFileGroupBox.Text = "Write File";
            // 
            // WriteFirstNameTextBox
            // 
            this.WriteFirstNameTextBox.Location = new System.Drawing.Point(26, 83);
            this.WriteFirstNameTextBox.Name = "WriteFirstNameTextBox";
            this.WriteFirstNameTextBox.Size = new System.Drawing.Size(326, 32);
            this.WriteFirstNameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(215, 273);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(137, 44);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this._saveButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // WriteLastNameTextBox
            // 
            this.WriteLastNameTextBox.Location = new System.Drawing.Point(26, 188);
            this.WriteLastNameTextBox.Name = "WriteLastNameTextBox";
            this.WriteLastNameTextBox.Size = new System.Drawing.Size(326, 32);
            this.WriteLastNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // FileForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1059, 421);
            this.Controls.Add(this.WriteFileGroupBox);
            this.Controls.Add(this.UploadFileGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Form";
            this.UploadFileGroupBox.ResumeLayout(false);
            this.UploadFileGroupBox.PerformLayout();
            this.WriteFileGroupBox.ResumeLayout(false);
            this.WriteFileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox ReadFirstNameTextBox;
        private System.Windows.Forms.TextBox ReadLastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button UploadFileButton;
        private System.Windows.Forms.GroupBox UploadFileGroupBox;
        private System.Windows.Forms.GroupBox WriteFileGroupBox;
        private System.Windows.Forms.TextBox WriteFirstNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WriteLastNameTextBox;
        private System.Windows.Forms.Label label2;
    }
}

