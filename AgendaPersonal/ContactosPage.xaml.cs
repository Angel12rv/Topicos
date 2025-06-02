using System.Collections.ObjectModel;
using AgendaPersonal.Modelos;

namespace AgendaPersonal;

public partial class ContactosPage : ContentPage
{
    public ContactosPage()
    {
        InitializeComponent();
        LoadContactos();
    }

    private async void LoadContactos()
    {
        try
        {
            var contactos = await App.Database.ObtenerContactosAsync();
            ContactosCollectionView.ItemsSource = new ObservableCollection<Contacto>(contactos);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudieron cargar los contactos: {ex.Message}", "OK");
        }
    }

    private async void OnEliminarClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is Contacto contacto)
        {
            bool confirmar = await DisplayAlert(
                "Confirmar",
                $"¿Eliminar a {contacto.Nombre} permanentemente?",
                "Sí", "Cancelar");

            if (confirmar)
            {
                await App.Database.EliminarContactoAsync(contacto);
                LoadContactos(); // Recarga la lista actualizada
            }
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadContactos();
    }
}