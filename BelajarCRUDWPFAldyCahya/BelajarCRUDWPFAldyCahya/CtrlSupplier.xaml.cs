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
            dataGridSupplier.ItemsSource = myContext.Suppliers.ToList();
        }
        private void customizeDesign()
        {
            //panelSubMenuPanel.Visibility;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
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
                            Id = txtId.Text,
                            JoinDate = dateJoinDate.SelectedDate.Value
                        };
                        myContext.Suppliers.Add(input);
                        myContext.SaveChanges();
                        txtName.Text = "";
                        txtId.Text = "";
                        dateJoinDate.SelectedDate = null;
                        dataGridSupplier.ItemsSource = myContext.Suppliers.ToList();
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
            var supplier = dataGridSupplier.SelectedItem as Supplier;
            txtName.Text = supplier.Name;
            txtId.Text = supplier.Id;
            dateJoinDate.SelectedDate = supplier.JoinDate;
            dataGridSupplier.ItemsSource = myContext.Suppliers.ToList();
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
                        dataGridSupplier.ItemsSource = myContext.Suppliers.ToList();
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
                        dataGridSupplier.ItemsSource = myContext.Suppliers.ToList();
                        dataGridSupplier.SelectedItem = null;
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
        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
     
            var filteredData = myContext.Suppliers.Where(Q => Q.Id.ToString().Contains(txtSearch.Text) || Q.Name.Contains(txtSearch.Text)).ToList();
            dataGridSupplier.ItemsSource = filteredData;
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var filteredData = myContext.Suppliers.Where(Q => Q.Id.ToString().Contains(txtSearch.Text) || Q.Name.Contains(txtSearch.Text)).ToList();
            dataGridSupplier.ItemsSource = filteredData;

        }
        private void DataGridSupplier_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGridSupplier.SelectedItem != null)
            {
                var item = dataGridSupplier.SelectedItem as Supplier;
                txtId.Text = Convert.ToString(item.Id);
                txtName.Text = item.Name;
                dateJoinDate.SelectedDate = item.JoinDate;
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
                    var supplier = myContext.Suppliers.Find(Id);
                    myContext.Suppliers.Remove(supplier);
                    myContext.SaveChanges();
                    dataGridSupplier.ItemsSource = myContext.Suppliers.ToList();
                    dataGridSupplier.SelectedItem = null;
                    txtId.Text = "";
                    txtName.Text = "";
                    dateJoinDate.SelectedDate = null;
                }              
            }
            catch (Exception er)
            {
                Console.WriteLine("please, select the data");
                Console.WriteLine(er.Message);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSearch.Text = "";
            dateJoinDate.SelectedDate = null;
            dataGridSupplier.SelectedItem = null;
            dataGridSupplier.ItemsSource = myContext.Suppliers.ToList();
        }
    }
}
