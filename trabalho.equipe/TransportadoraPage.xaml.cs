using Microsoft.Maui.Controls;

namespace trabalho.equipe
{
    public partial class TransportadoraPage : ContentPage
    {
        public TransportadoraPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            ConfirmationDialog.IsVisible = true;
        }

        private void OnYesClicked(object sender, EventArgs e)
        {
            // Handle confirmation and submission logic here
            ConfirmationDialog.IsVisible = false;
            DisplayAlert("Success", "Form submitted successfully!", "OK");
        }

        private void OnNoClicked(object sender, EventArgs e)
        {
            ConfirmationDialog.IsVisible = false;
        }
    }
}
