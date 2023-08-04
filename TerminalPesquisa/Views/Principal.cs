using Microsoft.Data.SqlClient;
namespace TerminalPesquisa
{
    public partial class Principal : Form
    {
        #region Variaveis
        private static string[] pesquisados = new string[6];
        private static SqlConnection conn;
        string[] row = new string[6];
        String path = @".\itensPesquisados.txt";
        #endregion

        #region Construtor
        public Principal()
        {
            InitializeComponent();
            GerarGradelstPesquisa();
        }
        #endregion

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.stringConexao = @"Data Source=" + Properties.Settings.Default.Instancia + ";Initial Catalog=" + Properties.Settings.Default.Banco + ";User ID=" + Properties.Settings.Default.Usuario + ";Password=" + Properties.Settings.Default.Senha + ";Encrypt=False";
        }

        private void txtPesquisaProd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                btnPesquisar.PerformClick();
            }

        }

        private void lstPesquisa_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionado = lstPesquisa.SelectedItems;
            foreach (ListViewItem item in itens_selecionado)
            {
                txtId.Text = item.SubItems[0].Text;
                txtValorProd.Text = item.SubItems[2].Text;
                txtUnProd.Text = item.SubItems[3].Text;
                txtCodBarra.Text = item.SubItems[4].Text;
                if (item.SubItems[5].Text == "Ativo")
                {
                    txtStatus.Text = "Ativo";
                }
                else if (item.SubItems[5].Text == "Inativo")
                {
                    txtStatus.Text = "Inativo";
                }

            }
        }

        private void lstItensPesquisados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionado = lstItensPesquisados.SelectedItems;
            foreach (ListViewItem item in itens_selecionado)
            {
                txtId.Text = item.SubItems[0].Text;
                txtValorProd.Text = item.SubItems[2].Text;
                txtUnProd.Text = item.SubItems[3].Text;
                txtCodBarra.Text = item.SubItems[4].Text;
                txtStatus.Text = item.SubItems[5].Text;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.Enter:
                    btnPesquisar.PerformClick();
                    break;
                case Keys.Delete:
                    btnLimpar.PerformClick();
                    break;
                case Keys.F4:
                    btnConfiguracao.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Botões
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            lstPesquisa.Clear();
            PreencheListViewPesquisa();
            PreencheLstItensPesquisados();
            ArmazenaItens();
            LimpaFormulario();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            Regedit config = new Regedit();
            config.Show();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            try
            {

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Application.Exit();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de exceção: " + ex.Message, "Erro de exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
            lstPesquisa.Clear();
            lstItensPesquisados.Items.Clear();
        }

        private void pbDuvidas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter -> Pesquisar\n\nF4 -> Abrir configurações\n\nDelete -> Limpar formulário", "Atalhos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Métodos
        private void GerarGradelstPesquisa()
        {
            lstPesquisa.View = View.Details;
            lstPesquisa.LabelEdit = false;
            lstPesquisa.AllowColumnReorder = false;
            lstPesquisa.FullRowSelect = true;
            lstPesquisa.GridLines = true;
            lstPesquisa.Columns.Add("ID", 90, HorizontalAlignment.Right);
            lstPesquisa.Columns.Add("Nome", 305, HorizontalAlignment.Left);
            lstPesquisa.Columns.Add("Valor", 80, HorizontalAlignment.Left);
            lstPesquisa.Columns.Add("Sigla", 60, HorizontalAlignment.Left);
            lstPesquisa.Columns.Add("Codigo de Barras", 200, HorizontalAlignment.Left);
            lstPesquisa.Columns.Add("Status", 70, HorizontalAlignment.Left);

        }

        private void PreencheListViewPesquisa()
        {
            try
            {
                if (txtPesquisaProd.Text != "")
                {
                    conn = new SqlConnection(Properties.Settings.Default.stringConexao);
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(p.Id,0), ISNULL(p.Nome, ''), ISNULL(pp.Valor, 0.00), ISNULL(un.Sigla, ''), ISNULL(p.CodigoBarra, ''), ISNULL(p.Ativo, '') FROM produto p INNER JOIN precoproduto pp ON pp.IdProduto = p.Id INNER JOIN UnidadeMedida un ON p.IdUnidadeMedida = un.Id WHERE p.CodigoBarra LIKE @sql or p.Id LIKE @sql", conn);
                    cmd.Parameters.AddWithValue("sql", string.Format("%{0}%", txtPesquisaProd.Text));
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    lstPesquisa.Clear();
                    GerarGradelstPesquisa();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            row[0] = reader.GetInt64(0).ToString();
                            row[1] = reader.GetString(1);
                            row[2] = reader.GetDecimal(2).ToString();
                            row[3] = reader.GetString(3);
                            row[4] = reader.GetString(4);
                            row[5] = reader.GetInt32(5).ToString();
                            var linhaLst = new ListViewItem(row);
                            if (linhaLst.SubItems[5].Text == "1")
                            {
                                linhaLst.ImageIndex = 1;
                                linhaLst.SubItems[5].Text = "Ativo";
                            }
                            else if (linhaLst.SubItems[5].Text == "0")
                            {
                                linhaLst.ImageIndex = 0;
                                linhaLst.SubItems[5].Text = "Inativo";
                            }
                            lstPesquisa.Items.Add(linhaLst);
                            txtPesquisaProd.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado", "Produto não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Insira o codigo de barras do produto para pesquisar", "Problema com a pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show("Erro de exceção SQL: " + ex.Message, "Exceção SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ocorreu um erro:" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheLstItensPesquisados()
        {
            try
            {
                if (txtPesquisaProd.Text != "")
                {
                    conn = new SqlConnection(Properties.Settings.Default.stringConexao);
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(p.Id,0), ISNULL(p.Nome, ''), ISNULL(pp.Valor, 0.00), ISNULL(un.Sigla, ''), ISNULL(p.CodigoBarra, ''), ISNULL(p.Ativo, '') FROM produto p INNER JOIN precoproduto pp ON pp.IdProduto = p.Id INNER JOIN UnidadeMedida un ON p.IdUnidadeMedida = un.Id WHERE p.Id =@sql OR p.CodigoBarra = @sql", conn);
                    cmd.Parameters.AddWithValue("sql", txtPesquisaProd.Text);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            pesquisados[0] = reader.GetInt64(0).ToString();
                            pesquisados[1] = reader.GetString(1);
                            pesquisados[2] = reader.GetDecimal(2).ToString();
                            pesquisados[3] = reader.GetString(3);
                            pesquisados[4] = reader.GetString(4);
                            pesquisados[5] = reader.GetInt32(5).ToString();
                            var linhaLst = new ListViewItem(pesquisados);
                            if (linhaLst.SubItems[5].Text == "1")
                            {
                                linhaLst.ImageIndex = 1;
                                linhaLst.SubItems[5].Text = "Ativo";
                            }
                            else if (linhaLst.SubItems[5].Text == "0")
                            {
                                linhaLst.ImageIndex = 0;
                                linhaLst.SubItems[5].Text = "Inativo";
                            }
                            lstItensPesquisados.Items.Add(linhaLst);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show("Erro de exceção SQL: " + ex.Message, "Exceção SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ocorreu um erro:" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpaFormulario()
        {
            txtPesquisaProd.Clear();
            txtCodBarra.Clear();
            txtId.Clear();
            txtStatus.Clear();
            txtUnProd.Clear();
            txtValorProd.Clear();
            GerarGradelstPesquisa();
        }

        private void ArmazenaItens()
        {
            try
            {
                var data = DateTime.Now;

                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path))
                    {
                        fs.Close();
                    }
                }
                else if (File.Exists(path))
                {
                    if (row[5] == "1")
                    {
                        row[5] = "Ativo";
                    }
                    else if (row[5] == "0")
                    {
                        row[5] = "Inativo";
                    }
                    using (StreamWriter sw = File.AppendText(path))
                    {

                        sw.WriteLine(
                            row[0] + " | " + row[1] + " | " + row[2] + " | " + row[3] + " |  " + row[4] + " | " + row[5] + " | " + data + "\n"
                            );
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de exceção: " + ex.Message, "Erro de exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}