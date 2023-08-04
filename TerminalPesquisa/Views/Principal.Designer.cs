namespace TerminalPesquisa
{
    partial class Principal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            label1 = new Label();
            txtPesquisaProd = new TextBox();
            btnPesquisar = new Button();
            imgLstBotoes = new ImageList(components);
            label2 = new Label();
            txtId = new TextBox();
            txtValorProd = new TextBox();
            label3 = new Label();
            txtUnProd = new TextBox();
            label4 = new Label();
            txtCodBarra = new TextBox();
            label5 = new Label();
            txtStatus = new TextBox();
            label6 = new Label();
            lstPesquisa = new ListView();
            imgLstIcones = new ImageList(components);
            label7 = new Label();
            lstItensPesquisados = new ListView();
            col_Id = new ColumnHeader();
            col_Nome = new ColumnHeader();
            col_Valor = new ColumnHeader();
            col_Sigla = new ColumnHeader();
            col_CodBarras = new ColumnHeader();
            col_Status = new ColumnHeader();
            btnLimpar = new Button();
            btnConfiguracao = new Button();
            pbIcone = new PictureBox();
            pbMinimizar = new PictureBox();
            pbFechar = new PictureBox();
            label8 = new Label();
            pbDuvidas = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbIcone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDuvidas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 58);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // txtPesquisaProd
            // 
            txtPesquisaProd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisaProd.Location = new Point(130, 55);
            txtPesquisaProd.Name = "txtPesquisaProd";
            txtPesquisaProd.PlaceholderText = "Insira o ID ou Código de barras do produto";
            txtPesquisaProd.Size = new Size(534, 33);
            txtPesquisaProd.TabIndex = 1;
            txtPesquisaProd.KeyPress += txtPesquisaProd_KeyPress;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.ImageIndex = 1;
            btnPesquisar.ImageList = imgLstBotoes;
            btnPesquisar.Location = new Point(672, 55);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(56, 33);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imgLstBotoes
            // 
            imgLstBotoes.ColorDepth = ColorDepth.Depth8Bit;
            imgLstBotoes.ImageStream = (ImageListStreamer)resources.GetObject("imgLstBotoes.ImageStream");
            imgLstBotoes.TransparentColor = Color.Transparent;
            imgLstBotoes.Images.SetKeyName(0, "configuracao.png");
            imgLstBotoes.Images.SetKeyName(1, "lupa.png");
            imgLstBotoes.Images.SetKeyName(2, "limpeza.png");
            imgLstBotoes.Images.SetKeyName(3, "botao-editar.png");
            imgLstBotoes.Images.SetKeyName(4, "salve-.png");
            imgLstBotoes.Images.SetKeyName(5, "botao-x.png");
            imgLstBotoes.Images.SetKeyName(6, "minimizar.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 494);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(73, 522);
            txtId.Name = "txtId";
            txtId.Size = new Size(83, 33);
            txtId.TabIndex = 5;
            // 
            // txtValorProd
            // 
            txtValorProd.Enabled = false;
            txtValorProd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorProd.Location = new Point(177, 522);
            txtValorProd.Name = "txtValorProd";
            txtValorProd.Size = new Size(116, 33);
            txtValorProd.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(177, 494);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 6;
            label3.Text = "Valor:";
            // 
            // txtUnProd
            // 
            txtUnProd.Enabled = false;
            txtUnProd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnProd.Location = new Point(317, 522);
            txtUnProd.Name = "txtUnProd";
            txtUnProd.Size = new Size(88, 33);
            txtUnProd.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(317, 494);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 8;
            label4.Text = "Unidade:";
            // 
            // txtCodBarra
            // 
            txtCodBarra.Enabled = false;
            txtCodBarra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarra.Location = new Point(430, 522);
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Size = new Size(185, 33);
            txtCodBarra.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(430, 494);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 10;
            label5.Text = "Código de barras:";
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(639, 522);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(185, 33);
            txtStatus.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(639, 494);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 14;
            label6.Text = "Status:";
            // 
            // lstPesquisa
            // 
            lstPesquisa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstPesquisa.Location = new Point(46, 122);
            lstPesquisa.Name = "lstPesquisa";
            lstPesquisa.Size = new Size(808, 144);
            lstPesquisa.SmallImageList = imgLstIcones;
            lstPesquisa.TabIndex = 15;
            lstPesquisa.UseCompatibleStateImageBehavior = false;
            lstPesquisa.ItemSelectionChanged += lstPesquisa_ItemSelectionChanged;
            // 
            // imgLstIcones
            // 
            imgLstIcones.ColorDepth = ColorDepth.Depth8Bit;
            imgLstIcones.ImageStream = (ImageListStreamer)resources.GetObject("imgLstIcones.ImageStream");
            imgLstIcones.TransparentColor = Color.Transparent;
            imgLstIcones.Images.SetKeyName(0, "prod-inativo.png");
            imgLstIcones.Images.SetKeyName(1, "prod-ativo.png");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(356, 275);
            label7.Name = "label7";
            label7.Size = new Size(165, 25);
            label7.TabIndex = 16;
            label7.Text = "Itens pesquisados:";
            // 
            // lstItensPesquisados
            // 
            lstItensPesquisados.Columns.AddRange(new ColumnHeader[] { col_Id, col_Nome, col_Valor, col_Sigla, col_CodBarras, col_Status });
            lstItensPesquisados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstItensPesquisados.FullRowSelect = true;
            lstItensPesquisados.GridLines = true;
            lstItensPesquisados.Location = new Point(46, 309);
            lstItensPesquisados.MultiSelect = false;
            lstItensPesquisados.Name = "lstItensPesquisados";
            lstItensPesquisados.Size = new Size(808, 169);
            lstItensPesquisados.SmallImageList = imgLstIcones;
            lstItensPesquisados.TabIndex = 17;
            lstItensPesquisados.UseCompatibleStateImageBehavior = false;
            lstItensPesquisados.View = View.Details;
            lstItensPesquisados.ItemSelectionChanged += lstItensPesquisados_ItemSelectionChanged;
            // 
            // col_Id
            // 
            col_Id.Text = "ID";
            col_Id.Width = 90;
            // 
            // col_Nome
            // 
            col_Nome.Text = "Nome";
            col_Nome.Width = 305;
            // 
            // col_Valor
            // 
            col_Valor.Text = "Valor";
            col_Valor.Width = 80;
            // 
            // col_Sigla
            // 
            col_Sigla.Text = "Sigla";
            // 
            // col_CodBarras
            // 
            col_CodBarras.Text = "Código de barras";
            col_CodBarras.Width = 200;
            // 
            // col_Status
            // 
            col_Status.Text = "Status";
            col_Status.Width = 70;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.ImageIndex = 2;
            btnLimpar.ImageList = imgLstBotoes;
            btnLimpar.Location = new Point(734, 55);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(58, 33);
            btnLimpar.TabIndex = 20;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.Cursor = Cursors.Hand;
            btnConfiguracao.ImageIndex = 0;
            btnConfiguracao.ImageList = imgLstBotoes;
            btnConfiguracao.Location = new Point(798, 55);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Size = new Size(56, 33);
            btnConfiguracao.TabIndex = 21;
            btnConfiguracao.UseVisualStyleBackColor = true;
            btnConfiguracao.Click += btnConfiguracao_Click;
            // 
            // pbIcone
            // 
            pbIcone.Image = (Image)resources.GetObject("pbIcone.Image");
            pbIcone.Location = new Point(351, 9);
            pbIcone.Name = "pbIcone";
            pbIcone.Size = new Size(37, 25);
            pbIcone.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcone.TabIndex = 22;
            pbIcone.TabStop = false;
            // 
            // pbMinimizar
            // 
            pbMinimizar.Cursor = Cursors.Hand;
            pbMinimizar.Image = (Image)resources.GetObject("pbMinimizar.Image");
            pbMinimizar.Location = new Point(843, 2);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(29, 32);
            pbMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMinimizar.TabIndex = 23;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            // 
            // pbFechar
            // 
            pbFechar.Cursor = Cursors.Hand;
            pbFechar.Image = (Image)resources.GetObject("pbFechar.Image");
            pbFechar.Location = new Point(878, 2);
            pbFechar.Name = "pbFechar";
            pbFechar.Size = new Size(29, 32);
            pbFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFechar.TabIndex = 24;
            pbFechar.TabStop = false;
            pbFechar.Click += pbFechar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(394, 9);
            label8.Name = "label8";
            label8.Size = new Size(171, 21);
            label8.TabIndex = 25;
            label8.Text = "Terminal de consulta";
            // 
            // pbDuvidas
            // 
            pbDuvidas.Cursor = Cursors.Hand;
            pbDuvidas.Image = (Image)resources.GetObject("pbDuvidas.Image");
            pbDuvidas.Location = new Point(799, 10);
            pbDuvidas.Name = "pbDuvidas";
            pbDuvidas.Size = new Size(25, 20);
            pbDuvidas.SizeMode = PictureBoxSizeMode.Zoom;
            pbDuvidas.TabIndex = 26;
            pbDuvidas.TabStop = false;
            pbDuvidas.Click += pbDuvidas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 586);
            Controls.Add(pbDuvidas);
            Controls.Add(label8);
            Controls.Add(pbFechar);
            Controls.Add(pbMinimizar);
            Controls.Add(pbIcone);
            Controls.Add(btnConfiguracao);
            Controls.Add(btnLimpar);
            Controls.Add(lstItensPesquisados);
            Controls.Add(label7);
            Controls.Add(lstPesquisa);
            Controls.Add(txtStatus);
            Controls.Add(label6);
            Controls.Add(txtCodBarra);
            Controls.Add(label5);
            Controls.Add(txtUnProd);
            Controls.Add(label4);
            Controls.Add(txtValorProd);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisaProd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminal de consulta";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbIcone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDuvidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPesquisaProd;
        private Button btnPesquisar;
        private Label label2;
        private TextBox txtId;
        private TextBox txtValorProd;
        private Label label3;
        private TextBox txtUnProd;
        private Label label4;
        private TextBox txtCodBarra;
        private Label label5;
        private TextBox txtStatus;
        private Label label6;
        private ListView lstPesquisa;
        private Label label7;
        private ListView lstItensPesquisados;
        private ColumnHeader col_Id;
        private ColumnHeader col_Nome;
        private ColumnHeader col_Valor;
        private ColumnHeader col_Sigla;
        private ColumnHeader col_CodBarras;
        private ColumnHeader col_Status;
        private Button btnLimpar;
        private Button btnConfiguracao;
        private ImageList imgLstBotoes;
        private PictureBox pbIcone;
        private PictureBox pbMinimizar;
        private PictureBox pbFechar;
        private Label label8;
        private ImageList imgLstIcones;
        private PictureBox pbDuvidas;
    }
}