using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace Assignment3
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        ListSortDirection SortDirection { get; set; }
        public SecondWindow()
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
