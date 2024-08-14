
using LiteDB;

namespace Modelos;
public class Pessoa : Registro
{
   [BsonId]
   public int Id{ get; set; }
   public string nome{ get; set; }
  public string endereço{ get; set; }
   public string telefone{ get; set; }

}




 

























 