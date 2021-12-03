namespace CircodeApp
{
    partial class FrmCarro
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
            this.lblAlcool = new System.Windows.Forms.Label();
            this.txtAlcool = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.txtTrecho = new System.Windows.Forms.TextBox();
            this.lblTrecho = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblCombustível = new System.Windows.Forms.Label();
            this.lblGasBest = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(243, 22);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(77, 27);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // lblAlcool
            // 
            this.lblAlcool.AutoSize = true;
            this.lblAlcool.Location = new System.Drawing.Point(26, 22);
            this.lblAlcool.Name = "lblAlcool";
            this.lblAlcool.Size = new System.Drawing.Size(67, 13);
            this.lblAlcool.TabIndex = 1;
            this.lblAlcool.Text = "Preço Alcool";
            // 
            // txtAlcool
            // 
            this.txtAlcool.Location = new System.Drawing.Point(29, 38);
            this.txtAlcool.Name = "txtAlcool";
            this.txtAlcool.Size = new System.Drawing.Size(100, 20);
            this.txtAlcool.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(243, 70);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 27);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Location = new System.Drawing.Point(26, 84);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(79, 13);
            this.lblGasolina.TabIndex = 4;
            this.lblGasolina.Text = "Preço Gasolina";
            // 
            // txtTrecho
            // 
            this.txtTrecho.Location = new System.Drawing.Point(29, 169);
            this.txtTrecho.Name = "txtTrecho";
            this.txtTrecho.Size = new System.Drawing.Size(100, 20);
            this.txtTrecho.TabIndex = 7;
            // 
            // lblTrecho
            // 
            this.lblTrecho.AutoSize = true;
            this.lblTrecho.Location = new System.Drawing.Point(26, 153);
            this.lblTrecho.Name = "lblTrecho";
            this.lblTrecho.Size = new System.Drawing.Size(130, 13);
            this.lblTrecho.TabIndex = 6;
            this.lblTrecho.Text = "Distância a percorrer (KM)";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(29, 234);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 9;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(26, 218);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(127, 13);
            this.lblConsumo.TabIndex = 8;
            this.lblConsumo.Text = "Consumo média por km/lt";
            // 
            // lblCombustível
            // 
            this.lblCombustível.AutoSize = true;
            this.lblCombustível.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustível.Location = new System.Drawing.Point(209, 153);
            this.lblCombustível.Name = "lblCombustível";
            this.lblCombustível.Size = new System.Drawing.Size(74, 15);
            this.lblCombustível.TabIndex = 10;
            this.lblCombustível.Text = "Combustível";
            // 
            // lblGasBest
            // 
            this.lblGasBest.AutoSize = true;
            this.lblGasBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasBest.Location = new System.Drawing.Point(208, 179);
            this.lblGasBest.Name = "lblGasBest";
            this.lblGasBest.Size = new System.Drawing.Size(66, 24);
            this.lblGasBest.TabIndex = 11;
            this.lblGasBest.Text = "label6";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasto.Location = new System.Drawing.Point(209, 218);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(93, 15);
            this.lblGasto.TabIndex = 12;
            this.lblGasto.Text = "Gasto a realizar";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(208, 245);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 24);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "label8";
            // 
            // FrmCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(347, 297);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblGasBest);
            this.Controls.Add(this.lblCombustível);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtTrecho);
            this.Controls.Add(this.lblTrecho);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtAlcool);
            this.Controls.Add(this.lblAlcool);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAlcool;
        private System.Windows.Forms.TextBox txtAlcool;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblGasolina;
        private System.Windows.Forms.TextBox txtTrecho;
        private System.Windows.Forms.Label lblTrecho;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblCombustível;
        private System.Windows.Forms.Label lblGasBest;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Label lblPrice;
    }
}