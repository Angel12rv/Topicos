using System.Drawing;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;       

public class CustomButton : Button
{
    private Color originalColor;

    public CustomButton()
    {
        originalColor = this.BackColor;
        this.MouseEnter += OnMouseEnter;
        this.MouseLeave += OnMouseLeave;
        this.Click += OnClick;
    }

    private void OnMouseEnter(object sender, EventArgs e)
    {
        this.BackColor = Color.LightBlue; // Cambia el color al pasar el cursor
    }

    private void OnMouseLeave(object sender, EventArgs e)
    {
        this.BackColor = originalColor; // Restaura el color original
    }

    private void OnClick(object sender, EventArgs e)
    {
        // Muestra un mensaje de confirmación al hacer clic
        DialogResult result = MessageBox.Show(
            "¿Estás seguro de que quieres hacer clic?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            MessageBox.Show("Clic confirmado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}