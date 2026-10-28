    using SistemaLocacao2.dominio.Enums;

    using System;
    using System.Collections.Generic;
    using System.Text;

namespace SistemaLocacao2.Dominio.Modelos
{
    public class Veiculo
    {
        public string Placa { get; private set; }

        public string Modelo { get; private set; }
        public string Marca { get; private set; }
        public int AnoFabricacao { get; private set; }
        public CategoriaVeiculo Categoria { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public bool Disponivel { get; private set; }



        public Veiculo(string placa, string modelo, string marca, int anofabricacao, CategoriaVeiculo categoria, decimal valordiaria, bool disponivel)
        {


            Placa = placa;
            Modelo = modelo;
            Marca = marca;
            AnoFabricacao = anofabricacao;
            Categoria = categoria;
            ValorDiaria = valordiaria;
            Disponivel = disponivel;
        }


    }

}
