using System;
using System.Collections.Generic;
using DIOSerie.Interfaces;

namespace DIOSerie.Classes
{
    public class SerieRepositorio : IRepositorio<Serie> // implementar um repositório da classe Série, reaproveitando a interface.
	{
        private List<Serie> listaSerie = new List<Serie>();// cria uma listaSerie, colocando a lista no Repositório - desenvolvimento em camadas, cada camada com sua responsabilidade.
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto; // vai receber o objeto e colocá-lo na posição do vetor.
		}

		public void Exclui(int id) 
		{
			/*listaSerie[id].RemoveAt(id); // passando o id, pode trazer um problema, reclassificando os próximos índices, podendo ter inconsistência  */
			
			listaSerie[id].Excluir();
			//Vc pode chamar uma classe para envio de email (Criar um outro repositório).
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto); //adiciona o objeto na lista
		}

		public List<Serie> Lista() // o método Lista vai retornar uma List<Serie>
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count; // retorna um número na frente, a coleção é baseada em 0
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id]; 
		}
	}
}