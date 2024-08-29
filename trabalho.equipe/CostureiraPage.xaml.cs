using Microsoft.Maui.Controls;
using Modelos;

namespace trabalho.equipe
{
    public partial class CostureiraPage : ContentPage
    {
        public Costureira costureira;
        Controles.CostureiraControle costureiraControle = new Controles.CostureiraControle();
        public CostureiraPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (costureira != null)
            {
                IdLabel.Text = costureira.Id.ToString();
                NomeEntry.Text = costureira.nome;
                EnderecoEntry.Text = costureira.endereço;
            }
        }

        private async void OnCadastrarCostureiraClicked(object sender, EventArgs e) // Adicionado 'async'
        {
            //if (await VerificaSeDadosEstaoCorretos())
            {
                var costureira = new Costureira(); // Usando 'Cliente' com maiúscula
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    costureira.Id = int.Parse(IdLabel.Text);
                else
                    costureira.Id = 0;
                costureira.nome = NomeEntry.Text;
                costureira.endereço = EnderecoEntry.Text; // Corrigido para 'Endereco'
                costureira.CPF = CPFEntry.Text;
                costureiraControle.CriarOuAtualizar(costureira); // Adicionado 'await' e corrigido 'CriarOuAtualizar'

                await DisplayAlert("Cadastro", "Cliente cadastrado com sucesso!", "OK");
            }
        }


    }
}

