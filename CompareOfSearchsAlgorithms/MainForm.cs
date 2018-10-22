using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;

namespace CompareOfSearchsAlgorithms
{
    public partial class MainForm : Form
    {
        ArrayInt Array;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Height = 800;
            this.Width = 1800;
            Point p = new Point(0,0);
            this.Location=p;

            Utils.DataGridViewUtils.InitGridForArr(dataGridViewArray, 30, true, true, false, false, false);
            dataGridViewArray.ColumnHeadersVisible = true;
            CreateArray();
        }

        private void txtNumberOfItems_TextChanged(object sender, EventArgs e)
        {
            CreateArray();
        }
        
        void CreateArray()
        {
            int number;
            if (int.TryParse(txtNumberOfItems.Text, out number)&& number>0)
            {
                int n = number;
                dataGridViewArray.RowCount = n;
                Array = new ArrayInt(n);
                ShowArray();
            }
        }
        void ShowArray()
        {
            dataGridViewArray.RowCount = Array.Length;
            for (int i = 0; i < Array.Length; i++)
                dataGridViewArray[0, i].Value = Array.Values[i];
        }

        private void btnFillFandom_Click(object sender, EventArgs e)
        {
            int min, max;
            if (int.TryParse(txtMinValue.Text, out min) && (int.TryParse(txtMaxValue.Text, out max))&&(min<=max))
            {
                Array.RandomFill(Convert.ToInt32(txtMinValue.Text), Convert.ToInt32(txtMaxValue.Text));
                ShowArray();
            }
        }

        private void btnRandomFillWithoutRepeats_Click(object sender, EventArgs e)
        {
            int min, max;
            if (int.TryParse(txtMinValue.Text, out min) && (int.TryParse(txtMaxValue.Text, out max)) && (min <= max))
            {
                Array.RandomFillWithoutRepeat(Convert.ToInt32(txtMinValue.Text), Convert.ToInt32(txtMaxValue.Text));
                ShowArray();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtNumberOfItems.Text != "")
            {
                if (rbtnIncremental.Checked)
                    TestingAlgorithms._search = Search.IncrementalSearch;
                else
                    TestingAlgorithms._search = Search.BinarySearch;
                double countOfCompare = TestingAlgorithms.TestingSearch(Array.Values);
                txtAnswer.Text += BuildAnswerStatistic(countOfCompare);
            }
        }

        string BuildAnswerStatistic(double countOfCompare)
        {
            StringBuilder answer = new StringBuilder();
            answer.Append('-', 10);
            answer.AppendLine();
            answer.AppendFormat(rbtnBinary.Checked ? "Бинарный поиск" : "Поиск перебором");
            answer.AppendLine();
            answer.AppendFormat(Array.RepeatExist ? "В массиве могут присутствовать повторяющиеся элементы" : "В массиве нет повторяющихся элементов");
            answer.AppendLine();
            answer.AppendFormat("Элемент, который ищется гарантированно присутствует в массиве");
            answer.AppendLine();
            answer.AppendFormat("Количество элементов массива: ");
            answer.AppendFormat(txtNumberOfItems.Text);
            answer.AppendLine();
            answer.AppendFormat("Среднее число сравнений: ");
            answer.AppendFormat(countOfCompare.ToString());
            answer.AppendLine();
            answer.AppendFormat("Сложность: ");
            answer.AppendFormat((countOfCompare / Convert.ToDouble(txtNumberOfItems.Text)).ToString());
            answer.AppendLine();
            answer.Append('-', 10);
            answer.AppendLine();
            return answer.ToString();
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
        }

        private void btnStartFindOne_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtItemForSearch.Text, out value))
            {
                int countOfCompare, index;
                if (rbtnIncremental.Checked)
                    index = Search.IncrementalSearch(Array.Values, value,out countOfCompare);
                else
                    index = Search.BinarySearch(Array.Values, value,out countOfCompare);

                txtAnswer.Text += BuildAnswerOneFind(countOfCompare, index);
            }
        }

        string BuildAnswerOneFind(int countOfCompare, int index)
        {
            StringBuilder answer = new StringBuilder();
            answer.Append('-', 10);
            answer.AppendLine();
            answer.AppendFormat(rbtnBinary.Checked ? "Бинарный поиск" : "Поиск перебором");
            answer.AppendLine();
            answer.AppendFormat("Количество элементов массива: ");
            answer.AppendFormat(txtNumberOfItems.Text);
            answer.AppendLine();
            answer.AppendFormat("Элемент для поиска : ");
            answer.AppendFormat(txtItemForSearch.Text);
            answer.AppendLine();
            answer.AppendFormat("Индекс элемента в массиве: ");
            answer.AppendFormat(index.ToString());
            answer.AppendLine();
            answer.AppendFormat("Число сравнений: ");
            answer.AppendFormat(countOfCompare.ToString());
            answer.AppendLine();
            answer.AppendLine();
            answer.Append('-', 10);
            answer.AppendLine();
            return answer.ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort();
            ShowArray();
        }
    }
}
