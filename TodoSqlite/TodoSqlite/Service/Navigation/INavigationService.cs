using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSqlite.Service.Navigation
{
    public interface INavigationService
    {
        void NavitateTo<TDestinationViewModel>(object navigationContext = null);

        void NavigateTo(Type destinationType, object navigationContext = null);

        void NavigateBack();

    }
}
