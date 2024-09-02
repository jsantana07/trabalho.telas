using Controles;
using Microsoft.Maui.Controls;
using Modelos;
using trabalho.equipe.Modelos;

namespace trabalho.equipe
{
    public partial class ListaMateriaprimaPage : ContentPage
    {
        MateriaprimaControle materiaprimaControle = new MateriaprimaControle();


        public ListaMateriaprimaPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListaMateriaprima.ItemsSource = materiaprimaControle.LerTodos();
        }


        private async void CadastrarCostClicado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MateriaPrimaPage());

        }
        async void QuandoSelecionarCostNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CostureiraPage();
            page.materiaprima = e.SelectedItem as Materiaprima;
            await Navigation.PushAsync(page);
        }
    }
} 