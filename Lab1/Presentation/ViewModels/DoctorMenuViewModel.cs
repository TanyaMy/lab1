﻿using GalaSoft.MvvmLight.Command;
using Lab1.Domain.Managers;
using Lab1.Presentation.Models;
using Lab1.Presentation.ViewModels.Common;
using System.Windows.Input;


namespace Lab1.Presentation.ViewModels
{
    public class DoctorMenuViewModel : ViewModelBase
    {
        private readonly IAuthenticationManager _authenticationManager;

        public DoctorMenuViewModel(IAuthenticationManager authenticationManager)
        {
            _authenticationManager = authenticationManager;

            PatientsCommand = new RelayCommand(() => NavigationService.NavigateTo(PageKeys.PatientSearch));
        }

        public ICommand PatientsCommand { get; }
    }
}
