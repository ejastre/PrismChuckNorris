﻿using System;
using Prism.Navigation;
using Prism.Services;

namespace PrismChuckNorris.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {

        protected MenuViewModel(INavigationService navigationService,
                IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {


        }


    }
}
