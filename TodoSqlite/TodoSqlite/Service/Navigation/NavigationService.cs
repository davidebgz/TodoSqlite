using System;
using System.Collections.Generic;
using System.Text;



namespace TodoSqlite.Service.Navigation
{
    using View;
    using ViewModels;
    public class NavigationService : INavigationService
    {
        private IDictionary<Type, Type> viewModelRouting = new Dictionary<Type, Type>()
        {
            {typeof(TodoListViewModel), typeof(TodoListView) },
            { typeof(TodoItemViewModel),typeof(TodoItemView)}

        };
        public void NavigateBack()
        {
            throw new NotImplementedException();
        }

        public void NavigateTo(Type destinationType, object navigationContext = null)
        {
            throw new NotImplementedException();
        }

        public void NavitateTo<TDestinationViewModel>(object navigationContext = null)
        {
            throw new NotImplementedException();
        }
    }
}
