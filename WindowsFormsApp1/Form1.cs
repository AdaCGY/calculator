﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, ICalculator, ICaluValidation
    {
        List<string> NumberList = new List<string>();
        List<string>HistoryList = new List<string>();

        public event EventHandler 加;
        public event EventHandler 減;
        public event EventHandler 乘;
        public event EventHandler 除;
        public event EventHandler 等於;
        public event EventHandler 小數點;
        public event EventHandler 未歸零;
        public event EventHandler 刪除;

        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public decimal Result { get; set; }
        string add = "+";
        string subtract = "-";
        string multiply = "x";
        string divide = "÷";

        public Form1()
        {
            InitializeComponent();
            labelresult.Text = string.Empty;
        }

        private void buttonN0_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("0");
            labelresult.Text += "0";
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("1");
            labelresult.Text += "1";
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("2");
            labelresult.Text += "2";
        }

        private void buttonN3_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("3");
            labelresult.Text += "3";
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("4");
            labelresult.Text += "4";
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("5");
            labelresult.Text += "5";
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("6");
            labelresult.Text += "6";
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("7");
            labelresult.Text += "7";
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("8");
            labelresult.Text += "8";
        }

        private void buttonN9_Click(object sender, EventArgs e)
        {
            Check_Reset_NotReturnToZero_ForNumber();
            NumberList.Add("9");
            labelresult.Text += "9";
        }

        private void button加_Click(object sender, EventArgs e)
        {
            LengthValidation("沒有東西可以算，請先輸入數字");
            if (Check_Reset_NotReturnToZero_ForOperationButton() == false )
            {
                加 += button加_Click;
                未歸零 += button加_Click;
            }
            if(NumberList.Count == 0 && 未歸零 == null)
            {
                return;
            }
            未歸零 -= button加_Click;
            小數點 -= button點_Click;
            if (減 != null || 乘 != null || 除 != null)
            {
                if (減 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Subtract(Number1, Number2);
                }
                if (乘 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Multiply(Number1, Number2);
                }
                if (除 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Divide(Number1, Number2);
                }
            }

            if (加 != null)
            {
                Number2 = GetNumber();
                Number1 = Add(Number1, Number2);
                labelresult.Text +=add;
            }


            if (加 == null)
            {
                加 += button加_Click;
                if (減 == null && 乘 == null && 除 == null)
                {
                    Number1 = GetNumber();
                    labelresult.Text +=add;
                }
                if (減 != null || 乘 != null || 除 != null)
                {
                    減 -= button減_Click;
                    乘 -= button乘_Click;
                    除 -= button除_Click;
                    labelresult.Text +=add;
                }
            }
        }

        private void button減_Click(object sender, EventArgs e)
        {
            LengthValidation("沒有東西可以算，請先輸入數字");
            if (Check_Reset_NotReturnToZero_ForOperationButton() == false)
            {
                減 += button減_Click;
                未歸零 += button減_Click;
            }
            if (NumberList.Count == 0 && 未歸零 == null)
            {
                return;
            }
            未歸零 -= button減_Click;
            小數點 -= button點_Click;
            if (加 != null || 乘 != null || 除 != null) //先檢查前面是否有其他運算未結束，檢查後再來看減號(此按鈕主功能)部分
            {
                if (加 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Add(Number1, Number2);
                }
                if (乘 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Multiply(Number1, Number2);
                }
                if (除 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Divide(Number1, Number2);
                }
            }

            if (減 != null) //再檢查減號是否使用一次以上
            {
                Number2 = GetNumber();
                Number1 = Subtract(Number1, Number2);
                labelresult.Text += subtract;
            }

            //前面先檢查是否有其他運算(含加減乘除)

            if (減 == null)
            {
                if (加 == null && 乘 == null && 除 == null)
                {
                    減 += button減_Click;
                    Number1 = GetNumber();
                    labelresult.Text += subtract;
                }
                if (加 != null || 乘 != null || 除 != null)
                {
                    減 += button減_Click;
                    加 -= button加_Click;
                    乘 -= button乘_Click;
                    除 -= button除_Click;
                    labelresult.Text += subtract;
                }
            
            }
    }

        private void button乘_Click(object sender, EventArgs e)
        {
            LengthValidation("沒有東西可以算，請先輸入數字");
            if (Check_Reset_NotReturnToZero_ForOperationButton() == false)
            {
                乘 += button乘_Click;
                未歸零 += button乘_Click;
            }
            if (NumberList.Count == 0 && 未歸零 == null)
            {
                return;
            }
            未歸零 -= button乘_Click;
            小數點 -= button點_Click;
            if (減 != null || 加 != null || 除 != null)
            {
                if (減 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Subtract(Number1, Number2);
                }
                if (加 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Add(Number1, Number2);
                }
                if (除 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Divide(Number1, Number2);
                }
            }

            if (乘 != null)
            {
                Number2 = GetNumber();
                Number1 = Multiply(Number1, Number2);
                labelresult.Text +=multiply;
            }


            if (乘 == null)
            {
                乘 += button乘_Click;
                if (減 == null && 加 == null && 除 == null)
                {
                    Number1 = GetNumber();
                    labelresult.Text +=multiply;
                }
                if (減 != null || 加 != null || 除 != null)
                {
                    減 -= button減_Click;
                    加 -= button加_Click;
                    除 -= button除_Click;
                    labelresult.Text +=multiply;
                }
            }
        }

        private void button除_Click(object sender, EventArgs e)
        {
            LengthValidation("沒有東西可以算，請先輸入數字");
            if (Check_Reset_NotReturnToZero_ForOperationButton() == false)
            {
                除 += button除_Click;
                未歸零 += button除_Click;
            }
            if (NumberList.Count == 0 && 未歸零 == null)
            {
                return;
            }
            未歸零 -= button除_Click;
            小數點 -= button點_Click;
            if (減 != null || 乘 != null || 加 != null)
            {
                if (減 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Subtract(Number1, Number2);
                }
                if (乘 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Multiply(Number1, Number2);
                }
                if (加 != null)
                {
                    Number2 = GetNumber();
                    Number1 = Add(Number1, Number2);
                }
            }

            if (除 != null)
            {
                Number2 = GetNumber();
                Number1 = Divide(Number1, Number2);
                labelresult.Text +=divide;
            }


            if (除 == null)
            {
                除 += button除_Click;
                if (減 == null && 乘 == null && 加 == null)
                {
                    Number1 = GetNumber();
                    labelresult.Text +=divide;
                }
                if (減 != null || 乘 != null || 加 != null)
                {
                    減 -= button減_Click;
                    乘 -= button乘_Click;
                    加 -= button加_Click;
                    labelresult.Text +=divide;
                }
            }
        }

        private void button等於_Click(object sender, EventArgs e) 
        {
            LengthValidation("沒有東西可以算，請先輸入數字");

            if ((加 == null && 減 == null && 乘 == null && 除 == null))
            {
                throw new Exception("沒有東西可以算，請輸入計算");
            }
            if (NumberList.Count == 0)
            {
                return;
            }
            小數點 -= button點_Click;
            等於 += button等於_Click;
            Number2 = GetNumber();
            labelresult.Text += " = ";
            if (加 != null)
            {
                Result = Add(Number1, Number2);
            }
            if (減 != null)
            {
                Result = Subtract(Number1, Number2);
            }
            if (乘 != null)
            {
                Result = Multiply(Number1, Number2);
            }
            if (除 != null)
            {
                Result = Divide(Number1, Number2);
            }
            labelresult.Text += Result.ToString();
            richTextBox紀錄.Text += labelresult.Text + "\n";
            labelresult.Text = Result.ToString();
        }
        private void button點_Click(object sender, EventArgs e)
        {
            LengthValidation("請先輸入數字");
            if (NumberList.Count == 0)
            {
                return;
            }
            if (小數點 == null)
            {
                小數點 += button點_Click;
                NumberList.Add(".");
                labelresult.Text += ".";
            }
        }

        //要可以刪除數字、功能鍵
        private void buttondelete_Click(object sender, EventArgs e) //-------------------------------- 此功能尚有許多bug(刪除小數點、刪除功能鍵)
        {
            LengthValidation("請輸入數字，現在沒有數字可以刪除");
            if (等於 != null) 
            {
                return;
            }
            //重置現有資料並根據刪除後留下的數字和符號去做運算
            /*var number_end = NumberList.LastOrDefault();
            NumberList.Remove(number_end);
            var str = labelresult.Text.Length;
            labelresult.Text = labelresult.Text.Substring(0, str - 1);*/
            //先將留下的字全部整理，使用功能鍵區分數字，把數字加入numberlist，接著根據功能鍵去做相應的運算
            NumberList.Clear();
            var str = labelresult.Text.Length;
            labelresult.Text = labelresult.Text.Substring(0, str - 1);
            string[] newResult = labelresult.Text.Split(new char[4] {'+', '-', 'x', '÷' },StringSplitOptions.RemoveEmptyEntries);
            foreach(string newNumber in newResult)
            {
                NumberList.Add(newNumber); //重新整理現有數字
            }
            List<string> newOperationResult = new List<string>();
            string[] newResult2 = labelresult.Text.Split(new char[10] { '1', '2', '3', '4' , '5', '6', '7', '8','9','0' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string newOperation in newResult2)
            {
                newOperationResult.Add(newOperation); //重新整理現有功能鍵
            }
            
        }


        private void buttonAC_Click(object sender, EventArgs e)
        {
            NumberList.Clear();
            labelresult.Text = string.Empty;
            加 -= button加_Click;
            減 -= button減_Click;
            乘 -= button乘_Click;
            除 -= button除_Click;
            等於 -= button等於_Click;
        }

        public decimal GetNumber()
        {
            string n = string.Empty;
            foreach (string s in NumberList) {
                n += s;
            }
            bool issuccess = decimal.TryParse(n, out decimal number);
            NumberList.Clear();
            return number;

        }

        public decimal Add(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public decimal Subtract(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        public decimal Multiply(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public decimal Divide(decimal n1, decimal n2)
        {
            return n1 / n2;
        }

        public void Reset()
        {
            NumberList.Clear();
            labelresult.Text = string.Empty;
            加 -= button加_Click;
            減 -= button減_Click;
            乘 -= button乘_Click;
            除 -= button除_Click;
            等於 -= button等於_Click;
        }
        /// <summary>
        /// 上輪計算未歸零情況下點擊數字鍵 >> 會以當前顯示之數字繼續運算
        /// </summary>
        private void Check_Reset_NotReturnToZero_ForNumber()
        {
            if (等於 == null)
            {
                return;
            }
            if (等於 != null)
            {
                MessageBox.Show("請注意，您尚未歸零");
                NumberList.Clear();
                NumberList.Add(labelresult.Text);
                加 -= button加_Click;
                減 -= button減_Click;
                乘 -= button乘_Click;
                除 -= button除_Click;
                等於 -= button等於_Click;
            }
        }
        /// <summary>
        /// 上輪計算未歸零情況下點擊功能鍵 >> 確保可以繼續運算
        /// </summary>
        private bool Check_Reset_NotReturnToZero_ForOperationButton() //尚未歸零的情況下點擊功能鍵，應將現有數字視為Number1
        {
            if(等於 == null)
            {
                return true; //有歸零
            }
            if (等於 != null)
            {
                MessageBox.Show("請注意，您尚未歸零");
                NumberList.Clear();
                NumberList.Add(labelresult.Text);
                Number1 = GetNumber();
                加 -= button加_Click;
                減 -= button減_Click;
                乘 -= button乘_Click;
                除 -= button除_Click;
                等於 -= button等於_Click;
            }
            return false;//沒有歸零
        }
        /// <summary>
        /// 檢查目前計算之字串長度，確保沒有數字輸入的情況下不會開始計算
        /// </summary>
        /// <param name="message">當前錯誤提示訊息</param>
        /// <exception cref="Exception"></exception>
        public void LengthValidation(string message)
        {
            if (labelresult.Text.Length == 0)
            {
                throw new Exception(message);
            }
        }
    } 
    
    interface ICaluValidation
    {
        void LengthValidation(string message);

    }
}
