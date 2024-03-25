using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aloo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string encryptedText = EncryptROT13(inputText);
            textBox2.Text = encryptedText;
        }

        private string EncryptROT13(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)(((c - offset + 13) % 26) + offset);
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        
            private void button2_Click(object sender, EventArgs e)
            {
            // TextBox2'deki metni panoya kopyala
            
            Clipboard.SetText(textBox2.Text);
        }

        
            private void button3_Click(object sender, EventArgs e)
            {
                string encryptedText = textBox4.Text;
                string decryptedText = DecryptROT13(encryptedText);
                textBox3.Text = decryptedText;
            }

            private string DecryptROT13(string input)
            {
                string result = "";
                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        result += (char)(((c - offset - 13 + 26) % 26) + offset); // ROT13 tersine işlem
                    }
                    else
                    {
                        result += c;
                    }
                }
                return result;
            }

        
            private void button4_Click(object sender, EventArgs e)
            {
                // Tüm textboxları temizle
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }
    }
    
    
