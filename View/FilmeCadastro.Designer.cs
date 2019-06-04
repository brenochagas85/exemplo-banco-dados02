namespace View
{
    partial class FilmeCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCurtiu = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.ckbTemSequencia = new System.Windows.Forms.CheckBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtduracao = new System.Windows.Forms.TextBox();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(75, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(59, 94);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(84, 21);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCurtiu
            // 
            this.lblCurtiu.AutoSize = true;
            this.lblCurtiu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurtiu.Location = new System.Drawing.Point(75, 165);
            this.lblCurtiu.Name = "lblCurtiu";
            this.lblCurtiu.Size = new System.Drawing.Size(57, 21);
            this.lblCurtiu.TabIndex = 2;
            this.lblCurtiu.Text = "Curtiu";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(113, 189);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(51, 20);
            this.rbNao.TabIndex = 3;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(43, 189);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(49, 20);
            this.rbSim.TabIndex = 4;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Location = new System.Drawing.Point(43, 309);
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(121, 20);
            this.txtAvaliacao.TabIndex = 7;
            // 
            // ckbTemSequencia
            // 
            this.ckbTemSequencia.AutoSize = true;
            this.ckbTemSequencia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTemSequencia.Location = new System.Drawing.Point(43, 349);
            this.ckbTemSequencia.Name = "ckbTemSequencia";
            this.ckbTemSequencia.Size = new System.Drawing.Size(145, 25);
            this.ckbTemSequencia.TabIndex = 8;
            this.ckbTemSequencia.Text = "Tem Sequência";
            this.ckbTemSequencia.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Ação",
            "Infantil",
            "Bipolaridade",
            "Drama"});
            this.cbCategoria.Location = new System.Drawing.Point(43, 118);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 9;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.Location = new System.Drawing.Point(43, 231);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(74, 21);
            this.lblDuracao.TabIndex = 10;
            this.lblDuracao.Text = "Duração";
            // 
            // txtduracao
            // 
            this.txtduracao.Location = new System.Drawing.Point(43, 255);
            this.txtduracao.Name = "txtduracao";
            this.txtduracao.Size = new System.Drawing.Size(121, 20);
            this.txtduracao.TabIndex = 11;
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliacao.Location = new System.Drawing.Point(43, 285);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(85, 21);
            this.lblAvaliacao.TabIndex = 12;
            this.lblAvaliacao.Text = "Avaliação";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(43, 393);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 32);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(260, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(263, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // FilmeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAvaliacao);
            this.Controls.Add(this.txtduracao);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.ckbTemSequencia);
            this.Controls.Add(this.txtAvaliacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.lblCurtiu);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Name = "FilmeCadastro";
            this.Text = "FilmeCadastro";
            this.Load += new System.EventHandler(this.FilmeCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCurtiu;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.CheckBox ckbTemSequencia;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtduracao;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}