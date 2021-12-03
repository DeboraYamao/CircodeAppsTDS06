namespace CircodeApp
{
    partial class FrmIMC
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblIMCResult = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblIMCResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(210, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(77, 27);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(21, 22);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(96, 15);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Digite sua altura";
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(24, 38);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(108, 21);
            this.txtaltura.TabIndex = 2;
            this.txtaltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaltura_KeyPress);
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(21, 68);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(92, 15);
            this.lblpeso.TabIndex = 3;
            this.lblpeso.Text = "Digite seu peso";
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(24, 84);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(108, 21);
            this.txtpeso.TabIndex = 3;
            this.txtpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpeso_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(210, 78);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 27);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(32, 159);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(54, 15);
            this.lblIMC.TabIndex = 6;
            this.lblIMC.Text = "Seu IMC";
            // 
            // lblIMCResult
            // 
            this.lblIMCResult.AutoSize = true;
            this.lblIMCResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMCResult.Location = new System.Drawing.Point(31, 183);
            this.lblIMCResult.Name = "lblIMCResult";
            this.lblIMCResult.Size = new System.Drawing.Size(0, 24);
            this.lblIMCResult.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(32, 246);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(63, 15);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // lblIMCResultado
            // 
            this.lblIMCResultado.AutoSize = true;
            this.lblIMCResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMCResultado.Location = new System.Drawing.Point(31, 270);
            this.lblIMCResultado.Name = "lblIMCResultado";
            this.lblIMCResultado.Size = new System.Drawing.Size(0, 24);
            this.lblIMCResultado.TabIndex = 9;
            // 
            // FrmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(318, 339);
            this.Controls.Add(this.lblIMCResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIMCResult);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora do IMC";
            this.Load += new System.EventHandler(this.FrmIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblIMCResult;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblIMCResultado;
    }
}