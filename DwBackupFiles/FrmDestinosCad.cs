using System;
using System.IO;
using System.Xml;
using DwMessages;

namespace DwDwBackupFiles
{
    public partial class FrmDestinosCad : DwControls.DwFormCad
    {
        string _local;
        LocalPath _promob;
        bool _editar = false;

        public FrmDestinosCad(string local)
        {
            InitializeComponent();
            _local = local;
        }

        public FrmDestinosCad(string local, LocalPath promob)
        {
            InitializeComponent();
            _local = local;
            _promob = promob;
            label2.Visible = true;
            lbID.Visible = true;
            _editar = true;
            SetDados();
        }

        private void SetDados()
        {
            txDescricao.Text = _promob.Descricao;
            txOrigem.Text = _promob.Origem;
            txDestino.Text = _promob.Destino;
            lbID.Text = _promob.ID.ToString();
            chbStatus.Status = _promob.Status == "True" ? true : false;
        }

        private bool ValidarDestinos()
        {
            bool result = true;
            string programaOrigem = txOrigem.Text.ToString().Trim();
            if (!Directory.Exists(programaOrigem))
            {
                txOrigem.SetError("Erro");
                result = false;
            }
            string programaDest = txDestino.Text.ToString().Trim();
            if (!Directory.Exists(programaDest))
            {
                if (ShowMessage.SimNao("O diretório de destino não existe. Deseja criá-lo?"))
                {
                    try
                    {
                        Directory.CreateDirectory(programaDest);
                        result = true;
                    }
                    catch (Exception)
                    {
                        ShowMessage.Exc("Não foi possível criar o diretório.");
                        result = false;
                    }
                }
                else
                {
                    txDestino.SetError("Erro");
                    result = false;
                }
            }
            return result;
        }

        protected override bool Salvar()
        {
            if (!ValidarDestinos())
                return false;
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string file = string.Empty;
                string ID = "0";
                if (_editar)
                {
                    file = Path.Combine(_local, string.Format("destino{0}.xml", _promob.ID));
                    ID = _promob.ID;
                }
                else
                {
                    for (int i = 1; i <= 1000; i++)
                    {
                        string path = Path.Combine(_local, string.Format("destino{0}.xml", i.ToString()));
                        if (!File.Exists(path))
                        {
                            file = path;
                            ID = i.ToString();
                            break;
                        }
                    }
                }
                XmlTextWriter xmlTextWriter = new XmlTextWriter(file, null);
                xmlTextWriter.WriteStartDocument();
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.WriteStartElement("destino");
                xmlTextWriter.WriteAttributeString("ID", ID.ToString());
                xmlTextWriter.WriteAttributeString("descricao", txDescricao.Text.ToString().Trim());
                xmlTextWriter.WriteAttributeString("origem", txOrigem.Text.ToString().Trim());
                xmlTextWriter.WriteAttributeString("destino", txDestino.Text.ToString().Trim());
                xmlTextWriter.WriteAttributeString("status", chbStatus.Status.ToString());
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.Close();
                Salvo = true;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btOrigem_Click(object sender, EventArgs e)
        {
            fbdLocalizar.ShowDialog();
            txOrigem.Text = fbdLocalizar.SelectedPath;
            fbdLocalizar.SelectedPath = "";
        }

        private void btDestino_Click(object sender, EventArgs e)
        {
            fbdLocalizar.ShowDialog();
            txDestino.Text = fbdLocalizar.SelectedPath;
            fbdLocalizar.SelectedPath = "";
        }
    }
}
