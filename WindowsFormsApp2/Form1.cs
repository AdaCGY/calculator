using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> HistoryList = new List<string>();
        string add = "+";
        string subtract = "-";
        string multiply = "x";
        string divide = "÷";
        string decimalpoint = ".";
        public decimal Result { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonN0_Click(object sender, EventArgs e)
        {
            Input("0");
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            Input("1");
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            Input("2");
        }

        private void buttonN3_Click(object sender, EventArgs e)
        {
            Input("3");
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
            Input("4");
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
            Input("5");
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
            Input("6");
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
            Input("7");
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
            Input("8");
        }

        private void buttonN9_Click(object sender, EventArgs e)
        {
            Input("9");
        }

        private void button加_Click(object sender, EventArgs e)
        {
            Input(add);
        }

        private void button減_Click(object sender, EventArgs e)
        {
            Input(subtract);
        }

        private void button乘_Click(object sender, EventArgs e)
        {
            Input(multiply);
        }

        private void button除_Click(object sender, EventArgs e)
        {
            Input(divide);
        }

        private void button點_Click(object sender, EventArgs e)
        {
            Input(decimalpoint);
        }

        private void button等於_Click(object sender, EventArgs e)
        {
            Input("=");
        }
        public void Input(string input)
        {
            HistoryList.Add(input);
            labelresult.Text += input;
        }
        public void EqualBottonClick()
        {
            string result;
            decimal answer;
            List<string> NumberList = new List<string>();
            List<decimal> Number_List = new List<decimal>();
            List<string> OperatorList = new List<string>();
            foreach (var item in HistoryList) //整理數字和符號
            {
                NumberList.AddRange(labelresult.Text.Split('+', '-', 'x', '÷'));
                OperatorList.AddRange(labelresult.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0'));
            }
            foreach (var item in NumberList) //把數字轉型成decimal
            {
                var b = decimal.TryParse(item, out decimal number);
                if (b==true)
                {
                    Number_List.Add(number);
                }
            }
            while (Number_List.Count > 0) 
             {
                if (OperatorList[0] == add)
                {
                    Result += Number_List[0] + Number_List[1];
                    Number_List.RemoveAt(0);
                    Number_List.RemoveAt(1);
                }
                else if (OperatorList[0] == subtract)
                {
                    Result += Number_List[0] - Number_List[1];
                    Number_List.RemoveAt(0);
                    Number_List.RemoveAt(1);
                }
                else if (OperatorList[0] == multiply) 
                {
                    Result += Number_List[0] * Number_List[1];
                    Number_List.RemoveAt(0);
                    Number_List.RemoveAt(1);
                }
                else if (OperatorList[0] == divide)
                {
                    Result += Number_List[0] / Number_List[1];
                    Number_List.RemoveAt(0);
                    Number_List.RemoveAt(1);
                }
            }
            labelresult.Text = Result.ToString();
        }
        public void DeleteBottonClick()
        {
            HistoryList.Remove(HistoryList.Last());
        }
    }

}
