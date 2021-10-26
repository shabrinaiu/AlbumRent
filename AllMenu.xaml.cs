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

namespace DatabaseConnection_EntityFramework
{
    /// <summary>
    /// Interaction logic for AllMenu.xaml
    /// </summary>
    public partial class AllMenu : Page
    {

        private ApplicationDbContext ApplicationDbContext;

        public AllMenu(ApplicationDbContext db)
        {
            InitializeComponent();
            ApplicationDbContext = db;
            RefreshDataAlbum();
            RefreshDataCustomer();
            RefreshDataTransaction();
        }

        private void TransactionDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var row = sender as DataGrid;

            if (row.SelectedItem is RentTransaction transaction)
            {
                TransactionIdTextBox.Text = transaction.Id;
            }
        }

        private void CustomerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var row = sender as DataGrid;

            if (row.SelectedItem is Customer customer)
            {
                CustomerIdTextBox.Text = customer.Id;
            }
        }

        private void AlbumDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var row = sender as DataGrid;
            
            if (row.SelectedItem is Album album)
            {
                AlbumIdTextBox.Text = album.Id;
                AlbumNameTextBox.Text = album.Name;
                AlbumBandTextBox.Text = album.Band;
            }
        }

        private void CreateAlbum_Click(object sender, RoutedEventArgs e)
        {
            var album = new Album() { Id = AlbumIdTextBox.Text, Name = AlbumNameTextBox.Text, Band = AlbumBandTextBox.Text };
            ApplicationDbContext.Add(album);
            ApplicationDbContext.SaveChanges();
            ClearTextBoxAlbum();
            RefreshDataAlbum();
        }

        private void DeleteAlbum_Click(object sender, RoutedEventArgs e)
        {
            var album = ApplicationDbContext.Albums.First(t => t.Id == AlbumIdTextBox.Text);
            ApplicationDbContext.Albums.Remove(album);
            ApplicationDbContext.SaveChanges();
            ClearTextBoxAlbum();
            RefreshDataAlbum();
        }

        private void UpdateAlbum_Click(object sender, RoutedEventArgs e)
        {
            var album = ApplicationDbContext.Albums.First(t => t.Id == AlbumIdTextBox.Text);
            album.Name = AlbumNameTextBox.Text;
            album.Band = AlbumBandTextBox.Text;
            ApplicationDbContext.Albums.Update(album);
            ApplicationDbContext.SaveChanges();
            ClearTextBoxAlbum();
            RefreshDataAlbum();
        }

        private void ClearTextBoxAlbum()
        {
            AlbumIdTextBox.Text = "Album Id";
            AlbumNameTextBox.Text = "Album Name";
            AlbumBandTextBox.Text = "Album Band";
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            var customer = ApplicationDbContext.Customers.First(t => t.Id == CustomerIdTextBox.Text);
            ApplicationDbContext.Customers.Remove(customer);
            ApplicationDbContext.SaveChanges();
            ClearTextBoxCustomer();
            RefreshDataCustomer();
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer() { Id = CustomerIdTextBox.Text, Name = CustomerNameTextBox.Text };
            ApplicationDbContext.Add(customer);
            ApplicationDbContext.SaveChanges();
            ClearTextBoxCustomer();
            RefreshDataCustomer();
        }

        private void ClearTextBoxCustomer()
        {
            CustomerIdTextBox.Text = "Customer Id";
            CustomerNameTextBox.Text = "Customer Name";
        }

        private void DeleteTransaction_Click(object sender, RoutedEventArgs e)
        {
            var transaction = ApplicationDbContext.Transactions.First(t => t.Id == TransactionIdTextBox.Text);
            ApplicationDbContext.Transactions.Remove(transaction);
            ApplicationDbContext.SaveChanges();
            ClearTextBoxTransaction();
            RefreshDataTransaction();
        }

        private void AddTransaction_Click(object sender, RoutedEventArgs e)
        {
            var transaction = new RentTransaction() { Id = TransactionIdTextBox.Text, UserName = TransactionNameTextBox.Text, AlbumId = TransactionAlbumIdTextBox.Text, StatusRent = TransactionStatusTextBox.Text };
            ApplicationDbContext.Add(transaction);
            ApplicationDbContext.SaveChanges();
            ClearTextBoxTransaction();
            RefreshDataTransaction();
        }

        private void ClearTextBoxTransaction()
        {
            TransactionIdTextBox.Text = "Transaction Id";
            TransactionNameTextBox.Text = "Transaction Name";
            TransactionAlbumIdTextBox.Text = "Transaction Album ";
            TransactionStatusTextBox.Text = "Transaction Status";
        }
        private void RefreshDataTransaction()
        {
            var transactions = ApplicationDbContext.Transactions.ToList();
            TransactionDataGrid.ItemsSource = transactions;
        }

        private void RefreshDataCustomer()
        {
            var customers = ApplicationDbContext.Customers.ToList();
            CustomerDataGrid.ItemsSource = customers;
        }

        private void RefreshDataAlbum()
        {
            var albums = ApplicationDbContext.Albums.ToList();
            AlbumDataGrid.ItemsSource = albums;
        }
    }
}
