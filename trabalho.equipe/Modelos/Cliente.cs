
using LiteDB;
using Modelos;

namespace trabalho.equipe.Modelos
{
    public class Cliente : Registro
    {
[BsonId]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Gmail { get; set; }
        public string CPF { get; set; }
    }
}


