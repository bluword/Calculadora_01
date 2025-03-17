namespace Calculadora_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntUm = new Button();
            bntDois = new Button();
            bntTres = new Button();
            bntQuatro = new Button();
            bntCinco = new Button();
            bntSeis = new Button();
            bntSete = new Button();
            bntOito = new Button();
            bntNove = new Button();
            bntZero = new Button();
            bntIgual = new Button();
            bntAdicao = new Button();
            bntSubtracao = new Button();
            bntMultiplicacao = new Button();
            bntDivisao = new Button();
            bntC = new Button();
            bntVirgula = new Button();
            textResultado = new TextBox();
            SuspendLayout();
            // 
            // bntUm
            // 
            bntUm.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntUm.Location = new Point(14, 89);
            bntUm.Name = "bntUm";
            bntUm.Size = new Size(76, 49);
            bntUm.TabIndex = 0;
            bntUm.Text = "1";
            bntUm.UseVisualStyleBackColor = true;
            bntUm.Click += bntUm_Click;
            // 
            // bntDois
            // 
            bntDois.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntDois.Location = new Point(95, 89);
            bntDois.Name = "bntDois";
            bntDois.Size = new Size(76, 49);
            bntDois.TabIndex = 1;
            bntDois.Text = "2";
            bntDois.UseVisualStyleBackColor = true;
            bntDois.Click += bntDois_Click;
            // 
            // bntTres
            // 
            bntTres.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntTres.Location = new Point(176, 89);
            bntTres.Name = "bntTres";
            bntTres.Size = new Size(76, 49);
            bntTres.TabIndex = 2;
            bntTres.Text = "3";
            bntTres.UseVisualStyleBackColor = true;
            bntTres.Click += bntTres_Click;
            // 
            // bntQuatro
            // 
            bntQuatro.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntQuatro.Location = new Point(14, 144);
            bntQuatro.Name = "bntQuatro";
            bntQuatro.Size = new Size(76, 48);
            bntQuatro.TabIndex = 3;
            bntQuatro.Text = "4";
            bntQuatro.UseVisualStyleBackColor = true;
            bntQuatro.Click += bntQuatro_Click;
            // 
            // bntCinco
            // 
            bntCinco.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntCinco.Location = new Point(96, 144);
            bntCinco.Name = "bntCinco";
            bntCinco.Size = new Size(76, 48);
            bntCinco.TabIndex = 4;
            bntCinco.Text = "5";
            bntCinco.UseVisualStyleBackColor = true;
            bntCinco.Click += button5_Click;
            // 
            // bntSeis
            // 
            bntSeis.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSeis.Location = new Point(176, 144);
            bntSeis.Name = "bntSeis";
            bntSeis.Size = new Size(76, 48);
            bntSeis.TabIndex = 5;
            bntSeis.Text = "6";
            bntSeis.UseVisualStyleBackColor = true;
            bntSeis.Click += bntSeis_Click;
            // 
            // bntSete
            // 
            bntSete.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntSete.Location = new Point(14, 198);
            bntSete.Name = "bntSete";
            bntSete.Size = new Size(76, 43);
            bntSete.TabIndex = 6;
            bntSete.Text = "7";
            bntSete.UseVisualStyleBackColor = true;
            bntSete.Click += bntSete_Click;
            // 
            // bntOito
            // 
            bntOito.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntOito.Location = new Point(95, 198);
            bntOito.Name = "bntOito";
            bntOito.Size = new Size(76, 43);
            bntOito.TabIndex = 7;
            bntOito.Text = "8";
            bntOito.UseVisualStyleBackColor = true;
            bntOito.Click += bntOito_Click;
            // 
            // bntNove
            // 
            bntNove.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntNove.Location = new Point(176, 198);
            bntNove.Name = "bntNove";
            bntNove.Size = new Size(76, 43);
            bntNove.TabIndex = 8;
            bntNove.Text = "9";
            bntNove.UseVisualStyleBackColor = true;
            bntNove.Click += bntNove_Click;
            // 
            // bntZero
            // 
            bntZero.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntZero.Location = new Point(95, 247);
            bntZero.Name = "bntZero";
            bntZero.Size = new Size(76, 49);
            bntZero.TabIndex = 9;
            bntZero.Text = "0";
            bntZero.UseVisualStyleBackColor = true;
            bntZero.Click += bntZero_Click;
            // 
            // bntIgual
            // 
            bntIgual.Location = new Point(176, 247);
            bntIgual.Name = "bntIgual";
            bntIgual.Size = new Size(76, 49);
            bntIgual.TabIndex = 10;
            bntIgual.Text = "=";
            bntIgual.UseVisualStyleBackColor = true;
            bntIgual.Click += bntIgual_Click;
            // 
            // bntAdicao
            // 
            bntAdicao.Location = new Point(257, 89);
            bntAdicao.Name = "bntAdicao";
            bntAdicao.Size = new Size(47, 49);
            bntAdicao.TabIndex = 11;
            bntAdicao.Text = "+";
            bntAdicao.UseVisualStyleBackColor = true;
            bntAdicao.Click += bntAdicao_Click;
            // 
            // bntSubtracao
            // 
            bntSubtracao.Location = new Point(257, 144);
            bntSubtracao.Name = "bntSubtracao";
            bntSubtracao.Size = new Size(47, 48);
            bntSubtracao.TabIndex = 12;
            bntSubtracao.Text = "-";
            bntSubtracao.UseVisualStyleBackColor = true;
            bntSubtracao.Click += button13_Click;
            // 
            // bntMultiplicacao
            // 
            bntMultiplicacao.Location = new Point(257, 198);
            bntMultiplicacao.Name = "bntMultiplicacao";
            bntMultiplicacao.Size = new Size(47, 43);
            bntMultiplicacao.TabIndex = 13;
            bntMultiplicacao.Text = "*";
            bntMultiplicacao.UseVisualStyleBackColor = true;
            bntMultiplicacao.Click += bntMultimicacao_Click;
            // 
            // bntDivisao
            // 
            bntDivisao.Location = new Point(257, 247);
            bntDivisao.Name = "bntDivisao";
            bntDivisao.Size = new Size(47, 49);
            bntDivisao.TabIndex = 14;
            bntDivisao.Text = "/";
            bntDivisao.UseVisualStyleBackColor = true;
            bntDivisao.Click += bntDivisao_Click;
            // 
            // bntC
            // 
            bntC.Location = new Point(14, 60);
            bntC.Name = "bntC";
            bntC.Size = new Size(76, 23);
            bntC.TabIndex = 15;
            bntC.Text = "C";
            bntC.UseVisualStyleBackColor = true;
            bntC.Click += bntC_Click;
            // 
            // bntVirgula
            // 
            bntVirgula.Location = new Point(14, 247);
            bntVirgula.Name = "bntVirgula";
            bntVirgula.Size = new Size(76, 49);
            bntVirgula.TabIndex = 16;
            bntVirgula.Text = ",";
            bntVirgula.UseVisualStyleBackColor = true;
            bntVirgula.Click += bntVirgula_Click;
            // 
            // textResultado
            // 
            textResultado.Location = new Point(95, 60);
            textResultado.Name = "textResultado";
            textResultado.Size = new Size(202, 23);
            textResultado.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 392);
            Controls.Add(textResultado);
            Controls.Add(bntVirgula);
            Controls.Add(bntC);
            Controls.Add(bntDivisao);
            Controls.Add(bntMultiplicacao);
            Controls.Add(bntSubtracao);
            Controls.Add(bntAdicao);
            Controls.Add(bntIgual);
            Controls.Add(bntZero);
            Controls.Add(bntNove);
            Controls.Add(bntOito);
            Controls.Add(bntSete);
            Controls.Add(bntSeis);
            Controls.Add(bntCinco);
            Controls.Add(bntQuatro);
            Controls.Add(bntTres);
            Controls.Add(bntDois);
            Controls.Add(bntUm);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntUm;
        private Button bntDois;
        private Button bntTres;
        private Button bntQuatro;
        private Button bntCinco;
        private Button bntSeis;
        private Button bntSete;
        private Button bntOito;
        private Button bntNove;
        private Button bntZero;
        private Button bntIgual;
        private Button bntAdicao;
        private Button bntSubtracao;
        private Button bntMultiplicacao;
        private Button bntDivisao;
        private Button bntC;
        private Button bntVirgula;
        private TextBox textResultado;
    }
}
