using System.Collections.Generic;

namespace Dio.Series.Interfaces
{

    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(Task entidade);
        void Exclui(int id);
        void Atualiza(int id, Task entidade);
        int ProximoId();
    }
}

