using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradeCatalog.Model;
using Microsoft.EntityFrameworkCore;

namespace TradeCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApplicationDbContext _context;
        private ICollectionView _productCollectionView;
        private List<Product> _products;
        private bool _sortAscending = true;

        public MainWindow()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            LoadData();
        }

        private void LoadData()
        {
            _products = _context.Products.Include(p => p.CategoryNavigation).ToList();
            _productCollectionView = CollectionViewSource.GetDefaultView(_products);
            ProductsListView.ItemsSource = _productCollectionView;
            UpdateStatusText();
            LoadManufacturers();
        }

        private void UpdateStatusText()
        {
            StatusTextBlock.Text = $"{_productCollectionView.Cast<Product>().Count()} из {_products.Count}";
        }

        private void LoadManufacturers()
        {
            var manufacturers = _products.Select(p => p.Manufacturer).Distinct().ToList();
            manufacturers.Insert(0, "Все производители");
            ManufacturerComboBox.ItemsSource = manufacturers;
            ManufacturerComboBox.SelectedIndex = 0;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilter();
        }

        private void ManufacturerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilter();
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            _sortAscending = !_sortAscending;
            ApplySorting();
        }

        private void ApplyFilter()
        {
            _productCollectionView.Filter = item =>
            {
                if (item is Product product)
                {
                    var searchText = SearchTextBox.Text.ToLower();
                    var manufacturer = ManufacturerComboBox.SelectedItem as string;

                    var matchesSearch = (product.Name?.ToLower().Contains(searchText) ?? false) ||
                                        (product.Manufacturer?.ToLower().Contains(searchText) ?? false) ||
                                        (product.Cost?.ToString().ToLower().Contains(searchText) ?? false) ||
                                        (product.QuantityInStock?.ToString().ToLower().Contains(searchText) ?? false);

                    var matchesManufacturer = manufacturer == "Все производители" || product.Manufacturer == manufacturer;

                    return matchesSearch && matchesManufacturer;
                }
                return false;
            };

            _productCollectionView.Refresh();
            UpdateStatusText();
        }

        private void ApplySorting()
        {
            _productCollectionView.SortDescriptions.Clear();
            _productCollectionView.SortDescriptions.Add(new SortDescription("Cost", _sortAscending ? ListSortDirection.Ascending : ListSortDirection.Descending));
            _productCollectionView.Refresh();
        }
    }
}