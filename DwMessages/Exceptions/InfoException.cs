using System;
using System.Drawing;

namespace DwMessages
{
    public class InfoException : Exception, IExceptions
    {
        public string Mensagem { get; private set; } = null;

        public string Titulo { get; private set; } = null;

        public bool Blank { get; private set; } = false;

        public Size Tamanho { get; private set; } = new Size(400, 300);

        public InfoException()
          : base(string.Empty)
        {
            Blank = true;
        }

        public InfoException(string mensagem)
          : base(mensagem)
        {
            Mensagem = mensagem;
        }

        public InfoException(string titulo, string mensagem)
          : base(string.Format("{0}{1}{1}{2}", titulo, "\r\n", mensagem))
        {
            Titulo = titulo;
            Mensagem = mensagem;
        }

        public InfoException(string titulo, string mensagem, Size tamanho)
          : base(string.Format("{0}{1}{1}{2}", titulo, "\r\n", mensagem))
        {
            Titulo = titulo;
            Mensagem = mensagem;
            Tamanho = tamanho;
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
        public InfoException(string titulo, string mensagem, int tamanho)
          : base(string.Format("{0}{1}{1}{2}", titulo, "\r\n", mensagem))
        {
            Titulo = titulo;
            Mensagem = mensagem;
            switch (tamanho)
            {
                case 1: Tamanho = new Size(500, 300); break;
                case 2: Tamanho = new Size(500, 400); break;
                case 3: Tamanho = new Size(600, 300); break;
                case 4: Tamanho = new Size(600, 400); break;
                case 5: Tamanho = new Size(600, 500); break;
                case 6: Tamanho = new Size(700, 400); break;
                case 7: Tamanho = new Size(700, 500); break;
                case 8: Tamanho = new Size(700, 600); break;
                case 9: Tamanho = new Size(800, 400); break;
                case 10: Tamanho = new Size(800, 500); break;
                case 11: Tamanho = new Size(800, 600); break;
                case 12: Tamanho = new Size(800, 700); break;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{1}{2}", Titulo, "\r\n", Mensagem);
        }

        public string GetTitulo()
        {
            return Titulo;
        }
    }
}
