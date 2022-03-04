using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Syracuse.Mobitheque.Core.ViewModels;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syracuse.Mobitheque.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(NoHistory = true)]
    public partial class SelectLibraryView : MvxContentPage<SelectLibraryViewModel>
    {

        public SelectLibraryView()
        {
            InitializeComponent();
            LibraryPicker.PropertyChanged += PickerPropertyChanged;
        }

        protected override void OnBindingContextChanged()
        {
            (this.DataContext as SelectLibraryViewModel).OnDisplayAlert += SelectLibrary_OnDisplayAlert;
            base.OnBindingContextChanged();
        }
        public async void InvokeCompleted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBarcode.Text) && !this.isnetworkError)
            {
                this.ViewModel.CanSubmit = true;
            }
            else
            {
                this.ViewModel.CanSubmit = false;
            }
        }
        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            this.ViewModel.IsLoading = true;
            try
            {
                var options = new MobileBarcodeScanningOptions
                {
                    AutoRotate = false,
                    UseFrontCameraIfAvailable = false,
                    TryHarder = true
                };

                var overlay = new ZXingDefaultOverlay
                {
                    TopText = "Please scan QR code",
                    BottomText = "Align the QR code within the frame"
                };

                var QRScanner = new ZXingScannerPage(options, overlay);

                await Navigation.PushModalAsync(QRScanner);

                QRScanner.OnScanResult += (result) =>
                {
                    // Stop scanning
                    QRScanner.IsScanning = false;

                    // Pop the page and show the result
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Navigation.PopModalAsync(true);
                        txtBarcode.Text = result.Text;
                        this.ViewModel.CanSubmit = true;
                        this.ViewModel.ValidateHandler(txtBarcode.Text);

                    });


        protected override void OnAppearing()
        {
            this.submitButton.IsEnabled = true;
            base.OnAppearing();
        }

        private void SelectLibrary_OnDisplayAlert(string title, string message, string button) => this.DisplayAlert(title, message, button);

        private void PickerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsEnabled")
            {
                LibraryPicker.TitleColor = LibraryPicker.IsEnabled ? (Color)Application.Current.Resources["PurpleTextColor"] : (Color) Application.Current.Resources["PurpleTextColorTransparente"];
            }
        }

    }
}