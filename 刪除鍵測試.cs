using System;
using System.Collections;
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
        Stack<Dictionary<string, string>> HistoryStack = new Stack<Dictionary<string, string>>();

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
            if (NumberList.Count == 0 && 未歸零 == null && 刪除 == null)
            {
                return;
            }
            刪除 -= buttondelete_Click;
            未歸零 -= button加_Click;
            小數點 -= button點_Click;
            if (減 != null || 乘 != null || 除 != null)
            {
                if (減 != null)
                {
                    HistoryStack.Push(GetHistory(subtract));
                    Number2 = GetNumber();
                    Number1 = Subtract(Number1, Number2);
                }
                if (乘 != null)
                {
                    HistoryStack.Push(GetHistory(multiply));
                    Number2 = GetNumber();
                    Number1 = Multiply(Number1, Number2);
                }
                if (除 != null)
                {
                    HistoryStack.Push(GetHistory(divide));
                    Number2 = GetNumber();
                    Number1 = Divide(Number1, Number2);
                }
            }

            if (加 != null)
            {
                HistoryStack.Push(GetHistory(add));
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
            if (NumberList.Count == 0 && 未歸零 == null && 刪除 == null)
            {
                return;
            }
            刪除 -= buttondelete_Click;
            未歸零 -= button加_Click;
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
            if (NumberList.Count == 0 && 未歸零 == null && 刪除==null)
            {
                return;
            }
            刪除 -= buttondelete_Click;
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
            if (NumberList.Count == 0 && 未歸零 == null && 刪除 == null)
            {
                return;
            }
            刪除 -= buttondelete_Click;
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

            if (除 == null )
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
            if (刪除 != null)
            {
                Result = Number1;
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
        private void buttondelete_Click(object sender, EventArgs e) //-------------------------------- 此功能尚有bug(刪除小數點、刪除功能鍵)
        {
            LengthValidation("請輸入數字，現在沒有數字可以刪除");
            if (等於 != null) 
            {
                return;
            }

            if (加 == null && 減 == null && 乘 == null && 除 == null &&刪除==null)
            {
                var number_end = NumberList.LastOrDefault();
                NumberList.Remove(number_end);
                var str = labelresult.Text.Length;
                labelresult.Text = labelresult.Text.Substring(0, str - 1);
            }

            if (加 != null || 減 != null || 乘 != null || 除 != null) 
            {
                if (NumberList.Count != 0) //先檢查numberlist裡面是否還有
                {
                    //將刪除數字從list中移除
                    var number_end = NumberList.LastOrDefault();
                    NumberList.Remove(number_end);
                    var str = labelresult.Text.Length;
                    labelresult.Text = labelresult.Text.Substring(0, str - 1);
                }
                if (NumberList.Count == 0) //先檢查numberlist裡面是否還有
                {
                    //numberlist清空之後，會出現兩種情況1.結尾是功能鍵//(刪除後將失去最後訂閱選項>>"等於"須修正)2.結尾是數字
                    //當前結尾為運算符號
                    if (labelresult.Text.ToCharArray().Select(c => c.ToString()).ToList().Last() == add || labelresult.Text.ToCharArray().Select(c => c.ToString()).ToList().Last() == subtract
                    || labelresult.Text.ToCharArray().Select(c => c.ToString()).ToList().Last() == multiply || labelresult.Text.ToCharArray().Select(c => c.ToString()).ToList().Last() == divide)
                    {
                        刪除 += buttondelete_Click;
                        switch ((labelresult.Text.ToCharArray().Select(c => c.ToString()).ToList().Last()))
                        {
                            case "+":
                                加 -= button加_Click;
                                break;
                            case "-":
                                減 -= button減_Click;
                                break;
                            case "*":
                                乘 -= button乘_Click;
                                break;
                            case "÷":
                                除 -= button除_Click;
                                break;
                        }
                        var str = labelresult.Text.Length;
                        labelresult.Text = labelresult.Text.Substring(0, str - 1);
                    }
                }
            }
            if (加 == null && 減 == null && 乘 == null && 除 == null && 刪除 != null)//沒有訂閱項目:1.numberlist還有值 2.numberlist沒有值
            {
                var topElement = HistoryStack.Peek();
                if (NumberList.Count == 0)
                {
                    //目前失去最後訂閱事件 number1應先還原，再根據後面數字與符號再次計算存回number1
                    foreach (string n in topElement.Values.First().ToCharArray().Select(c => c.ToString()).ToList())
                    {
                        NumberList.Add(n);
                    }
                    //先還原Number1
                    var preNumber = GetNumber_FroDelete();
                    if (topElement.Keys.First() == add)
                    {
                        Number1 -= preNumber;
                    }
                    else if (topElement.Keys.First() == subtract)
                    {
                        Number1 += preNumber;
                    }
                    else if (topElement.Keys.First() == multiply)
                    {
                        Number1 /= preNumber;
                    }
                    else if (topElement.Keys.First() == divide)
                    {
                        Number1 *= preNumber;
                    }
                }
                if (NumberList.Count != 0) 
                {
                    //將刪除數字從list中移除
                    var number_end = NumberList.LastOrDefault();
                    NumberList.Remove(number_end);
                    //根據刪除後的新數字還原number1
                    var reNewNumber = GetNumber_FroDelete();
                    if (topElement.Keys.First() == add)
                    {
                        Number1 = Add(Number1, reNewNumber);
                    }
                    else if (topElement.Keys.First() == subtract)
                    {
                        Number1 = Subtract(Number1, reNewNumber);
                    }
                    else if (topElement.Keys.First() == multiply)
                    {
                        Number1 = Multiply(Number1, reNewNumber);
                    }
                    else if (topElement.Keys.First() == divide)
                    {
                        Number1 = Divide(Number1, reNewNumber);
                    }
                }

                //將刪除數字從labelresult移除
                var str = labelresult.Text.Length;
                labelresult.Text = labelresult.Text.Substring(0, str - 1);

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
        public decimal GetNumber_FroDelete()
        {
            string n = string.Empty;
            foreach (string s in NumberList)
            {
                n += s;
            }
            bool issuccess = decimal.TryParse(n, out decimal number);
            return number;
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

        }/// <summary>
        /// 將數字以及其對應運算符號打包儲存(運算符號在前，數字在後)
        /// </summary>
        /// <param name="Operation"></param>
        /// <returns></returns>
        public Dictionary<string,string> GetHistory(string Operation) 
        {
            var history = new Dictionary<string,string>();
            string n = string.Empty;
            foreach (string s in NumberList)
            {
                n += s;
            }
            history.Add(Operation,n);
            return history;
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
            刪除 -= buttondelete_Click;
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
                刪除 -= buttondelete_Click;
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
                刪除 -= buttondelete_Click;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 
    
   
}
