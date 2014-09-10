namespace ConsumindoWebServiceCalculadora
{
    partial class Form1
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txtValorUm = new System.Windows.Forms.TextBox();
            this.txtValorDois = new System.Windows.Forms.TextBox();
            this.lblValorUm = new System.Windows.Forms.Label();
            this.lblValorDois = new System.Windows.Forms.Label();
            this.radioBtnSoma = new System.Windows.Forms.RadioButton();
            this.radioBtnSubtracao = new System.Windows.Forms.RadioButton();
            this.radioBtnMultiplicacao = new System.Windows.Forms.RadioButton();
            this.radioBtnDivisao = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(66, 159);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(87, 23);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValorUm
            // 
            this.txtValorUm.Location = new System.Drawing.Point(66, 12);
            this.txtValorUm.Name = "txtValorUm";
            this.txtValorUm.Size = new System.Drawing.Size(141, 20);
            this.txtValorUm.TabIndex = 1;
            // 
            // txtValorDois
            // 
            this.txtValorDois.Location = new System.Drawing.Point(66, 38);
            this.txtValorDois.Name = "txtValorDois";
            this.txtValorDois.Size = new System.Drawing.Size(141, 20);
            this.txtValorDois.TabIndex = 2;
            // 
            // lblValorUm
            // 
            this.lblValorUm.AutoSize = true;
            this.lblValorUm.Location = new System.Drawing.Point(7, 15);
            this.lblValorUm.Name = "lblValorUm";
            this.lblValorUm.Size = new System.Drawing.Size(51, 13);
            this.lblValorUm.TabIndex = 3;
            this.lblValorUm.Text = "Valor um:";
            // 
            // lblValorDois
            // 
            this.lblValorDois.AutoSize = true;
            this.lblValorDois.Location = new System.Drawing.Point(7, 41);
            this.lblValorDois.Name = "lblValorDois";
            this.lblValorDois.Size = new System.Drawing.Size(56, 13);
            this.lblValorDois.TabIndex = 4;
            this.lblValorDois.Text = "Valor dois:";
            // 
            // radioBtnSoma
            // 
            this.radioBtnSoma.AutoSize = true;
            this.radioBtnSoma.Checked = true;
            this.radioBtnSoma.Location = new System.Drawing.Point(66, 64);
            this.radioBtnSoma.Name = "radioBtnSoma";
            this.radioBtnSoma.Size = new System.Drawing.Size(52, 17);
            this.radioBtnSoma.TabIndex = 5;
            this.radioBtnSoma.TabStop = true;
            this.radioBtnSoma.Text = "Soma";
            this.radioBtnSoma.UseVisualStyleBackColor = true;
            // 
            // radioBtnSubtracao
            // 
            this.radioBtnSubtracao.AutoSize = true;
            this.radioBtnSubtracao.Location = new System.Drawing.Point(66, 87);
            this.radioBtnSubtracao.Name = "radioBtnSubtracao";
            this.radioBtnSubtracao.Size = new System.Drawing.Size(74, 17);
            this.radioBtnSubtracao.TabIndex = 6;
            this.radioBtnSubtracao.TabStop = true;
            this.radioBtnSubtracao.Text = "Subtração";
            this.radioBtnSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioBtnMultiplicacao
            // 
            this.radioBtnMultiplicacao.AutoSize = true;
            this.radioBtnMultiplicacao.Location = new System.Drawing.Point(66, 110);
            this.radioBtnMultiplicacao.Name = "radioBtnMultiplicacao";
            this.radioBtnMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.radioBtnMultiplicacao.TabIndex = 7;
            this.radioBtnMultiplicacao.TabStop = true;
            this.radioBtnMultiplicacao.Text = "Multiplicação";
            this.radioBtnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radioBtnDivisao
            // 
            this.radioBtnDivisao.AutoSize = true;
            this.radioBtnDivisao.Location = new System.Drawing.Point(66, 133);
            this.radioBtnDivisao.Name = "radioBtnDivisao";
            this.radioBtnDivisao.Size = new System.Drawing.Size(60, 17);
            this.radioBtnDivisao.TabIndex = 8;
            this.radioBtnDivisao.TabStop = true;
            this.radioBtnDivisao.Text = "Divisão";
            this.radioBtnDivisao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 204);
            this.Controls.Add(this.radioBtnDivisao);
            this.Controls.Add(this.radioBtnMultiplicacao);
            this.Controls.Add(this.radioBtnSubtracao);
            this.Controls.Add(this.radioBtnSoma);
            this.Controls.Add(this.lblValorDois);
            this.Controls.Add(this.lblValorUm);
            this.Controls.Add(this.txtValorDois);
            this.Controls.Add(this.txtValorUm);
            this.Controls.Add(this.btnExecutar);
            this.Name = "Form1";
            this.Text = "WebService Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtValorUm;
        private System.Windows.Forms.TextBox txtValorDois;
        private System.Windows.Forms.Label lblValorUm;
        private System.Windows.Forms.Label lblValorDois;
        private System.Windows.Forms.RadioButton radioBtnSoma;
        private System.Windows.Forms.RadioButton radioBtnSubtracao;
        private System.Windows.Forms.RadioButton radioBtnMultiplicacao;
        private System.Windows.Forms.RadioButton radioBtnDivisao;
    }
}

