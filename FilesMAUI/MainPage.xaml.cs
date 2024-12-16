using FilesMAUI.Interfaces;
using FilesMAUI.Modelos;
using FilesMAUI.Repositorio;

namespace FilesMAUI
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUdlaRepository _estudianteUdlaRepository;
        EstudianteUdla estudiante = new EstudianteUdla();
        public MainPage()
        {
            _estudianteUdlaRepository = new EstudianteUDLASQLiteRepository();
            InitializeComponent();



            //estudiante = _estudianteUdlaRepository.DevuelveEstudianteUdla(1);



            BindingContext = estudiante;

        }


/* Cambio no fusionado mediante combinación del proyecto 'FilesMAUI (net8.0-maccatalyst)'
Antes:
        private void GuardaEstudiante_Clicked(object sender, EventArgs e)
        {
Después:
        private void GuardaEstudiante_ClickedAsync(object sender, EventArgs e)
        {
*/
        private async void GuardaEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUdla estudiante = new EstudianteUdla
            {
                Id = 1,
                Nombre = editor_nombre.Text,
                Carrera = editor_carrera.Text,
            };
            bool guardar_estudiante = _estudianteUdlaRepository.CrearEstudianteUdla(estudiante);

            if (guardar_estudiante)
            {
                await DisplayAlert("Alerta", "Todo Posi Ñaño", "OK");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerta", "Negado Ñaño", "OK");
            }
            
        }

    }

}
