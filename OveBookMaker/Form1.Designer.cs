namespace OveBookMaker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.заменитьёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.redToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.greenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pushToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadTSButton = new System.Windows.Forms.ToolStripButton();
            this.saveTSButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.redToolStripButton,
            this.greenToolStripButton,
            this.pushToolStripButton,
            this.toolStripSeparator2,
            this.loadTSButton,
            this.saveTSButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заменитьёToolStripMenuItem,
            this.форматированиеToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(119, 22);
            this.toolStripSplitButton1.Text = "Форматирование";
            // 
            // заменитьёToolStripMenuItem
            // 
            this.заменитьёToolStripMenuItem.Name = "заменитьёToolStripMenuItem";
            this.заменитьёToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.заменитьёToolStripMenuItem.Text = "Вотермарка (+)";
            this.заменитьёToolStripMenuItem.Click += new System.EventHandler(this.заменитьёToolStripMenuItem_Click);
            // 
            // форматированиеToolStripMenuItem
            // 
            this.форматированиеToolStripMenuItem.Name = "форматированиеToolStripMenuItem";
            this.форматированиеToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.форматированиеToolStripMenuItem.Text = "Заменить \"ё\"";
            this.форматированиеToolStripMenuItem.Click += new System.EventHandler(this.форматированиеToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // redToolStripButton
            // 
            this.redToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redToolStripButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redToolStripButton.Image = global::OveBookMaker.Properties.Resources.RedButton;
            this.redToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redToolStripButton.Name = "redToolStripButton";
            this.redToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.redToolStripButton.Text = "Границы";
            this.redToolStripButton.Click += new System.EventHandler(this.redToolStripButton_Click);
            // 
            // greenToolStripButton
            // 
            this.greenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.greenToolStripButton.Image = global::OveBookMaker.Properties.Resources.GreenButton;
            this.greenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenToolStripButton.Name = "greenToolStripButton";
            this.greenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.greenToolStripButton.Text = "Граница отправки";
            this.greenToolStripButton.Click += new System.EventHandler(this.greenToolStripButton_Click);
            // 
            // pushToolStripButton
            // 
            this.pushToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pushToolStripButton.Image = global::OveBookMaker.Properties.Resources.PushButton;
            this.pushToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pushToolStripButton.Name = "pushToolStripButton";
            this.pushToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pushToolStripButton.Text = "Отправить";
            this.pushToolStripButton.Click += new System.EventHandler(this.pushToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // loadTSButton
            // 
            this.loadTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadTSButton.Image = global::OveBookMaker.Properties.Resources.load_button;
            this.loadTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadTSButton.Name = "loadTSButton";
            this.loadTSButton.Size = new System.Drawing.Size(23, 22);
            this.loadTSButton.Text = "Загрузить";
            this.loadTSButton.Click += new System.EventHandler(this.loadTSButton_Click);
            // 
            // saveTSButton
            // 
            this.saveTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTSButton.Image = global::OveBookMaker.Properties.Resources.save_button1;
            this.saveTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTSButton.Name = "saveTSButton";
            this.saveTSButton.Size = new System.Drawing.Size(23, 22);
            this.saveTSButton.Text = "Сохранить";
            this.saveTSButton.Click += new System.EventHandler(this.saveTSButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer1.Size = new System.Drawing.Size(524, 281);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Magic Cyr", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 281);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Magic Cyr", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(260, 281);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 306);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Ove Book Maker";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem форматированиеToolStripMenuItem;
        private ToolStripMenuItem заменитьёToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton redToolStripButton;
        private ToolStripButton greenToolStripButton;
        private ToolStripButton pushToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton saveTSButton;
        private SplitContainer splitContainer1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton loadTSButton;
        private OpenFileDialog openFileDialog1;
    }
}