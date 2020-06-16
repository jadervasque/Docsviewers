namespace DwMessages
{
    public class GMessages
    {
        /// <summary>
        /// Deseja fechar o aplicativo?
        /// </summary>
        public static bool FecharAplicativo()
        {
            return !ShowMessage.SimNao("Deseja fechar o aplicativo?");
        }

        /// <summary>
        /// Deseja salvar o registro?
        /// </summary>
        public static bool PerguntarSalvar()
        {
            return ShowMessage.SimNao("Deseja salvar o registro?");
        }

        /// <summary>
        /// Deseja excluir o registro selecionado?
        /// </summary>
        public static bool PerguntarExcluir()
        {
            return ShowMessage.SimNao("Deseja excluir o registro selecionado?");
        }

        /// <summary>
        /// Deseja excluir os registros selecionados?
        /// </summary>
        public static bool PerguntarExcluirRegistros()
        {
            return ShowMessage.SimNao("Deseja excluir os registros selecionados?");
        }

        /// <summary>
        /// Registro salvo com sucesso.
        /// </summary>
        public static void ConfirmacaoSalvo()
        {
            ShowMessage.Ok("Registro salvo com sucesso.");
        }

        /// <summary>
        /// Somente o Administrador pode realizar esta operação.
        /// </summary>
        public static void RestritoAdministrador()
        {
            ShowMessage.Info("Somente o Administrador pode realizar esta operação.");
        }

        /// <summary>
        /// Esta operação não pode ser realizada.
        /// </summary>
        public static void OperacaoIndisponivel()
        {
            ShowMessage.Exc("Esta operação não pode ser realizada.");
        }
    }
}
