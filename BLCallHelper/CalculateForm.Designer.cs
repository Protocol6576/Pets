namespace BLCallHelper
{
    partial class CalculateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.routerCheckBox = new System.Windows.Forms.CheckBox();
            this.smNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tvNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.shareCheckBox = new System.Windows.Forms.CheckBox();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.smNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цена:";
            // 
            // routerCheckBox
            // 
            this.routerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routerCheckBox.Location = new System.Drawing.Point(148, 12);
            this.routerCheckBox.Name = "routerCheckBox";
            this.routerCheckBox.Size = new System.Drawing.Size(75, 21);
            this.routerCheckBox.TabIndex = 2;
            this.routerCheckBox.Text = "Роутер";
            this.routerCheckBox.UseVisualStyleBackColor = true;
            this.routerCheckBox.CheckedChanged += new System.EventHandler(this.routerCheckBox_CheckedChanged);
            // 
            // smNumericUpDown
            // 
            this.smNumericUpDown.Location = new System.Drawing.Point(148, 65);
            this.smNumericUpDown.Name = "smNumericUpDown";
            this.smNumericUpDown.Size = new System.Drawing.Size(36, 20);
            this.smNumericUpDown.TabIndex = 4;
            this.smNumericUpDown.ValueChanged += new System.EventHandler(this.smNumericUpDown_ValueChanged);
            // 
            // tvNumericUpDown
            // 
            this.tvNumericUpDown.Location = new System.Drawing.Point(148, 39);
            this.tvNumericUpDown.Name = "tvNumericUpDown";
            this.tvNumericUpDown.Size = new System.Drawing.Size(36, 20);
            this.tvNumericUpDown.TabIndex = 6;
            this.tvNumericUpDown.ValueChanged += new System.EventHandler(this.tvNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "ТВ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(190, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "SM";
            // 
            // labelLine1
            // 
            this.labelLine1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLine1.Location = new System.Drawing.Point(139, 12);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(3, 154);
            this.labelLine1.TabIndex = 9;
            // 
            // shareCheckBox
            // 
            this.shareCheckBox.AutoSize = true;
            this.shareCheckBox.Location = new System.Drawing.Point(148, 91);
            this.shareCheckBox.Name = "shareCheckBox";
            this.shareCheckBox.Size = new System.Drawing.Size(74, 17);
            this.shareCheckBox.TabIndex = 10;
            this.shareCheckBox.Text = "Дели все";
            this.shareCheckBox.UseVisualStyleBackColor = true;
            this.shareCheckBox.CheckedChanged += new System.EventHandler(this.shareCheckBox_CheckedChanged);
            // 
            // labelLine2
            // 
            this.labelLine2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLine2.Location = new System.Drawing.Point(9, 170);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(257, 3);
            this.labelLine2.TabIndex = 11;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(66, 177);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(200, 23);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Для дома (100)",
            "Для дома (300)",
            "Для дома (500)",
            "Для дома с ТВ (100)",
            "Для дома с ТВ (300)",
            "Для дома с ТВ (500)",
            "Для тебя и дома 1",
            "Для тебя и дома 2",
            "На максимум! +"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 154);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 205);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.shareCheckBox);
            this.Controls.Add(this.labelLine1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvNumericUpDown);
            this.Controls.Add(this.smNumericUpDown);
            this.Controls.Add(this.routerCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculateForm";
            this.Text = "Вычисление";
            this.Load += new System.EventHandler(this.CalculateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox routerCheckBox;
        private System.Windows.Forms.NumericUpDown smNumericUpDown;
        private System.Windows.Forms.NumericUpDown tvNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.CheckBox shareCheckBox;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListBox listBox1;
    }
}