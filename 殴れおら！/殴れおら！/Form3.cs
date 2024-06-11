using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 殴れおら_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            label3.Text =
                string.Empty;
            label4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox1.Text, out int value))
                {
                    // 30以上なら30と表示、そうでなければそのまま表示
                    if (value >= 30)
                    {
                        label4.Text = "30";
                    }
                    else
                    {
                        label4.Text = value.ToString();
                    }
                }
                else
                {
                    // 数値に変換できなかった場合のエラーメッセージ
                    label4.Text = "無効な入力です";
                }
                // テキストボックスの値を取得し、数値に変換

                if (int.TryParse(textBox1.Text, out int value2))

                {

                    // 30を引いた値を計算

                    int result = value2 - 30;

                    // ラベルに結果を表示

                    label3.Text = result.ToString();

                }

                else

                {

                    // 数値に変換できなかった場合のエラーメッセージ

                    label3.Text = "無効な入力です";

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
