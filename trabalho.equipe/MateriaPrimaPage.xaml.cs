using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.equipe
{
    public partial class MateriaPrimaPage: ContentPage
    {
         Controles.MateriaprimaControle materiaprimaControle = new Controles.MateriaprimaControle();
          public Materiaprima materiaprima;

        public MateriaPrimaPage()
        {
            InitializeComponent();
        }
         private async void OnEnviarClicked(object sender, EventArgs e)
        {
            
              {
                var materiaprima = new Materiaprima(); // Usando 'Cliente' com maiúscula
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    materiaprima.Id = int.Parse(IdLabel.Text);
                else
                    materiaprima.Id = 0;
                materiaprima.Nome = NomeEntry.Text;
                materiaprima.Endereço = EnderecoEntry.Text; // Corrigido para 'Endereco'
                materiaprima.Quantidade = QuantidadeEntry.Text;
                materiaprimaControle.CriarOuAtualizar(materiaprima); // Adicionado 'await' e corrigido 'CriarOuAtualizar'

                await DisplayAlert("Cadastro", "Matria prima cadastrada com sucesso!", "OK");
            }
        }
    }
}
