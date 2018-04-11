using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoApp.Services;
using Xamarin.Forms;

namespace TodoApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Todo> _todos;
        private DataService _dataService = new DataService();
        private bool _isRefreshing;

        public List<Todo> Todos
        {
            get { return _todos; }
            set
            {
                _todos = value;
                OnPropertyChanged();
            }
        }

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand => new Command(async() =>
        {
            await GetTodoes();
        });

        public MainViewModel()
        {
            GetTodoes();
        }

        private async Task GetTodoes()
        {
            IsRefreshing = true;

            Todos = await _dataService.GetTodos();

            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
