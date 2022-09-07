namespace OveBookMaker
{
    public partial class Form1 : Form
    {
        int confines = 255; // Максимальный размер страницы. Выделает красным
        int confCount = 5;
        bool isConfines = false; // Наличие выделения от confines
        int greenPosition = 1;
        bool watherMark = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Confining() // Выделение границ.
        {
            Color confColor = Color.Red; // Цвет выделения

            for (int i = 1; i <= confCount; i++)
            {
                richTextBox1.Select(confines * i, 1);
                richTextBox1.SelectionBackColor = confColor;
            }
        }

        private void GreenConfining() // Выделение зеленой границч
        {
            Color confColor = Color.Green; // Стандартный цвет
            Color altConfColor = Color.Blue; // Цвет выделения, на случай если совпадет в крсной границей

            richTextBox1.Select(greenPosition, 1);
            if(greenPosition % confines == 0)
                richTextBox1.SelectionBackColor = altConfColor;
            else
                richTextBox1.SelectionBackColor = confColor;
        }

        private void ClearConf() // Убрать границы
        {
            Color generalColor = Color.White; // Цвет выделения

            for (int i = 1; i <= confCount; i++)
            {
                richTextBox1.Select(confines * i - 1, 3);
                richTextBox1.SelectionBackColor = generalColor;
            }

            richTextBox1.Select(greenPosition - 1, 3);
            richTextBox1.SelectionBackColor = generalColor;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;
            if (isConfines)
            {
                ClearConf();
                Confining();
                GreenConfining();
            }
            richTextBox1.Select(cursorPosition, 0);
        }

        private void redToolStripButton_Click(object sender, EventArgs e)
        {
            var cursorPosition = richTextBox1.SelectionStart;

            // Включение / выключение выделения
            if (isConfines)
            {
                isConfines = false;
                ClearConf();
            }
            else
            {
                isConfines = true;
                Confining();
            }
            richTextBox1.Select(cursorPosition, 0);
        }

        private void greenToolStripButton_Click(object sender, EventArgs e)
        {
            Color generalColor = Color.White; // Цвет выделения
            int cursorPosition = richTextBox1.SelectionStart;
            int pastGreenPosition = greenPosition;



            if (cursorPosition == 0)
                greenPosition = 1;
            else
                greenPosition = cursorPosition;
            richTextBox1.Select(pastGreenPosition - 1, 3);
            richTextBox1.SelectionBackColor = generalColor;

            richTextBox1.Select(cursorPosition, 0);
        }

        private void pushToolStripButton_Click(object sender, EventArgs e)
        {
            Color generalColor = Color.White;
            int cursorPosition = richTextBox1.SelectionStart;
            isConfines = false;
            ClearConf();

            if (watherMark)
                richTextBox2.Text += "❧\n";

            richTextBox1.Select(0, greenPosition);
            richTextBox2.Text += richTextBox1.SelectedText;
            richTextBox2.Text += "\n\n-<||>-\n\n"; // Отделение страниц
            richTextBox1.SelectedText = "";

            isConfines = true;
            Confining();
            richTextBox1.Select(0, 1);
            richTextBox1.SelectionBackColor = generalColor;


            richTextBox1.Select(cursorPosition, 0);
        }

        private void форматированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int searchResult = 0;
            searchResult = richTextBox1.Find("ё");

            while (searchResult != -1)
            {
                richTextBox1.Select(searchResult, 1);
                richTextBox1.SelectedText = "е";
                searchResult = richTextBox1.Find("ё");
                richTextBox1.Select(0, 0);
            }

            searchResult = richTextBox2.Find("ё");

            while (searchResult != -1)
            {
                richTextBox2.Select(searchResult, 1);
                richTextBox2.SelectedText = "е";
                searchResult = richTextBox2.Find("ё");
                richTextBox2.Select(0, 0);
            }
        }

        private void заменитьёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (watherMark)
            {
                watherMark = false;
                заменитьёToolStripMenuItem.Text = "Вотермарка (-)";
            }
            else
            {
                watherMark = true;
                заменитьёToolStripMenuItem.Text = "Вотермарка (+)";
            }
        }

        private void saveTSButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string text = richTextBox2.Text;
                string filename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(filename, text);
            }
        }

        private void loadTSButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string filename = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(filename);
            }
        }
    }
}
