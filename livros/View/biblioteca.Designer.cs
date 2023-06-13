namespace livros.View
{
    partial class biblioteca
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
            this.cBox_desc = new System.Windows.Forms.ComboBox();
            this.txt_NomeLivro = new System.Windows.Forms.TextBox();
            this.txt_ValorLivro = new System.Windows.Forms.TextBox();
            this.txt_AnoLivro = new System.Windows.Forms.TextBox();
            this.txt_nomeCi = new System.Windows.Forms.TextBox();
            this.txt_CpfCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_nomecli = new System.Windows.Forms.Label();
            this.lbl_anolivro = new System.Windows.Forms.Label();
            this.lbl_nmcli = new System.Windows.Forms.Label();
            this.lbl_cpfcli = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBox_desc
            // 
            this.cBox_desc.FormattingEnabled = true;
            this.cBox_desc.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%"});
            this.cBox_desc.Location = new System.Drawing.Point(164, 192);
            this.cBox_desc.Name = "cBox_desc";
            this.cBox_desc.Size = new System.Drawing.Size(121, 23);
            this.cBox_desc.TabIndex = 0;
            // 
            // txt_NomeLivro
            // 
            this.txt_NomeLivro.Location = new System.Drawing.Point(164, 63);
            this.txt_NomeLivro.Name = "txt_NomeLivro";
            this.txt_NomeLivro.Size = new System.Drawing.Size(179, 23);
            this.txt_NomeLivro.TabIndex = 1;
            // 
            // txt_ValorLivro
            // 
            this.txt_ValorLivro.Location = new System.Drawing.Point(164, 104);
            this.txt_ValorLivro.Name = "txt_ValorLivro";
            this.txt_ValorLivro.Size = new System.Drawing.Size(179, 23);
            this.txt_ValorLivro.TabIndex = 2;
            // 
            // txt_AnoLivro
            // 
            this.txt_AnoLivro.Location = new System.Drawing.Point(164, 146);
            this.txt_AnoLivro.Name = "txt_AnoLivro";
            this.txt_AnoLivro.Size = new System.Drawing.Size(179, 23);
            this.txt_AnoLivro.TabIndex = 3;
            // 
            // txt_nomeCi
            // 
            this.txt_nomeCi.Location = new System.Drawing.Point(515, 96);
            this.txt_nomeCi.Name = "txt_nomeCi";
            this.txt_nomeCi.Size = new System.Drawing.Size(179, 23);
            this.txt_nomeCi.TabIndex = 4;
            // 
            // txt_CpfCli
            // 
            this.txt_CpfCli.Location = new System.Drawing.Point(515, 142);
            this.txt_CpfCli.Name = "txt_CpfCli";
            this.txt_CpfCli.Size = new System.Drawing.Size(179, 23);
            this.txt_CpfCli.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor do livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano do livro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(411, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome do cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(411, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF do cliente:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_resultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resultado.Location = new System.Drawing.Point(567, 361);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(39, 15);
            this.lbl_resultado.TabIndex = 12;
            this.lbl_resultado.Text = "Valor: ";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(185, 262);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 31);
            this.btn_calcular.TabIndex = 13;
            this.btn_calcular.Text = "button1";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_nomecli
            // 
            this.lbl_nomecli.AutoSize = true;
            this.lbl_nomecli.Location = new System.Drawing.Point(6, 33);
            this.lbl_nomecli.Name = "lbl_nomecli";
            this.lbl_nomecli.Size = new System.Drawing.Size(81, 15);
            this.lbl_nomecli.TabIndex = 14;
            this.lbl_nomecli.Text = "Nome cliente:";
            // 
            // lbl_anolivro
            // 
            this.lbl_anolivro.AutoSize = true;
            this.lbl_anolivro.Location = new System.Drawing.Point(6, 62);
            this.lbl_anolivro.Name = "lbl_anolivro";
            this.lbl_anolivro.Size = new System.Drawing.Size(75, 15);
            this.lbl_anolivro.TabIndex = 15;
            this.lbl_anolivro.Text = "Ano do livro:";
            // 
            // lbl_nmcli
            // 
            this.lbl_nmcli.AutoSize = true;
            this.lbl_nmcli.Location = new System.Drawing.Point(6, 90);
            this.lbl_nmcli.Name = "lbl_nmcli";
            this.lbl_nmcli.Size = new System.Drawing.Size(98, 15);
            this.lbl_nmcli.TabIndex = 16;
            this.lbl_nmcli.Text = "Nome do cliente:";
            // 
            // lbl_cpfcli
            // 
            this.lbl_cpfcli.AutoSize = true;
            this.lbl_cpfcli.Location = new System.Drawing.Point(6, 115);
            this.lbl_cpfcli.Name = "lbl_cpfcli";
            this.lbl_cpfcli.Size = new System.Drawing.Size(86, 15);
            this.lbl_cpfcli.TabIndex = 17;
            this.lbl_cpfcli.Text = "CPF do cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_cpfcli);
            this.groupBox1.Controls.Add(this.lbl_nomecli);
            this.groupBox1.Controls.Add(this.lbl_nmcli);
            this.groupBox1.Controls.Add(this.lbl_anolivro);
            this.groupBox1.Location = new System.Drawing.Point(60, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 139);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nota fiscal";
            // 
            // biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CpfCli);
            this.Controls.Add(this.txt_nomeCi);
            this.Controls.Add(this.txt_AnoLivro);
            this.Controls.Add(this.txt_ValorLivro);
            this.Controls.Add(this.txt_NomeLivro);
            this.Controls.Add(this.cBox_desc);
            this.Name = "biblioteca";
            this.Text = "biblioteca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cBox_desc;
        private TextBox txt_NomeLivro;
        private TextBox txt_ValorLivro;
        private TextBox txt_AnoLivro;
        private TextBox txt_nomeCi;
        private TextBox txt_CpfCli;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_resultado;
        private Button btn_calcular;
        private Label lbl_nomecli;
        private Label lbl_anolivro;
        private Label lbl_nmcli;
        private Label lbl_cpfcli;
        private GroupBox groupBox1;
    }
}