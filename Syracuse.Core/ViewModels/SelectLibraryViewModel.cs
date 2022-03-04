using MvvmCross.Commands;
using MvvmCross.Navigation;
using Newtonsoft.Json;
using Syracuse.Mobitheque.Core.Models;
using Syracuse.Mobitheque.Core.Services.Files;
using Syracuse.Mobitheque.Core.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syracuse.Mobitheque.Core.ViewModels
{
    public class SelectLibraryViewModel : BaseViewModel
    {
        private readonly IDepartmentService departmentService;
        private readonly IGeolocationService geolocationService;
        private readonly IMvxNavigationService navigationService;
        private Library[] librariesSelected;
        private string[] departmentsPickerSource;
        public string[] DepartmentsPickerSource
        {
            get => this.departmentsPickerSource;
            set => SetProperty(ref this.departmentsPickerSource, value);
        }

        private bool isAnyLibrarySelected;
        public bool IsAnyLibrarySelected
        {
            get => this.isAnyLibrarySelected;
            set => SetProperty(ref this.isAnyLibrarySelected, value);
        }

        private int departmentsPickerIndex = -1;
        public int DepartmentsPickerIndex
        {
            get => this.departmentsPickerIndex;
            set {
                SetProperty(ref this.departmentsPickerIndex, value);
                this.RaisePropertyChanged(nameof(ButtonColor));
                Task.Run(async () => await this.ChangeLibraries());
            }
        }

        private string[] librariesPickerSource;
        public string[] LibrariesPickerSource
        {
            get => this.librariesPickerSource;
            set => SetProperty(ref this.librariesPickerSource, value);
        }

        private int librariesPickerIndex = -1;
        public int LibrariesPickerIndex
        {
            get => this.librariesPickerIndex;
            set
            {
                SetProperty(ref this.librariesPickerIndex, value);
                this.RaisePropertyChanged(nameof(ButtonColor));
                this.RaisePropertyChanged(nameof(TextColor));
            }
        }


        public async Task ValidateHandler( string url)
        {
            get
            {
                this.validateCommand = this.validateCommand ?? new MvxAsyncCommand(ValidateHandler);
                return this.validateCommand;
            }
        }

        private async Task ValidateHandler()
        {
            if (this.LibrariesPickerIndex == -1 || this.DepartmentsPickerIndex == -1)
            {
                this.DisplayAlert("Erreur", "Veuillez selectionner un département et une librarie valide", "OK");
                return;
            }
            CookiesSave opt = new CookiesSave();

                    this.IsLoading = false;
                    LoginParameters loginParameters = new LoginParameters(this.Librarie.Config.ListSSO, opt);
                    await this.navigationService.Navigate<LoginViewModel, LoginParameters>(loginParameters);
                }
                catch (Exception ex)
                {
                    this.IsLoading = false;
                    this.DisplayAlert("Erreur", "Une erreur est survenue lors de la recupération des données de votre établisment", "OK");
                    this.CanSubmit = false;
                }

            if (departments == null)
            {
                Exception exception = new Exception("Unable to check departments.");
                throw exception;
            }

            if (libraries == null)
            {
                this.IsLoading = false;
                this.DisplayAlert("Erreur", "Veuillez selectionner un QRcode ou une url valide", "OK");
                this.CanSubmit = false;
            }

            Library[] library = Array.FindAll(libraries,
                element => element.DepartmentCode == departments[this.departmentsPickerIndex].Code);

            if (library == null)
            {
                this.IsAnyLibrarySelected = false;
                this.LibrariesPickerIndex = -1;
                Exception exception = new Exception("Il n'y a pas de librarie dans ce département.");
                throw exception;
            }
            var PickerSource = new string[library.Length];

            for (int i = 0; i < library.Length; i++)
            {
                PickerSource[i] = library[i].Name;
            }
            this.LibrariesPickerSource = PickerSource;
            this.librariesSelected = library;
            this.IsAnyLibrarySelected = true;
            await this.RaiseAllPropertiesChanged();
            if (library.Length == 1)
            {
                this.LibrariesPickerIndex = 0;
            }
            await this.RaiseAllPropertiesChanged();
        }

        public string ButtonColor => this.LibrariesPickerIndex != -1 && this.DepartmentsPickerIndex != -1 ? "#0066ff" : "#EAEAEA";

        public string TextColor => this.LibrariesPickerIndex != -1 && this.DepartmentsPickerIndex != -1 ? "White" : "#0066ff";

        private readonly IRequestService requestService;
            
        public SelectLibraryViewModel(IGeolocationService geolocationService,
                                      IDepartmentService departmentService,
                                      IMvxNavigationService navigationService,
                                      IRequestService requestService)
        {
            this.departmentService = departmentService;
            this.geolocationService = geolocationService;
            this.navigationService = navigationService;
            this.requestService = requestService;
            this.isAnyLibrarySelected = false;

        }

        public override Task Initialize()
        {
            this.ManageDepartments();
            return base.Initialize();
        }
        private async Task ManageDepartments()
        {
            Department[] departments = await this.departmentService.GetDepartments();

            if (departments == null) {
                Exception exception = new Exception("Unable to find departments.");
                throw exception;
            }

            var PickerSource = new string[departments.Count()];

            for (int i = 0; i < departments.Count(); i++)
            {
                PickerSource[i] = $"{departments[i].Code} - {departments[i].Name}";
            }
            this.DepartmentsPickerSource = PickerSource;
        }

    }
}
