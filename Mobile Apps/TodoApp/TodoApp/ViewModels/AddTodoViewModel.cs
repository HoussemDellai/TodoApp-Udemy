using System;
using System.Windows.Input;
using TodoApp.Services;
using Xamarin.Forms;

namespace TodoApp.ViewModels
{
    public class AddTodoViewModel
    {
        private DataService _dataService = new DataService();

        public Todo SelectedTodo { get; set; }

        public ICommand SendTodoCommand => new Command(async () =>
        {
            SelectedTodo.UpdatedAt = DateTime.UtcNow;

            await _dataService.PostTodo(SelectedTodo);
        });

        public AddTodoViewModel()
        {
            SelectedTodo = new Todo();
        }
    }
}
