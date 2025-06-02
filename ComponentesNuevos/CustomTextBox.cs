using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomTextBox : TextBox
{
    public CustomTextBox()
    {
        this.TextChanged += OnTextChanged;
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
        bool containsLetters = false;

        foreach (char c in this.Text)
        {
            if (char.IsLetter(c))
            {
                containsLetters = true;
                break;
            }
        }

        this.BackColor = containsLetters ? Color.LightPink : SystemColors.Window;
    }
}