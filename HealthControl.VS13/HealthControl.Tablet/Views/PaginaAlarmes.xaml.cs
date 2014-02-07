using Windows.UI.Xaml.Navigation;
using HealthControl_Tablet.Common;

namespace HealthControl.Tablet.Views
{
    
    public sealed partial class PaginaAlarmes
    {

        private readonly NavigationHelper _navigationHelper;
        private readonly ObservableDictionary _defaultViewModel = new ObservableDictionary();

      
        public ObservableDictionary DefaultViewModel
        {
            get { return this._defaultViewModel; }
        }

       
        public NavigationHelper NavigationHelper
        {
            get { return this._navigationHelper; }
        }


        public PaginaAlarmes()
        {
            InitializeComponent();
            _navigationHelper = new NavigationHelper(this);
            _navigationHelper.LoadState += navigationHelper_LoadState;
            _navigationHelper.SaveState += navigationHelper_SaveState;
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}
