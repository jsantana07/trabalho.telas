using LiteDB;

namespace Modelos;

public class Materiaprima:Registro
{
     public string nome{ get; set; }
      public string telefone{ get; set; }
     public string endereço{ get; set; }
     public string quantidade{ get; set; }

        [BsonId]
      public int Id{ get; set; }

   
}