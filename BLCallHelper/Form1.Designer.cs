namespace BLCallHelper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.loadTSButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.calculateTSButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.addresLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTSButton,
            this.toolStripSeparator1,
            this.calculateTSButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // loadTSButton
            // 
            this.loadTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadTSButton.Image = ((System.Drawing.Image)(resources.GetObject("loadTSButton.Image")));
            this.loadTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadTSButton.Name = "loadTSButton";
            this.loadTSButton.Size = new System.Drawing.Size(81, 28);
            this.loadTSButton.Text = "Загрузить";
            this.loadTSButton.Click += new System.EventHandler(this.loadTSButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // calculateTSButton
            // 
            this.calculateTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.calculateTSButton.Image = ((System.Drawing.Image)(resources.GetObject("calculateTSButton.Image")));
            this.calculateTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calculateTSButton.Name = "calculateTSButton";
            this.calculateTSButton.Size = new System.Drawing.Size(93, 28);
            this.calculateTSButton.Text = "Подсчитать";
            this.calculateTSButton.Click += new System.EventHandler(this.tsButtonCalculate_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер";
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(389, 218);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(139, 28);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Следующий";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // addresLabel
            // 
            this.addresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addresLabel.Location = new System.Drawing.Point(113, 41);
            this.addresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addresLabel.Name = "addresLabel";
            this.addresLabel.Size = new System.Drawing.Size(415, 30);
            this.addresLabel.TabIndex = 6;
            this.addresLabel.Text = "(Улица) (Дом)";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(113, 70);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(415, 30);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "Фамилия Имя Отчество";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(113, 129);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(172, 29);
            this.numberTextBox.TabIndex = 9;
            this.numberTextBox.Text = "XXX XXX-XX-XX";
            // 
            // labelLine1
            // 
            this.labelLine1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLine1.Location = new System.Drawing.Point(101, 41);
            this.labelLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(4, 164);
            this.labelLine1.TabIndex = 10;
            // 
            // labelLine2
            // 
            this.labelLine2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelLine2.Location = new System.Drawing.Point(16, 209);
            this.labelLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(512, 4);
            this.labelLine2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Плата";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(113, 100);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(415, 30);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "XXX р.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Office Files|*.xls; *.xlsx";
            this.openFileDialog1.Title = "Выбирете файл";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(242, 217);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 28);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Предыдущий";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(113, 172);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(131, 29);
            this.idTextBox.TabIndex = 18;
            this.idTextBox.Text = "XXX";
            // 
            // idButton
            // 
            this.idButton.Enabled = false;
            this.idButton.Location = new System.Drawing.Point(252, 172);
            this.idButton.Margin = new System.Windows.Forms.Padding(4);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(29, 29);
            this.idButton.TabIndex = 19;
            this.idButton.Text = ">";
            this.idButton.UseVisualStyleBackColor = true;
            this.idButton.Click += new System.EventHandler(this.idButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 252);
            this.Controls.Add(this.idButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.labelLine1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.addresLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Данные";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton calculateTSButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label addresLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.ToolStripButton loadTSButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button idButton;
    }
}

