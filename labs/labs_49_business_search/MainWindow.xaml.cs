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

namespace labs_49_business_search
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Order> orders;
        Order orders1;
        List<Order> searchorders;
        List<int?> employeeID;
        List<int> orderID;
        List<String> customerID;
        List<DateTime?> orderdate;
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
                orders = db.Orders.ToList();
                employeeID = (from e in db.Orders select e.EmployeeID).Distinct().ToList();
            }
            EmployeeIDBox.ItemsSource = employeeID;

            using (var db = new NorthwindEntities())
            {
                orders = db.Orders.ToList();
                orderID = (from o in db.Orders select o.OrderID).Distinct().ToList();
            }
            OrderIDBox.ItemsSource = employeeID;

            using (var db = new NorthwindEntities())
            {
                orders = db.Orders.ToList();
                customerID = (from c in db.Orders select c.CustomerID).Distinct().ToList();
            }
            CustomerIDBox.ItemsSource = customerID;

            using (var db = new NorthwindEntities())
            {
                orders = db.Orders.ToList();
                orderdate = (from or in db.Orders select or.OrderDate).Distinct().ToList();
            }
            OrderDateBox.ItemsSource = orderdate;
        }

        private void EmployeeIDBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int.TryParse((string)EmployeeIDBox.SelectedItem, out int eID);
            int? nullableID = eID;


            using (var db = new NorthwindEntities())
            {
                searchorders = db.Orders.Where(em => em.EmployeeID == nullableID).ToList();
            }

        }

        private void OrderIDBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int.TryParse((string)OrderIDBox.SelectedItem, out int oID);
            using (var db = new NorthwindEntities())
            {
                searchorders = db.Orders.Where(o => o.OrderID == oID).ToList();
            }
        }

        private void CustomerIDBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cID = CustomerIDBox.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                searchorders = db.Orders.Where(c => c.CustomerID == cID.ToString()).ToList();
            }
        }

        private void OrderDateBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var ordate = OrderDateBox.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                searchorders = db.Orders.Where(ord => ord.CustomerID == ordate.ToString()).ToList();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsEditing == false)
            {
                orders1 = (Order)EmployeeIDBox.ItemsSource;
                orders1 = (Order)OrderIDBox.ItemsSource;
                orders1 = (Order)CustomerIDBox.ItemsSource;
                orders1 = (Order)OrderDateBox.ItemsSource;
                ResultsBox.Text = $"\n{orders1.EmployeeID}\n + \n{orders1.OrderID}\n + \n{orders1.CustomerID}\n + \n{orders1.OrderDate}\n";
            }
            IsEditing = false;
        }
    }
}