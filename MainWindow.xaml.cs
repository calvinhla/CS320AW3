using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Assignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListSortDirection SortDirection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "1DavePwd" });
            users.Add(new Models.User { Name = "Steve", Password = "2StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password = "3LisaPwd" });
            uxList.ItemsSource = users;
        }

        private void ColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            var columnHeader = e.OriginalSource as GridViewColumnHeader;
            var sortBy = columnHeader.Content;
            
            if (sortBy != null)
            {
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);
                view.SortDescriptions.Clear();

                SortDirection = SortDirection != ListSortDirection.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;                
                view.SortDescriptions.Add(new SortDescription(sortBy.ToString(), SortDirection));                
            }
        }
    }
}
