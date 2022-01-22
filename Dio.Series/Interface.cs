using.Colecctions.Generic;

namespace Dio.Series interface I
{
   public interface IRepositorio
   {
       List<T> Lista();

       T RetornoPorID(int id);

       void Insere(T entidade);

       void Exclui(int id);

       void Atualiza(int id, T entidade);

       int PrximoID();
   }
}   
