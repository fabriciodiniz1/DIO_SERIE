using System;

namespace DIOSerie.Classes
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;} //se o registro tá excluído ou não.

        // Métodos
		// Método Construtor
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false; //quando criar a série traz o campo como false
		}

        public override string ToString()// converter o objeto para string
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine; // implementação de um nova linha
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido; //citar o excluído
			return retorno;
		}

		//Encapsulamento
        public string retornaTitulo()
		{
			return this.Titulo;
		}
		// quando for exibir a listagem da série
		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido() //sei se o registro tá excluído ou não
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}