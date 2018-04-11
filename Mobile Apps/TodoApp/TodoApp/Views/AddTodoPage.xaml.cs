using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTodoPage : ContentPage
	{
		public AddTodoPage ()
		{
			InitializeComponent ();
		}
	}
}