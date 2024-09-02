namespace trabalho.equipe;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
	private async void OnCadastrarMateriaPrimaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaMateriaprimaPage());
        }

        private async void OnCadastrarFornecedorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FornecedorPage());
        }

        private async void OnAcompanharVendasClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VendasPage());
        }

        private async void OnGerenciarClientesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaClientesPage());
        }

        private async void OnCadastrarCostureiraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaCostureiraPage());
        }
         private async void OnTransportadoraClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransportadoraPage());
        }
    }




