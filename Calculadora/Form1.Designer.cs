namespace Calculadora
{
    partial class FrmCalculadora
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
            this.TextResultado = new System.Windows.Forms.TextBox();
            this.lboperacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHistorico = new System.Windows.Forms.RichTextBox();
            this.btapagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextResultado
            // 
            this.TextResultado.Location = new System.Drawing.Point(22, 10);
            this.TextResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextResultado.Name = "TextResultado";
            this.TextResultado.Size = new System.Drawing.Size(220, 20);
            this.TextResultado.TabIndex = 0;
            this.TextResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextResultado.TextChanged += new System.EventHandler(this.TextResultado_TextChanged);
            // 
            // lboperacao
            // 
            this.lboperacao.AutoSize = true;
            this.lboperacao.BackColor = System.Drawing.Color.Transparent;
            this.lboperacao.Location = new System.Drawing.Point(28, 12);
            this.lboperacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lboperacao.Name = "lboperacao";
            this.lboperacao.Size = new System.Drawing.Size(0, 13);
            this.lboperacao.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 47);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 47);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(153, 47);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 47);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(199, 92);
            this.button16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(42, 45);
            this.button16.TabIndex = 21;
            this.button16.Text = "C";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(153, 91);
            this.button17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(40, 41);
            this.button17.TabIndex = 20;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(109, 91);
            this.button18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 41);
            this.button18.TabIndex = 19;
            this.button18.Text = "4";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(65, 91);
            this.button19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 41);
            this.button19.TabIndex = 18;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(22, 91);
            this.button20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 41);
            this.button20.TabIndex = 17;
            this.button20.Text = "6";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(22, 137);
            this.button21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 41);
            this.button21.TabIndex = 12;
            this.button21.Text = "1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(66, 137);
            this.button22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 41);
            this.button22.TabIndex = 13;
            this.button22.Text = "2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(110, 137);
            this.button23.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 41);
            this.button23.TabIndex = 14;
            this.button23.Text = "3";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(153, 137);
            this.button24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(40, 41);
            this.button24.TabIndex = 15;
            this.button24.Text = "x";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(199, 137);
            this.button25.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(42, 73);
            this.button25.TabIndex = 16;
            this.button25.Text = "=";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(22, 184);
            this.button31.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(83, 27);
            this.button31.TabIndex = 22;
            this.button31.Text = "0";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(110, 184);
            this.button33.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(40, 27);
            this.button33.TabIndex = 24;
            this.button33.Text = ".";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(153, 184);
            this.button34.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(40, 27);
            this.button34.TabIndex = 25;
            this.button34.Text = "/";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btapagar);
            this.panel1.Controls.Add(this.txtHistorico);
            this.panel1.Location = new System.Drawing.Point(247, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 199);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Enabled = false;
            this.txtHistorico.Location = new System.Drawing.Point(3, 3);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(85, 193);
            this.txtHistorico.TabIndex = 0;
            this.txtHistorico.Text = "";
            this.txtHistorico.TextChanged += new System.EventHandler(this.txtHistorico_TextChanged);
            // 
            // btapagar
            // 
            this.btapagar.Location = new System.Drawing.Point(16, 173);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(56, 23);
            this.btapagar.TabIndex = 1;
            this.btapagar.Text = "Limpar";
            this.btapagar.UseVisualStyleBackColor = true;
            this.btapagar.Click += new System.EventHandler(this.btapagar_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 221);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lboperacao);
            this.Controls.Add(this.TextResultado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora Simples";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextResultado;
        private System.Windows.Forms.Label lboperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtHistorico;
        private System.Windows.Forms.Button btapagar;
    }
}

