using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Syncfusion.SfAutoComplete.XForms;
using Syracuse.Mobitheque.Core.Models;
using Syracuse.Mobitheque.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syracuse.Mobitheque.UI.Views
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = true)]
    public partial class StandardView : MvxContentPage<StandardViewModel>
    {
        public StandardView()
        {
            InitializeComponent();
        }
        private async void ResultsList_ItemTapped(object sender, System.EventArgs e)
        {
            var frm = (Frame)sender;
            TapGestureRecognizer gst = (TapGestureRecognizer)frm.GestureRecognizers[0];
            var item = gst.CommandParameter as Result;
            await this.ViewModel.GoToDetailView(item);
        }

       

    }
}