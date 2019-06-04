namespace View
{
    partial class FilmeEditar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.ckbTemSequencia = new System.Windows.Forms.CheckBox();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 310);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 32);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Avaliação";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(16, 206);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(121, 20);
            this.txtDuracao.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Duração";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Ação",
            "Infantil",
            "Bipolaridade",
            "Drama"});
            this.cbCategoria.Location = new System.Drawing.Point(12, 111);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 36;
            // 
            // ckbTemSequencia
            // 
            this.ckbTemSequencia.AutoSize = true;
            this.ckbTemSequencia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTemSequencia.Location = new System.Drawing.Point(12, 279);
            this.ckbTemSequencia.Name = "ckbTemSequencia";
            this.ckbTemSequencia.Size = new System.Drawing.Size(145, 25);
            this.ckbTemSequencia.TabIndex = 35;
            this.ckbTemSequencia.Text = "Tem Sequência";
            this.ckbTemSequencia.UseVisualStyleBackColor = true;
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Location = new System.Drawing.Point(12, 253);
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(121, 20);
            this.txtAvaliacao.TabIndex = 34;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 33;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(12, 159);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(49, 20);
            this.rbSim.TabIndex = 32;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(67, 158);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(51, 20);
            this.rbNao.TabIndex = 31;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Curtiu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(198, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 21);
            this.lblId.TabIndex = 41;
            this.lblId.Text = "ID";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(202, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 42;
            // 
            // FilmeEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.ckbTemSequencia);
            this.Controls.Add(this.txtAvaliacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "FilmeEditar";
            this.Text = "FilmeEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.CheckBox ckbTemSequencia;
        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}