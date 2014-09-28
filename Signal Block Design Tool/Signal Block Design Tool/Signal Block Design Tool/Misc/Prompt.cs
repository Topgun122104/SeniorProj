using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal_Block_Design_Tool.Misc
{
     class Prompt
     {
               public static string ShowDialog(string text, string caption)
               {
                    Form prompt = new Form();
                    prompt.Width = 500;
                    prompt.Height = 200;
                    prompt.Text = caption;
                    prompt.StartPosition = FormStartPosition.CenterScreen;
                    Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
                    TextBox textBox = new TextBox() { Left = 50, Top = 80, Width = 400 };
                    Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 120 };
                    confirmation.Click += (sender, e) => { prompt.Close(); };
                    prompt.Controls.Add(textBox);
                    prompt.Controls.Add(confirmation);
                    prompt.Controls.Add(textLabel);
                    prompt.AcceptButton = confirmation;
                    prompt.ShowDialog();
                    return textBox.Text;
               }
     }
}
