using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_String_Generator
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (ClearOutput.Checked)
            {
                Output_.Text = "";
            }
            if (UseCharacter.Text.Trim() == "")
            {
                MessageBox.Show("Error: Use character cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (NumberOfString.Value > 0)
                {
                    if (LengthOfString.Value > 0)
                    {
                        Output_.AppendText("=============START: " + DateTime.Now + "=============\r\n");
                        if (StringWidth.Value > 0)
                        {
                            for (var i = 0; i < NumberOfString.Value; i++)
                            {
                                string randomString = "", a, b;
                                {
                                    for (var i_ = 0; i_ < LengthOfString.Value; i_++)
                                    {
                                        randomString += UseCharacter.Text[random.Next(0, UseCharacter.TextLength)];
                                    }
                                    List<string> result = new List<string>(Regex.Split(randomString, @"(?<=\G.{" + StringWidth.Value + "})", RegexOptions.Singleline));
                                    if (UseRegex1.Checked)
                                    {
                                        a = Regex.Unescape(Sepetator.Text).ToString();
                                    }
                                    else
                                    {
                                        a = Sepetator.Text;
                                    }
                                    if (UseRegex2.Checked)
                                    {
                                        b = Regex.Unescape(SurroundingCharString.Text).ToString();
                                    }
                                    else
                                    {
                                        b = SurroundingCharString.Text;
                                    }
                                    for (var i_ = 0; i_ < result.Count - 1; i_++)
                                    {
                                        Output_.AppendText(b + result[i_] + "\r\n" + b + a);
                                    }
                                }
                            }
                        } else
                        {
                            for (var i = 0; i < NumberOfString.Value; i++)
                            {
                                string randomString = "", a, b;
                                {
                                    for (var i_ = 0; i_ < LengthOfString.Value; i_++)
                                    {
                                        randomString += UseCharacter.Text[random.Next(0, UseCharacter.TextLength)];
                                    }
                                    a = Sepetator.Text;
                                    b = SurroundingCharString.Text;
                                    Output_.AppendText(b + randomString + b + a);
                                }
                            }
                        }
                        Output_.AppendText("\r\n=============END: " + DateTime.Now + "=============\r\n");
                    }
                    else
                    {
                        MessageBox.Show("Error: Length of string cannot be under 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Number of string cannot be under 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            save.FilterIndex = 0;
            save.RestoreDirectory = true;
            save.Title = "Save Output";
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, Output_.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Output_.WordWrap = true;
                Output_.ScrollBars = ScrollBars.Vertical;
            } else
            {
                Output_.WordWrap = false;
                Output_.ScrollBars = ScrollBars.Both;
            }
        }
    }
}
