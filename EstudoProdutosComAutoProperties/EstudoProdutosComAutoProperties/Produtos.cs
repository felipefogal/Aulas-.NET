using System.Globalization;

namespace EstudoDeProdutosComAutoProperties
{
    class Produtos
    {
        // AutoProperties: declara-se os atributos da classe como se fossem
        // atributos normais, publicos, porém já se setam os get e sets. Caso
        // não tenhamos setters, usa-se a declaração "private set". No nosso caso,
        // como estamos usando tanto getters e setters, apontamos os dois
        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        // Construtor da classe recebendo os argumentos
        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = Preco * Quantidade;
            return valorTotal;
        }

        public void AdicionaProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
