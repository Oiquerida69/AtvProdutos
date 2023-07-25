using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AtvProdutos
{
    internal class Base
    {
        public string nome;
        public string descrição;
        public int quantidade;
        public double preço;
        public bool status;

        public void mostra()
        {
            Disponivel();
            if (status == true)
            {
                Console.WriteLine($"[Produto] = {nome} [Quantidade] = {quantidade} [Descrição] = {descrição} [Valor] = {preço} [Status] = {status}");

            }
            else
            {
                Console.WriteLine($"[Produto] = {nome} [Quantidade] = {quantidade} [Descrição] = {descrição} [Valor] = {preço} [Status] = {status}");
            }
        }
        public bool Disponivel()
        {
            if (quantidade <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void desativaProduto()
        {
            quantidade = 0;
            status = false;

        }


    }
}
