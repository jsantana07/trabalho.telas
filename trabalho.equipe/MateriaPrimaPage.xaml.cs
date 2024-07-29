using Microsoft.Maui.Controls;

namespace trabalhojulia07
{
    public partial class MateriaPrima: ContentPage
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }
         private void OnEnviarClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Enviado", "Dados enviados com sucesso!", "OK");
        }
    }
}
