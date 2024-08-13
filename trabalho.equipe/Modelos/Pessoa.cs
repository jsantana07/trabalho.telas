  
namespace Modelos;
public class Pessoa : Registro
{
   public string nome{ get; set; }
  public string endereço{ get; set; }
   public string telefone{ get; set; }

   
        [BsonId]
  public int id{ get; set; }

}




 

























 