using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudSQLite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomersPage : ContentPage
	{
		public CustomersPage()
		{
			InitializeComponent();
			using (var data = new Db())
				ListViewCustomers.ItemsSource = data.GetAllCustomers();
		}

		private void ButtonUpdateClicked(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(CustomerName.Text) ||
				string.IsNullOrWhiteSpace(CustomerEmail.Text))
			{
				DisplayAlert("Erro", "Todos os campos devem ser preenchidos!", "Ok");
				return;
			}
			var customer = new Customer
			{
				Name = CustomerName.Text,
				Email = CustomerEmail.Text
			};
			using (var data = new Db())
			{
				data.InsertCustomer(customer);
				ListViewCustomers.ItemsSource = data.GetAllCustomers();
			}
			CustomerName.Text = "";
			CustomerEmail.Text = "";
		}
	}
}