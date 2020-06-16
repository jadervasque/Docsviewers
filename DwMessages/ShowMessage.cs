using DwMessages.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace DwMessages
{
    public static class ShowMessage
    {
        public static bool SimNao(string mensagem)
        {
            return new MessageYesNo(mensagem).ShowQuestion();
        }

        public static void Ok(string mensagem)
        {
            var bitmap = new Bitmap(Resources.confirm);
            var form = new MessageOk(mensagem, bitmap);
            form.Text = "Confirmação";
            form.ShowDialog();
        }

        #region Exclamação
        public static void Exc(string mensagem)
        {
            var bitmap = new Bitmap(Resources.alert);
            var form = new MessageOk(mensagem, bitmap);
            form.Text = "Atenção";
            form.ShowDialog();
        }

        public static void Exc(string titulo, string mensagem)
        {
            var bitmap = new Bitmap(Resources.alert);
            var form = new MessageInfo(string.Format("{0}{1}{1}{2}", titulo, "\r\n", mensagem), bitmap);
            form.Text = "Atenção";
            form.ShowDialog();
        }

        /// <param name="tamanho">
        /// 1: 500x300, 
        /// 2: 500x400, 
        /// 3: 600x300, 
        /// 4: 600x400, 
        /// 5: 600x500, 
        /// 6: 700x400, 
        /// 7: 700x500, 
        /// 8: 700x600, 
        /// 9: 800x400, 
        /// 10: 800x500, 
        /// 11: 800x600, 
        /// 12: 800x700</param>
        public static void Exc(string titulo, string mensagem, int tamanho)
        {
            var bitmap = new Bitmap(Resources.alert);
            var form = new MessageInfo(string.Format("{0}{1}{1}{2}", titulo, "\r\n", mensagem), bitmap);
            form.Text = "Atenção";
            switch (tamanho)
            {
                case 1: form.Size = new Size(500, 300); break;
                case 2: form.Size = new Size(500, 400); break;
                case 3: form.Size = new Size(600, 300); break;
                case 4: form.Size = new Size(600, 400); break;
                case 5: form.Size = new Size(600, 500); break;
                case 6: form.Size = new Size(700, 400); break;
                case 7: form.Size = new Size(700, 500); break;
                case 8: form.Size = new Size(700, 600); break;
                case 9: form.Size = new Size(800, 400); break;
                case 10: form.Size = new Size(800, 500); break;
                case 11: form.Size = new Size(800, 600); break;
                case 12: form.Size = new Size(800, 700); break;
            }
            form.ShowDialog();
        }

        public static void Exc(AtencaoException ex)
        {
            if (ex.Blank)
                return;
            var bitmap = new Bitmap(Resources.alert);
            if (string.IsNullOrEmpty(ex.Titulo))
            {
                var form = new MessageOk(ex.Mensagem, bitmap);
                form.Text = "Atenção";
                form.ShowDialog();
            }
            else
            {
                RegistrarLog(ex.ToString());
                var form = new MessageInfo(string.Format("{0}{1}{1}{2}", ex.Titulo, "\r\n", ex.Mensagem), bitmap);
                form.Text = "Atenção";
                form.Size = ex.Tamanho;
                form.ShowDialog();
            }
        }
        #endregion

        #region Informação
        public static void Info(string mensagem)
        {
            var bitmap = new Bitmap(Resources.info);
            var form = new MessageOk(mensagem, bitmap);
            form.Text = "Informação";
            form.ShowDialog();
        }

        public static void Info(string titulo, string mensagem)
        {
            var bitmap = new Bitmap(Resources.info);
            var form = new MessageInfo(string.Format("{0}{1}{1}{2}", titulo, "\r\n", mensagem), bitmap);
            form.Text = "Informação";
            form.ShowDialog();
        }

        /// <param name="tamanho">
        /// 1: 500x300, 
        /// 2: 500x400, 
        /// 3: 600x300, 
        /// 4: 600x400, 
        /// 5: 600x500, 
        /// 6: 700x400, 
        /// 7: 700x500, 
        /// 8: 700x600, 
        /// 9: 800x400, 
        /// 10: 800x500, 
        /// 11: 800x600, 
        /// 12: 800x700</param>
        public static void Info(string titulo, string mensagem, int tamanho)
        {
            var bitmap = new Bitmap(Resources.info);
            var form = new MessageInfo(string.Format("{0}{1}{1}{2}", titulo, "\r\n", mensagem), bitmap);
            form.Text = "Informação";
            switch (tamanho)
            {
                case 1: form.Size = new Size(500, 300); break;
                case 2: form.Size = new Size(500, 400); break;
                case 3: form.Size = new Size(600, 300); break;
                case 4: form.Size = new Size(600, 400); break;
                case 5: form.Size = new Size(600, 500); break;
                case 6: form.Size = new Size(700, 400); break;
                case 7: form.Size = new Size(700, 500); break;
                case 8: form.Size = new Size(700, 600); break;
                case 9: form.Size = new Size(800, 400); break;
                case 10: form.Size = new Size(800, 500); break;
                case 11: form.Size = new Size(800, 600); break;
                case 12: form.Size = new Size(800, 700); break;
            }
            form.ShowDialog();
        }

        /// <param name="tamanho">
        /// 1: 500x300, 
        /// 2: 500x400, 
        /// 3: 600x300, 
        /// 4: 600x400, 
        /// 5: 600x500, 
        /// 6: 700x400, 
        /// 7: 700x500, 
        /// 8: 700x600, 
        /// 9: 800x400, 
        /// 10: 800x500, 
        /// 11: 800x600, 
        /// 12: 800x700</param>
        public static void Info(string mensagem, int tamanho)
        {
            var bitmap = new Bitmap(Resources.info);
            var form = new MessageInfo(string.Format("{0}{1}", "\r\n", mensagem), bitmap);
            form.Text = "Informação";
            switch (tamanho)
            {
                case 1: form.Size = new Size(500, 300); break;
                case 2: form.Size = new Size(500, 400); break;
                case 3: form.Size = new Size(600, 300); break;
                case 4: form.Size = new Size(600, 400); break;
                case 5: form.Size = new Size(600, 500); break;
                case 6: form.Size = new Size(700, 400); break;
                case 7: form.Size = new Size(700, 500); break;
                case 8: form.Size = new Size(700, 600); break;
                case 9: form.Size = new Size(800, 400); break;
                case 10: form.Size = new Size(800, 500); break;
                case 11: form.Size = new Size(800, 600); break;
                case 12: form.Size = new Size(800, 700); break;
            }
            form.ShowDialog();
        }

        public static void Info(InfoException ex)
        {
            if (ex.Blank)
                return;
            var bitmap = new Bitmap(Resources.info);
            if (string.IsNullOrEmpty(ex.Titulo))
            {
                var form = new MessageOk(ex.Mensagem, bitmap);
                form.Text = "Informação";
                form.ShowDialog();
            }
            else
            {
                RegistrarLog(ex.ToString());
                var form = new MessageInfo(string.Format("{0}{1}{1}{2}", ex.Titulo, "\r\n", ex.Mensagem), bitmap);
                form.Text = "Informação";
                form.Size = ex.Tamanho;
                form.ShowDialog();
            }
        }
        #endregion

        public static void Erro(Exception ex)
        {
            if (string.IsNullOrEmpty(ex.Message))
                return;
            var type = ex.GetType();
            if (type == typeof(InfoException))
                Info((InfoException)ex);
            else if (type == typeof(AtencaoException))
                Exc((AtencaoException)ex);
            else
            {
                RegistrarLog(ex.ToString());
                var bitmap = new Bitmap(Resources.error);
                var msg = new MessageInfo(ex.ToString(), bitmap);
                msg.Text = "Erro";
                msg.ShowDialog();
            }
        }

        public static void Erro(string mensagem, params string[] args)
        {
            string erro = string.Format(mensagem, args);
            RegistrarLog(erro);
            var bitmap = new Bitmap(Resources.error);
            var msg = new MessageInfo(erro, bitmap);
            msg.Text = "Erro";
            msg.ShowDialog();
        }

        public static void RegistrarLog(string log)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.None);
                string logfile = Path.Combine(path, "Docsviewer Log de Inconformidades.txt");
                string datetime = string.Format("Evento de Inconformidade registrado em {0}\r\n", DateTime.Now.ToString());
                string dados = string.Format("{0}\r\n\r\n", new FileInfo(string.Format("{0}.exe", Process.GetCurrentProcess().ProcessName)).FullName);
                string p = "\r\n\r\n";
                string lastline = "-----------------------------------------------------------------";
                string newlog = datetime + dados + log + p + lastline + p;
                string file = string.Empty;
                if (File.Exists(logfile))
                    file = File.ReadAllText(logfile);
                File.WriteAllText(logfile, newlog + file);
            }
            catch (Exception ex)
            {
                Exc("Erro ao criar log.", ex.ToString());
            }
        }
    }
}