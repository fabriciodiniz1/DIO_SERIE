using System.Collections.Generic;

namespace DIOSerie.Interfaces
{
    public interface IRepositorio<T> // Padrão de desenho como repositório, armazenar os dados em um lugar
    {
		/* o uso do T é um tipo genérico*/
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}