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

namespace labs_43_database_app
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
            //ListBoxCustomers.DisplayMemberPath = "ContactName";
            ListBoxCustomers.ItemsSource = customers;
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonAdd.Content.ToString() == "Clear")
            {
                TextBoxID.Text = "";
                TextBoxName.Text = "";
                TextBoxCompany.Text = "";
                TextBoxCity.Text = "";
                TextBoxCountry.Text = "";
                ButtonAdd.Content = "Add";
            }
            else if (TextBoxID.Text != null && TextBoxCompany.Text != null)
            {
                MessageBox.Show("New Customer Added");
                var newCustomer = new Customer() { };
                newCustomer.CustomerID = TextBoxID.Text;
                newCustomer.ContactName = TextBoxName.Text;
                newCustomer.CompanyName = TextBoxCompany.Text;
                newCustomer.City = TextBoxCity.Text;
                newCustomer.Country = TextBoxCountry.Text;

                ListBoxCustomers.ItemsSource = null;
                //add new customer
                using (var db = new NorthwindEntities())
                {
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
                    customers = db.Customers.ToList();
                }
                ListBoxCustomers.ItemsSource = customers;
                ButtonAdd.Content = "Clear";

            }
           
        }
        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            IsEditing = true;
            if (ButtonEdit.Content.ToString() == "Edit")
            {
                if (customer != null)
                {
                    MessageBox.Show("Now you can edit");
                    
                }
                TextBoxID.IsEnabled = true;
                TextBoxName.IsEnabled = true;
                TextBoxCompany.IsEnabled = true;
                TextBoxCity.IsEnabled = true;
                TextBoxCountry.IsEnabled = true;
                TextBoxID.Background = Brushes.White;
                TextBoxName.Background = Brushes.White;
                TextBoxCompany.Background = Brushes.White;
                TextBoxCity.Background = Brushes.White;
                TextBoxCountry.Background = Brushes.White;
                ButtonEdit.Content = "Save";

            }
            else if (ButtonEdit.Content.ToString() == "Save")
            {
                if (customer != null)
                {
                    using (var db = new NorthwindEntities())
                    {
                        var customerToEdit = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                        MessageBox.Show($"Changes to {customerToEdit.CustomerID} will be saved");
                        customerToEdit.ContactName = TextBoxName.Text;
                        customerToEdit.CompanyName = TextBoxCompany.Text;
                        customerToEdit.City = TextBoxCity.Text;
                        customerToEdit.Country = TextBoxCountry.Text;
                        db.SaveChanges();
                        //refresh the view
                        ListBoxCustomers.ItemsSource = null;
                        customers = db.Customers.ToList();
                        ListBoxCustomers.ItemsSource = customers;
                    }
                   
                }
                
                
            }
            
           
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if(ButtonDelete.Content.ToString() == "Delete")
            {
                if (customer == null)
                {
                    MessageBox.Show("No Customer Selected");
                    return;
                }
                ButtonDelete.Content = "Confirm?";
                ButtonDelete.Background = Brushes.Red;
            }
            else if(ButtonDelete.Content.ToString() == "Confirm?")
            {
                //find record by ID and delete it
                using (var db = new NorthwindEntities())
                {
                    var customerToDelete = db.Customers.Find(customer.CustomerID);
                    db.Customers.Remove(customerToDelete);
                    db.SaveChanges();

                    ListBoxCustomers.ItemsSource = null;
                    customers = db.Customers.ToList();
                    ListBoxCustomers.ItemsSource = customers;

                }
            }
           
            //MessageBox.Show("Are you sure you want to delete this database entry?");
            
        }

        private void ListBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsEditing == false)
            {
                ButtonAdd.Content = "Clear";
                customer = (Customer)ListBoxCustomers.SelectedItem;
                ListBoxLog.Items.Insert(0, " ");
                ListBoxLog.Items.Insert(0, DateTime.Now);
                ListBoxLog.Items.Insert(0, "Customer Selected");
                ListBoxLog.Items.Insert(0, $"{customer.CustomerID}, {customer.ContactName} from {customer.City}");
                TextBoxID.Text = customer.CustomerID;
                TextBoxName.Text = customer.ContactName;
                TextBoxCompany.Text = customer.CompanyName;
                TextBoxCity.Text = customer.City;
                TextBoxCountry.Text = customer.Country;
            }
            IsEditing = false;
            
        }

       
    }
}
