using System.Globalization;

namespace ProdutosComConstrutores
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; // não é necessário passar esta linha, pois
                            // atributos int já se iniciam com valor 0
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

// ***********************************************
// *** Lição sobre construtores e palavra this ***
// ***********************************************

//// Todo atributo começando com maiusculas
//// caso o atributo seja do tipo publico,
//// e nome de variaveis em minusculas
//// Para atributos privados, inicia-se com _
//// e nome minusculo. Ex: _nome
//public string Nome;
//public double Preco;
//public int Quantidade;

//// Construtor da classe Produto:
//// construtores se declara informando
//// o nome da classe
//public Produto()
//{
//    Quantidade = 10;
//}

////public Produto(string nome, double preco, int quantidade)
////{
////    Nome = nome;
////    Preco = preco;
////    Quantidade = quantidade;
////}

//// O this aqui está sendo usado para atribuir os valores
//// do construtor padrão da classe
//public Produto(string nome, double preco) : this()
//        {
//    Nome = nome;
//    Preco = preco;
//}

//// E aqui este this usa o contrutor de cima
//public Produto(string nome, double preco, int quantidade) : this(nome, preco)
//        {
//    Quantidade = quantidade;
//}

//// Este método é uma sobrecarga do 
//// construtor da classe Produto, obrigando
//// apenas passar Nome e Preço e deixando
//// Quantidade como igual a 0
////public Produto(string nome, double preco)
////{
////    Nome = nome;
////    Preco = preco;
////    Quantidade = 0; // não é necessário passar esta linha, pois
////                    // atributos int já se iniciam com valor 0
////}

