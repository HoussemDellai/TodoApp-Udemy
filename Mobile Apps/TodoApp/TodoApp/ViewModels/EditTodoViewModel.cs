using System;
using System.Windows.Input;
using TodoApp.Services;
using Xamarin.Forms;

namespace TodoApp.ViewModels
{
    public class EditTodoViewModel
    {
        private DataService _dataService = new DataService();

        public Todo SelectedTodo { get; set; }

        public ICommand EditTodoCommand => new Command(async () =>
        {
            SelectedTodo.UpdatedAt = DateTime.UtcNow;

            await _dataService.PutTodo(SelectedTodo.Id, SelectedTodo);
        });

        public ICommand DeleteTodoCommand => new Command(async () =>
        {
            SelectedTodo.UpdatedAt = DateTime.UtcNow;

            await _dataService.DeleteTodo(SelectedTodo.Id);
        });
    }
}
