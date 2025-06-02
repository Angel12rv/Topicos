namespace pruebacomponentes
{
    partial class FormularioPrueba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customButton1 = new CustomButton();
            this.customTextBox1 = new CustomTextBox();
            this.btnValidarRFC = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(134, 62);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(160, 87);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "BotonPersonalizado";
            this.customButton1.UseVisualStyleBackColor = true;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.Location = new System.Drawing.Point(372, 107);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(184, 22);
            this.customTextBox1.TabIndex = 1;
            this.customTextBox1.TextChanged += new System.EventHandler(this.customTextBox1_TextChanged);
            // 
            // btnValidarRFC
            // 
            this.btnValidarRFC.Location = new System.Drawing.Point(288, 289);
            this.btnValidarRFC.Name = "btnValidarRFC";
            this.btnValidarRFC.Size = new System.Drawing.Size(75, 23);
            this.btnValidarRFC.TabIndex = 2;
            this.btnValidarRFC.Text = "RFC";
            this.btnValidarRFC.UseVisualStyleBackColor = true;
            this.btnValidarRFC.Click += new System.EventHandler(this.btnValidarRFC_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(250, 327);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(246, 251);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(164, 22);
            this.txtRFC.TabIndex = 4;
            // 
            // FormularioPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidarRFC);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customButton1);
            this.Name = "FormularioPrueba";
            this.Text = "FormularioPrueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton customButton1;
        private CustomTextBox customTextBox1;
        private System.Windows.Forms.Button btnValidarRFC;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtRFC;
    }
}