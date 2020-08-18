using BelajarCRUDWPFAldyCahya.Context;
using BelajarCRUDWPFAldyCahya.Model;
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

namespace BelajarCRUDWPFAldyCahya
{
    /// <summary>
    /// Interaction logic for CtrlTransaction.xaml
    /// </summary>
    public partial class CtrlTransaction : UserControl
    {
        MyContext context = new MyContext();
        public CtrlTransaction()
        {
            InitializeComponent();
            dataGridTransaction.ItemsSource = context.Transactions.ToList();
        }
        private void customizedDesign()
        {

        }

        private void btnSave_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                if(txtId.Text.Equals(""))
                {
                    MessageBox.Show("data must be inputed!", "Information",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Do you want to save this data?", "Confirmation",
                        MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if(result == MessageBoxResult.Yes)
                        {
                        var input = new Transaction()
                        {
                            Id = txtId.Text,
                            OrderDate = dateOrderDate.SelectedDate.Value
                        };
                        context.Transactions.Add(input);
                        context.SaveChanges();
                        txtId.Text = "";
                        dateOrderDate.SelectedDate = null;
                        dataGridTransaction.ItemsSource = context.Transactions.ToList();
    
                        }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Input Failed!");
            }
        }

        private void dataGridTransaction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var transaction = dataGridTransaction.SelectedItem as Transaction;
            txtId.Text = transaction.Id;
            dateOrderDate.SelectedDate = transaction.OrderDate;
            dataGridTransaction.ItemsSource = context.Suppliers.ToList();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Equals(""))
                {
                    MessageBox.Show("data must be selected", "Information",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }

                else
                {
                    MessageBoxResult update = MessageBox.Show("the data will be updated",
                        "Confirmation",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Information);
                    if (update == MessageBoxResult.Yes)
                    {
                        string Id = txtId.Text;
                        var transaction = context.Transactions.Find(Id);
                        transaction.OrderDate = dateOrderDate.SelectedDate.Value;
                        context.SaveChanges();
                        dataGridTransaction.ItemsSource = context.Transactions.ToList();
                        txtId.Text = "";
                        dateOrderDate.SelectedDate = null;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("please, select the data");
                MessageBox.Show(err.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Equals(""))
                {
                    MessageBox.Show("data must be selected", "Information",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }

                else
                {
                    MessageBoxResult delete = MessageBox.Show("the data will be deleted",
                        "Confirmation",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Information);
                    if (delete == MessageBoxResult.Yes)
                    {
                        string Id = txtId.Text;
                        var supplier = context.Transactions.Find(Id);
                        context.Transactions.Remove(supplier);
                        context.SaveChanges();
                        dataGridTransaction.ItemsSource = context.Suppliers.ToList();
                        dataGridTransaction.SelectedItem = null;
                        txtId.Text = "";
                        dateOrderDate.SelectedDate = null;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("please, select the data");
                MessageBox.Show(er.Message);
            }
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredData = context.Transactions.Where(Q => Q.Id.ToString().Contains(txtSearch.Text));
            dataGridTransaction.ItemsSource = filteredData;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var filteredData = context.Transactions.Where(Q => Q.Id.ToString().Contains(txtSearch.Text));
            dataGridTransaction.ItemsSource = filteredData;

        }

        private void DataGridSupplier_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGridTransaction.SelectedItem != null)
            {
                var item = dataGridTransaction.SelectedItem as Transaction;
                txtId.Text = Convert.ToString(item.Id);
                dateOrderDate.SelectedDate = item.OrderDate;
            }
        }

        private void BtnDelete2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MessageBoxResult delete = MessageBox.Show("the data will be deleted",
                    "Confirmation",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information);
                if (delete == MessageBoxResult.Yes)
                {
                    string Id = txtId.Text;
                    var transaction = context.Transactions.Find(Id);
                    context.Transactions.Remove(transaction);
                    context.SaveChanges();
                    dataGridTransaction.ItemsSource = context.Transactions.ToList();
                    dataGridTransaction.SelectedItem = null;
                    txtId.Text = "";
                    dateOrderDate.SelectedDate = null;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("please, select the data");
                MessageBox.Show(er.Message);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtSearch.Text = "";
            dateOrderDate.SelectedDate = null;
            dataGridTransaction.SelectedItem = null;
            dataGridTransaction.ItemsSource = context.Transactions.ToList();
        }

        private void dateOrderDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
