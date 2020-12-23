namespace ExeercicioFixacaoListaFuncionarios
{
    class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public double SalarioFuncionario { get; set; }

        public Funcionario(int idFuncionario, string nomeFuncionario, double salarioFuncionario)
        {
            IdFuncionario = idFuncionario;
            NomeFuncionario = nomeFuncionario;
            SalarioFuncionario = salarioFuncionario;
        }

        public void SalarioReajustado(double porcentagemReajuste)
        {
            SalarioFuncionario += (SalarioFuncionario * (porcentagemReajuste / 100));
        }
    }
}
