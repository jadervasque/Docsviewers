using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using DwMessages;

namespace DwDwBackupFiles
{
    public partial class FrmDwMain : Form
    {
        string _localPrograma;
        string _localDestinos;
        List<LocalPath> _listaDestinos;

        public FrmDwMain()
        {
            InitializeComponent();
            btAtualizar.Tag = false;
            CriarColunas();
            VerificarPastaDestinos();
            LoadDestinos();
        }

        private void CriarColunas()
        {
            dgvLocais.AddColuna("ID", "ID", true);
            dgvLocais.AddColuna("Descricao", "Descrição");
            dgvLocais.AddColuna("Status", "Status", true);
            dgvLocais.AddColuna("Origem", "Origem");
            dgvLocais.AddColuna("Destino", "Destino");
        }

        private void VerificarPastaDestinos()
        {
            try
            {
                _localPrograma = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                _localDestinos = Path.Combine(_localPrograma, "Destinos");
                if (!Directory.Exists(_localDestinos))
                    Directory.CreateDirectory(_localDestinos);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadDestinos()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                _listaDestinos = new List<LocalPath>();
                DirectoryInfo dir = new DirectoryInfo(_localDestinos);
                FileInfo[] destinos = dir.GetFiles("*", SearchOption.TopDirectoryOnly);
                foreach (var arquivo in destinos)
                {
                    LocalPath local = new LocalPath();
                    try
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.Load(arquivo.FullName);
                        local.ID = xml.SelectSingleNode("destino").Attributes["ID"].Value;
                        local.Descricao = xml.SelectSingleNode("destino").Attributes["descricao"].Value;
                        local.Origem = xml.SelectSingleNode("destino").Attributes["origem"].Value;
                        local.Destino = xml.SelectSingleNode("destino").Attributes["destino"].Value;
                        local.Status = xml.SelectSingleNode("destino").Attributes["status"].Value;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    _listaDestinos.Add(local);
                }
                dgvLocais.Limpar();
                dgvLocais.DataSource(_listaDestinos);
            }
            catch (Exception)
            {
                throw;
            }
            Cursor.Current = Cursors.Default;
        }

        private void RealizarBackup(List<LocalPath> locaisSelecionados)
        {
            string origemModelo = string.Empty;

            List<LocalPath> locaisAtualizar = new List<LocalPath>();
            List<FileInfo[]> listas = new List<FileInfo[]>();

            #region Carregar lista de arquivos
            foreach (var local in locaisSelecionados)
            {
                FileInfo[] listaDestino;
                try
                {
                    listaDestino = new DirectoryInfo(local.Destino).GetFiles("*", SearchOption.AllDirectories);
                }
                catch (Exception)
                {
                    continue;
                }
                locaisAtualizar.Add(local);
                listas.Add(listaDestino);
            }
            #endregion

            #region Atualizar Arquivos
            int count = 0;
            foreach (var arquivosExistentes in listas)
            {
                LocalPath localAtual = locaisAtualizar[count++];
                string descricaoLocal = localAtual.Descricao;
                string pastaOrigem = localAtual.Origem;
                string pastaDestino = localAtual.Destino;
                if (!pastaOrigem.EndsWith(@"\")) { pastaOrigem += @"\"; }
                if (!pastaDestino.EndsWith(@"\")) { pastaDestino += @"\"; }

                #region Remover arquivos inexistentes
                Progresso(string.Format("Atualizando \"{0}\". Excluindo lista de arquivos inexistentes.", descricaoLocal), arquivosExistentes.Length);
                foreach (var arquivoAtual in arquivosExistentes)
                {
                    ProgressoAdd();
                    FileInfo arquivoOrigem = new FileInfo(pastaOrigem + arquivoAtual.FullName.Replace(pastaDestino, ""));
                    bool flag1 = Directory.Exists(arquivoOrigem.DirectoryName);
                    bool flag2 = Directory.Exists(arquivoAtual.DirectoryName);
                    bool flag3 = File.Exists(arquivoOrigem.FullName);
                    bool flag4 = File.Exists(arquivoAtual.FullName);
                    if (!flag1 && flag2)
                        Directory.Delete(arquivoAtual.DirectoryName, true);
                    else if (!flag3 && flag4)
                        File.Delete(arquivoAtual.FullName);
                    if (!(bool)btAtualizar.Tag)
                        throw new AtencaoException("Processo cancelado com sucesso.");
                }
                #endregion

                #region Copiar arquivos modificados
                FileInfo[] arquivosOrigem = new DirectoryInfo(localAtual.Origem).GetFiles("*", SearchOption.AllDirectories);
                Progresso(string.Format("Atualizando \"{0}\". Copiando arquivos atualizados.", descricaoLocal), arquivosOrigem.Length);
                foreach (var novoArquivo in arquivosOrigem)
                {
                    ProgressoAdd();
                    FileInfo arquivoDestino = new FileInfo(pastaDestino + novoArquivo.FullName.Replace(pastaOrigem, ""));
                    bool flag0 = novoArquivo.Directory.Name == @"$RECYCLE.BIN";
                    bool flag1 = Directory.Exists(arquivoDestino.DirectoryName);
                    bool flag2 = arquivoDestino.Exists;
                    bool flag3 = novoArquivo.LastWriteTime > arquivoDestino.LastWriteTime;
                    bool flag4 = flag2 ? novoArquivo.Length != arquivoDestino.Length : true;
                    if (flag0)
                        continue;
                    if (!flag1)
                    {
                        Directory.CreateDirectory(arquivoDestino.DirectoryName);
                        File.Copy(novoArquivo.FullName, arquivoDestino.FullName, true);
                    }
                    else if (!flag2 | flag3 | flag4)
                        File.Copy(novoArquivo.FullName, arquivoDestino.FullName, true);
                    if (!(bool)btAtualizar.Tag)
                        throw new AtencaoException("Processo cancelado com sucesso.");
                }
                #endregion
            }
            #endregion

            ProgressoConcluido("Processo concluído.");
            ShowMessage.Ok("Backup realizado com sucesso.");
        }

        private void StatusAtualizando(bool inicio = true)
        {
            if (inicio)
            {
                btAtualizar.Text = "Cancelar";
                btAtualizar.Tag = true;
                gbLocais.Enabled = false;
            }
            else
            {
                btAtualizar.Text = "Atualizar";
                btAtualizar.Tag = false;
                gbLocais.Enabled = true;
            }
            Application.DoEvents();
        }

        private void Progresso(bool abrir = true)
        {
            if (abrir)
            {
                barraProgresso.Visible = true;
                lbStatusProgresso.Visible = true;
            }
            else
            {
                barraProgresso.Visible = false;
                lbStatusProgresso.Visible = false;
            }
            Application.DoEvents();
        }

        private void Progresso(string texto, int maximo)
        {
            barraProgresso.Value = 0;
            lbStatusProgresso.Text = texto;
            barraProgresso.Maximum = maximo;
            barraProgresso.Visible = true;
            lbStatusProgresso.Visible = true;
            Application.DoEvents();
        }

        private void ProgressoAdd()
        {
            barraProgresso.Value++;
            Application.DoEvents();
        }

        private void ProgressoConcluido(string texto)
        {
            lbStatusProgresso.Text = texto;
            barraProgresso.Value = barraProgresso.Maximum;
            Application.DoEvents();
        }

        private void dgvDestinos_BotaoAdicionarClick(object sender, EventArgs e)
        {
            try
            {
                FrmDestinosCad frm = new FrmDestinosCad(_localDestinos);
                frm.ShowDialog();
                if (!frm.Salvo)
                    return;
                LoadDestinos();
            }
            catch (Exception ex)
            {
                ShowMessage.Erro(ex);
            }
        }

        private void dgvDestinos_BotaoEditarClick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (dgvLocais.Count == 0 || dgvLocais.GetSelecionados().Count != 1)
                        return;
                    LocalPath item = (LocalPath)dgvLocais.GetItemCorrente();
                    FrmDestinosCad frm = new FrmDestinosCad(_localDestinos, item);
                    frm.ShowDialog();
                    if (!frm.Salvo)
                        return;
                    LoadDestinos();
                }
                catch (Exception ex)
                {
                    ShowMessage.Erro(ex);
                }
            }
            catch (Exception ex)
            {
                ShowMessage.Erro(ex);
            }
        }

        private void dgvDestinos_BotaoExcluirClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvLocais.Count == 0 || dgvLocais.GetSelecionados().Count != 1)
                    return;
                if (ShowMessage.SimNao("Deseja excluir o item selecionado?"))
                {
                    LocalPath item = (LocalPath)dgvLocais.GetItemCorrente();
                    string file = Path.Combine(_localDestinos, string.Format("destino{0}.xml", item.ID));
                    if (File.Exists(file))
                        File.Delete(file);
                    LoadDestinos();
                }
            }
            catch (Exception ex)
            {
                ShowMessage.Erro(ex);
            }
        }

        private void dgvDestinos_BotaoAtualizarClick(object sender, EventArgs e)
        {
            try
            {
                LoadDestinos();
            }
            catch (Exception ex)
            {
                ShowMessage.Erro(ex);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(bool)btAtualizar.Tag)
                {
                    string message2 = "Não existem locais ativos para serem atualizados.";
                    if (!ShowMessage.SimNao("Deseja iniciar a atualização dos locais?"))
                        return;
                    StatusAtualizando();
                    if (ShowMessage.SimNao("Deseja atualizar somente os locais selecionados?"))
                    {
                        List<LocalPath> locais = VerificarLocaisAtivos(dgvLocais.GetSelecionados().Cast<LocalPath>().ToList());
                        if (locais.Count == 0)
                            ShowMessage.Info(message2);
                        else
                            RealizarBackup(locais);
                    }
                    else
                    {
                        List<LocalPath> locais = VerificarLocaisAtivos(dgvLocais.GetDataSource().Cast<LocalPath>().ToList());
                        if (locais.Count == 0)
                            ShowMessage.Info(message2);
                        else
                            RealizarBackup(locais);
                    }
                }
            }
            catch (AtencaoException ex)
            {
                ShowMessage.Exc(ex);
            }
            catch (Exception ex)
            {
                ShowMessage.Erro(ex);
            }
            finally
            {
                Progresso(false);
                StatusAtualizando(false);
            }
        }

        private List<LocalPath> VerificarLocaisAtivos(List<LocalPath> locais)
        {
            List<LocalPath> locaisAtualizar = new List<LocalPath>();
            foreach (var item in locais)
                if (item.Status == "True")
                    locaisAtualizar.Add(item);
            return locaisAtualizar;
        }

        private void FrmDwMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((bool)btAtualizar.Tag)
                e.Cancel = true;
        }
    }
}
