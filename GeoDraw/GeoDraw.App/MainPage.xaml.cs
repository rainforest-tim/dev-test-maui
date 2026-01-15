using GeoDraw.App.ViewModels;

namespace GeoDraw.App
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _vm;

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();

            _vm = vm;
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _vm.LoadAsync();
        }

        private void OnSendClicked(object? sender, EventArgs e)
        {

        }

        private void OnClearClicked(object? sender, EventArgs e)
        {

        }
    }
}
