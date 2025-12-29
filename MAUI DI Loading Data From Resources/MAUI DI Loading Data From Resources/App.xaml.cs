namespace MAUI_DI_Loading_Data_From_Resources
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "MAUI DI Loading Data From Resources" };
        }
    }
}
