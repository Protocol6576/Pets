namespace SD_PROC
{
    partial class SubmitForm
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
            this.depCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.sdProcIdTextBox = new System.Windows.Forms.TextBox();
            this.idSetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depCheckedListBox
            // 
            this.depCheckedListBox.CheckOnClick = true;
            this.depCheckedListBox.FormattingEnabled = true;
            this.depCheckedListBox.Location = new System.Drawing.Point(12, 64);
            this.depCheckedListBox.Name = "depCheckedListBox";
            this.depCheckedListBox.Size = new System.Drawing.Size(234, 169);
            this.depCheckedListBox.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 268);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(234, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Подать документ";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // sdProcIdTextBox
            // 
            this.sdProcIdTextBox.Location = new System.Drawing.Point(12, 12);
            this.sdProcIdTextBox.Name = "sdProcIdTextBox";
            this.sdProcIdTextBox.Size = new System.Drawing.Size(122, 20);
            this.sdProcIdTextBox.TabIndex = 2;
            // 
            // idSetTextBox
            // 
            this.idSetTextBox.Location = new System.Drawing.Point(12, 38);
            this.idSetTextBox.Name = "idSetTextBox";
            this.idSetTextBox.Size = new System.Drawing.Size(100, 20);
            this.idSetTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Обозначение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Путь к файлу";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "(Ошибка)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // uploadButton
            // 
            this.uploadButton.BackgroundImage = global::SD_PROC.Properties.Resources.upload_icon;
            this.uploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadButton.ForeColor = System.Drawing.Color.Black;
            this.uploadButton.Location = new System.Drawing.Point(112, 37);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(22, 22);
            this.uploadButton.TabIndex = 7;
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // noteButton
            // 
            this.noteButton.Location = new System.Drawing.Point(12, 239);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(234, 23);
            this.noteButton.TabIndex = 8;
            this.noteButton.Text = "Добавить примечание";
            this.noteButton.UseVisualStyleBackColor = true;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(288, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(234, 295);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lineLabel.Location = new System.Drawing.Point(266, 13);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(2, 295);
            this.lineLabel.TabIndex = 10;
            // 
            // SubmitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 319);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idSetTextBox);
            this.Controls.Add(this.sdProcIdTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.depCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SubmitForm";
            this.Text = "Подать на согл.";
            this.Load += new System.EventHandler(this.SumbitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox depCheckedListBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox sdProcIdTextBox;
        private System.Windows.Forms.TextBox idSetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lineLabel;
    }
}