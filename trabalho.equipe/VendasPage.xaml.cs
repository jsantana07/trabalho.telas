using Microsoft.Maui.Controls;

namespace trabalho.equipe
{
    public partial class VendasPage: ContentPage
    {
        public VendasPage()
        {
            InitializeComponent();
        }
    
        private async void OnVenderClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirmação", "Tem certeza que deseja vender?", "Sim", "Não");
            if (answer)
            {
                // Implementar a lógica de venda aqui
                await DisplayAlert("Vendido", "Produto vendido com sucesso!", "OK");
            }
        }
    }
}