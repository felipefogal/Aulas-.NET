using System.Globalization;

namespace EstudoDeProdutos
{
    class Produtos
    {
        // O padrao de nomes para atributos privados no C# é iniciado com _ 
        private string _nome;
        private double _preco;
        private int _quantidade;

        // Construtor da classe recebendo os argumentos
        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // O metodo Get serve para retornar o nome
        public string GetNome()
        {
            return _nome;
        }

        // O metodo Set expôe o nome para poder alterá-lo
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }       
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double preco)
        {
            _preco = preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = _preco * _quantidade;
            return valorTotal;
        }

        public void AdicionaProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
