using Controles;
using Microsoft.Maui.Controls;
using trabalho.equipe.Modelos;

namespace trabalho.equipe
{
    public partial class ListaClientesPage : ContentPage
    {
        ClienteControle clienteControle = new ClienteControle();


        public ListaClientesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListaClientes.ItemsSource = clienteControle.LerTodos();
        }


        private async void CadastrarClicado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientesPage());

        }
        async void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new ClientesPage();
            page.cliente = e.SelectedItem as Cliente;
            await Navigation.PushAsync(page);
        }
    }
} 