
namespace calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHistorico.Location = new System.Drawing.Point(12, 12);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.Size = new System.Drawing.Size(258, 26);
            this.txtHistorico.TabIndex = 0;
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtVisor.Location = new System.Drawing.Point(12, 35);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(258, 44);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.Text = "0";
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Image = global::calculadora.Properties.Resources.btn7;
            this.btn7.Location = new System.Drawing.Point(14, 159);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 55);
            this.btn7.TabIndex = 1;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn8
            // 
            this.btn8.Image = global::calculadora.Properties.Resources.btn8;
            this.btn8.Location = new System.Drawing.Point(80, 159);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 55);
            this.btn8.TabIndex = 1;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn9
            // 
            this.btn9.Image = global::calculadora.Properties.Resources.btn9;
            this.btn9.Location = new System.Drawing.Point(146, 159);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 55);
            this.btn9.TabIndex = 1;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn4
            // 
            this.btn4.Image = global::calculadora.Properties.Resources.btn4;
            this.btn4.Location = new System.Drawing.Point(14, 220);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 55);
            this.btn4.TabIndex = 1;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn5
            // 
            this.btn5.Image = global::calculadora.Properties.Resources.btn5;
            this.btn5.Location = new System.Drawing.Point(80, 220);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 55);
            this.btn5.TabIndex = 1;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn6
            // 
            this.btn6.Image = global::calculadora.Properties.Resources.btn6;
            this.btn6.Location = new System.Drawing.Point(146, 220);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 55);
            this.btn6.TabIndex = 1;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn1
            // 
            this.btn1.Image = global::calculadora.Properties.Resources.btn1;
            this.btn1.Location = new System.Drawing.Point(14, 281);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 55);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn2
            // 
            this.btn2.Image = global::calculadora.Properties.Resources.btn2;
            this.btn2.Location = new System.Drawing.Point(80, 281);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 55);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn3
            // 
            this.btn3.Image = global::calculadora.Properties.Resources.btn3;
            this.btn3.Location = new System.Drawing.Point(146, 281);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 55);
            this.btn3.TabIndex = 1;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btn0
            // 
            this.btn0.Image = global::calculadora.Properties.Resources.btn00;
            this.btn0.Location = new System.Drawing.Point(14, 342);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(126, 55);
            this.btn0.TabIndex = 1;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Image = global::calculadora.Properties.Resources.btnVirgula;
            this.btnVirgula.Location = new System.Drawing.Point(146, 342);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(60, 55);
            this.btnVirgula.TabIndex = 1;
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.CliqueBotao_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Image = global::calculadora.Properties.Resources.btnBackspace;
            this.btnBackspace.Location = new System.Drawing.Point(14, 98);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(60, 55);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::calculadora.Properties.Resources.btnLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(80, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 55);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Image = global::calculadora.Properties.Resources.btnAdicao;
            this.btnAdicao.Location = new System.Drawing.Point(146, 98);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(60, 55);
            this.btnAdicao.TabIndex = 1;
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Image = global::calculadora.Properties.Resources.btnSubtracao;
            this.btnSubtracao.Location = new System.Drawing.Point(212, 98);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(60, 55);
            this.btnSubtracao.TabIndex = 1;
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Image = global::calculadora.Properties.Resources.btnMultiplicacao;
            this.btnMultiplicacao.Location = new System.Drawing.Point(212, 159);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(60, 55);
            this.btnMultiplicacao.TabIndex = 1;
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Image = global::calculadora.Properties.Resources.btnDivisao;
            this.btnDivisao.Location = new System.Drawing.Point(212, 220);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(60, 55);
            this.btnDivisao.TabIndex = 1;
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Image = global::calculadora.Properties.Resources.btnIgual;
            this.btnIgual.Location = new System.Drawing.Point(212, 281);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(60, 116);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(288, 418);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.txtHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnIgual;
    }
}

