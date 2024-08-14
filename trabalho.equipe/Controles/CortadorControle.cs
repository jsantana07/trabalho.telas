using Modelos;

namespace Controles;

public class CortadorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CortadorControle() : base()
  {
    NomeDaTabela = "Clientes";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCliente)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual List<Cortador>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Cortador>(NomeDaTabela);
    return new List<Cortador>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    collection.Delete(idCortador);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Cortador Cortador)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    collection.Upsert(Cortador);
  }

  //----------------------------------------------------------------------------
}