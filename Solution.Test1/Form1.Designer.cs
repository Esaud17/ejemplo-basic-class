
namespace Solution.Test1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelIsPrimo = new System.Windows.Forms.Label();
            this.labelIsParOrImpar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Location = new System.Drawing.Point(12, 12);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(173, 20);
            this.TextBoxNumber.TabIndex = 0;
            this.TextBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumber_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelIsParOrImpar);
            this.groupBox1.Controls.Add(this.LabelIsPrimo);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // LabelIsPrimo
            // 
            this.LabelIsPrimo.AutoSize = true;
            this.LabelIsPrimo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelIsPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIsPrimo.Location = new System.Drawing.Point(103, 27);
            this.LabelIsPrimo.Name = "LabelIsPrimo";
            this.LabelIsPrimo.Size = new System.Drawing.Size(51, 20);
            this.LabelIsPrimo.TabIndex = 1;
            this.LabelIsPrimo.Text = "label2";
            this.LabelIsPrimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIsParOrImpar
            // 
            this.labelIsParOrImpar.AutoSize = true;
            this.labelIsParOrImpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelIsParOrImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsParOrImpar.Location = new System.Drawing.Point(103, 61);
            this.labelIsParOrImpar.Name = "labelIsParOrImpar";
            this.labelIsParOrImpar.Size = new System.Drawing.Size(51, 20);
            this.labelIsParOrImpar.TabIndex = 2;
            this.labelIsParOrImpar.Text = "label1";
            this.labelIsParOrImpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Es numero primo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 147);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxNumber);
            this.Name = "Form1";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIsParOrImpar;
        private System.Windows.Forms.Label LabelIsPrimo;
    }
}

