using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labs_47_snaplabs_businessapplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        Customer customer;
        public bool IsEditing = false;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }
            CustomerID.DisplayMemberPath = "CustomerID";
            CustomerID.ItemsSource = customers;
        }

        private void CustomerID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsEditing == false)
            {
                customer = (Customer)CustomerID.SelectedItem;
                Name.Text = customer.ContactName;
                City.Text = customer.City;
                Company.Text = customer.CompanyName;
            }
            IsEditing = false;
            
            
        }
    }
}
