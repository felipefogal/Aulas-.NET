using System.Globalization;

namespace EstudoDeProdutos
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
