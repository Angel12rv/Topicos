

using SQLite;
using AgendaPersonal.Datos;
namespace AgendaPersonal
{
    public partial class App : Application
    {
        public static ContactoDatabase Database { get; } = new ContactoDatabase();
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();


        }
        /* protected override Window CreateWindow(IActivationState? activationState)
         {
             return new Window(new LoginPage());
         } */
    }
}