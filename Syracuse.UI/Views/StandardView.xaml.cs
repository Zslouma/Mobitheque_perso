using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Syracuse.Mobitheque.Core.Models;
using Syracuse.Mobitheque.Core.ViewModels;
using Xamarin.Forms;

namespace Syracuse.Mobitheque.UI.Views
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true)]
    public partial class StandardView : MvxContentPage<StandardViewModel>
    {
        public StandardView()
        {
            InitializeComponent();
        }
        protected override void OnBindingContextChanged()
        {
            (this.DataContext as StandardViewModel).OnDisplayAlert += StandardViewModel_OnDisplayAlert;
            base.OnBindingContextChanged();
        }
        private async void ResultsList_ItemTapped(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                var item = e.CurrentSelection[0] as Result;
                await this.ViewModel.GoToDetailView(item);
            }
            else
            {
                await this.DisplayAlert("Erreur", "Une erreur est survenue", "Ok");
            }
        }

     

        private void StandardViewModel_OnDisplayAlert(string title, string message, string button) => this.DisplayAlert(title, message, button);
    }
}