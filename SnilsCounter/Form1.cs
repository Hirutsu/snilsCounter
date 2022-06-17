using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnilsCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkSnilsBtn_Click(object sender, EventArgs e)
        {
            string s = snilsTB.Text;
            Regex regex = new Regex(@"^\d{3}-\d{3}-\d{3} \d{2}$");
            MatchCollection matches = regex.Matches(s);
            List<string> digitsStr;
            List<int> digits = new List<int>();
            if (matches.Count > 0)
            {
                digitsStr = s.Split('-',' ').ToList();
                for (int i = 0; i < digitsStr.Count - 1; i++)
                {
                    for (int j = 0; j < digitsStr[i].Length; j++)
                    {
                        digits.Add(Convert.ToInt32(digitsStr[i][j]-48));
                    }
                }

                int count = 0;

                for (int i = 0; i < digits.Count; i++)
                {
                    count += digits[i] * (digits.Count - i);
                }

                int crnNum = Convert.ToInt32(digitsStr[digitsStr.Count - 1]);

                if (count < 100 && count != crnNum)
                {
                    MessageBox.Show("Контрольное число должно быть " + count.ToString());
                }
                else if(count < 100)
                {
                    MessageBox.Show("Контрольное число " + count.ToString() + " - указано верно");
                }

                if (count == 100 && count == 101)
                {
                    MessageBox.Show("Контрольное число должно быть - 00");
                }

                if (count > 101)
                {
                    MessageBox.Show("Контрольное число должно быть - 01");
                }

            }
            else
            {
                MessageBox.Show("Снилс неправильного формата, введите еще раз");
            }
        }
    }
}
