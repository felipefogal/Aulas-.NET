using System.Globalization;

namespace EstudoDeProdutos
{
    class Produtos
    {
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

        // Properties: declara-se a propertie
        // em maiusculas e sem os parenteses ()
        // e coloca-se os get e set dentro dela
        // sendo possivel termos somente o get ou o set
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                if (value != null && value.Length > 1) // a palavra value serve para pegar o valor da propertie
                                                       // funcionando como o parametro da função SetNome
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                _preco = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                _quantidade = value;
            }
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
