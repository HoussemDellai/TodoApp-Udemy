using System;
using TodoApp.Views;
using Xamarin.Forms;

namespace TodoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTodoPage());
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var todo = e.Item as Todo;

            Navigation.PushAsync(new EditTodoPage(todo));
        }
    }
}
