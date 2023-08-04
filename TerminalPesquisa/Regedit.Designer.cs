namespace TerminalPesquisa
{
    partial class Regedit
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regedit));
            label1 = new Label();
            txtInstancia = new TextBox();
            txtBanco = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            btnSalvar = new Button();
            imageList1 = new ImageList(components);
            btnLimpar = new Button();
            btnEditar = new Button();
            pbDuvidas = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDuvidas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome instância:";
            // 
            // txtInstancia
            // 
            txtInstancia.Enabled = false;
            txtInstancia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInstancia.Location = new Point(12, 37);
            txtInstancia.Name = "txtInstancia";
            txtInstancia.Size = new Size(337, 33);
            txtInstancia.TabIndex = 1;
            // 
            // txtBanco
            // 
            txtBanco.Enabled = false;
            txtBanco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBanco.Location = new Point(12, 117);
            txtBanco.Name = "txtBanco";
            txtBanco.Size = new Size(337, 33);
            txtBanco.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 2;
            label2.Text = "Banco de dados:";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(12, 208);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(337, 33);
            txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Enabled = false;
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(12, 298);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(337, 33);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 270);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 6;
            label4.Text = "Senha:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.ImageIndex = 1;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(132, 354);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(81, 39);
            btnSalvar.TabIndex = 6;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "botao-editar.png");
            imageList1.Images.SetKeyName(1, "salve-.png");
            imageList1.Images.SetKeyName(2, "limpeza.png");
            imageList1.Images.SetKeyName(3, "duvida.png");
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ImageIndex = 2;
            btnLimpar.ImageList = imageList1;
            btnLimpar.Location = new Point(219, 354);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(81, 39);
            btnLimpar.TabIndex = 7;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += bnLimpar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ImageIndex = 0;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(45, 354);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.No;
            btnEditar.Size = new Size(81, 39);
            btnEditar.TabIndex = 5;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pbDuvidas
            // 
            pbDuvidas.Cursor = Cursors.Hand;
            pbDuvidas.Image = (Image)resources.GetObject("pbDuvidas.Image");
            pbDuvidas.Location = new Point(315, 364);
            pbDuvidas.Name = "pbDuvidas";
            pbDuvidas.Size = new Size(25, 20);
            pbDuvidas.SizeMode = PictureBoxSizeMode.Zoom;
            pbDuvidas.TabIndex = 8;
            pbDuvidas.TabStop = false;
            pbDuvidas.Click += pbDuvidas_Click;
            // 
            // Regedit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 409);
            Controls.Add(pbDuvidas);
            Controls.Add(btnEditar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(txtBanco);
            Controls.Add(label2);
            Controls.Add(txtInstancia);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Regedit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração";
            Load += Regedit_Load;
            ((System.ComponentModel.ISupportInitialize)pbDuvidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnEditar;
        public TextBox txtInstancia;
        public TextBox txtBanco;
        public TextBox txtUsuario;
        public TextBox txtSenha;
        private ImageList imageList1;
        private PictureBox pbDuvidas;
    }
}