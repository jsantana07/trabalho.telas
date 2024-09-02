using LiteDB;

namespace Modelos;

public class Materiaprima:Registro
{
     public string Nome{ get; set; }
      public string telefone{ get; set; }
     public string Endereço{ get; set; }
     public string Quantidade{ get; set; }

        [BsonId]
      public int Id{ get; set; }

   
}