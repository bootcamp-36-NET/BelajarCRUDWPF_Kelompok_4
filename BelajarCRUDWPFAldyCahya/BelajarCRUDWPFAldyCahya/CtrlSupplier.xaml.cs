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
    /// Interaction logic for CtrlSupplier.xaml
    /// </summary>
    public partial class CtrlSupplier : UserControl
    {
        MyContext myContext = new MyContext();
        public CtrlSupplier()
        {
            InitializeComponent();
            dataGrid.ItemsSource = myContext.Suppliers.ToList();
        }
        private void customizeDesign()
        {
            //panelSubMenuPanel.Visibility;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("data must be inputed", "Information",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Do you want to save this data?",
                        "Confirmation",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        var input = new Supplier()
                        {
                            Name = txtName.Text,
                            JoinDate = dateJoinDate.SelectedDate.Value
                        };
                        myContext.Suppliers.Add(input);
                        myContext.SaveChanges();
                        txtName.Text = "";
                        dataGrid.ItemsSource = myContext.Suppliers.ToList();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("input failed");
            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var supplier = dataGrid.SelectedItem as Supplier;
            txtName.Text = supplier.Name;
            txtId.Text = supplier.Id;
            dateJoinDate.SelectedDate = supplier.JoinDate;
            dataGrid.ItemsSource = myContext.Suppliers.ToList();
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
                        var supplier = myContext.Suppliers.Find(Id);
                        supplier.Name = txtName.Text;
                        supplier.JoinDate = dateJoinDate.SelectedDate.Value;
                        myContext.SaveChanges();
                        dataGrid.ItemsSource = myContext.Suppliers.ToList();
                        txtId.Text = "";
                        txtName.Text = "";
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("please, select the data");
                Console.WriteLine(err.Message);
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
                        var supplier = myContext.Suppliers.Find(Id);
                        myContext.Suppliers.Remove(supplier);
                        myContext.SaveChanges();
                        dataGrid.ItemsSource = myContext.Suppliers.ToList();
                        dataGrid.SelectedItem = null;
                        txtId.Text = "";
                        txtName.Text = "";
                    }
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("please, select the data");
                Console.WriteLine(er.Message);
            }
        }
        private void dateJoinDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
