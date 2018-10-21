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
            Utils.DataGridViewUtils.InitGridForArr(dataGridViewArray, 30, false, true, false, false, false);
            dataGridViewArray.ColumnHeadersVisible = true;

        }

        private void txtNumberOfItems_TextChanged(object sender, EventArgs e)
        {
            // так делать нельзя
            if (txtNumberOfItems.Text != "")
            {
                int n = Convert.ToInt32(txtNumberOfItems.Text);
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
            Array.RandomFill(Convert.ToInt32(txtMinValue.Text), Convert.ToInt32(txtMaxValue.Text));
            ShowArray();
        }

        private void btnRandomFillWithoutRepeats_Click(object sender, EventArgs e)
        {
            Array.RandomFillWithoutRepeat(Convert.ToInt32(txtMinValue.Text), Convert.ToInt32(txtMaxValue.Text));
            ShowArray();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Array != null)
            {
                if (rbtnIncremental.Checked)
                {
                    TestingAlgorithms._search = Search.IncrementalSearch;
                }
                else
                    TestingAlgorithms._search = Search.BinarySearch;
                double res = TestingAlgorithms.TestingSearch(Array.Values);
                txtAnswer.Text += BuildAnswer(res);
            }
        }

        string BuildAnswer(double res)
        {
            StringBuilder answer = new StringBuilder();
            answer.Append('-', 10);
            answer.AppendLine();
            answer.AppendFormat(rbtnBinary.Checked ? "Бинарный поиск" : "Поиск перебором");
            answer.AppendLine();
            answer.AppendFormat(Array.RepeatExist ? "В массиве могут присутствовать повторяющиеся элементы" : "В массиве нет повторяющихся элементов");
            answer.AppendLine();
            answer.AppendFormat("Клоичество элементов массива: ");
            answer.AppendFormat(txtNumberOfItems.Text);
            answer.AppendLine();
            answer.AppendFormat("Среднее число сравнений: ");
            answer.AppendFormat(res.ToString());
            answer.AppendLine();
          //  answer.AppendFormat("Сложность: ");
            answer.AppendLine();
            answer.Append('-', 10);
            answer.AppendLine();
            return answer.ToString();
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
        }
    }
}
