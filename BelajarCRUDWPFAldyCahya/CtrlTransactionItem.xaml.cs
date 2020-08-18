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
    /// Interaction logic for CtrlTransactionItem.xaml
    /// </summary>
    public partial class CtrlTransactionItem : UserControl
    {
        MyContext context = new MyContext();
        public CtrlTransactionItem()
        {
            InitializeComponent();
            dataGridTransactionItem.ItemsSource = context.TransactionItems.ToList();
            fillComboBoxItem();
            fillComboBoxTransaction();
        }

        public void fillComboBoxItem()
        {
            try
            {
                using (MyContext c = new MyContext())
                {
                    comboBoxItem.ItemsSource = c.Items.ToList();
                    comboBoxItem.SelectedValuePath = "Id";
                    comboBoxItem.DisplayMemberPath = "Id";
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        public void fillComboBoxTransaction()
        {
            try
            {
                using (MyContext c = new MyContext())
                {
                    comboBoxItem.ItemsSource = c.Transactions.ToList();
                    comboBoxItem.SelectedValuePath = "Id";
                    comboBoxItem.DisplayMemberPath = "Id";
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Equals("") || txtQuantity.Text.Equals(""))
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
                        var input = new TransactionItem()
                        {
                            Id = txtId.Text,
                            Quantity = Convert.ToInt32(txtQuantity.Text),
                            Item_Id = Convert.ToInt32(comboBoxItem.Text),
                            Transaction_Id = comboBoxTransaction.Text
                        };

                        context.TransactionItems.Add(input);
                        context.SaveChanges();
                        txtId.Text = "";
                        txtQuantity.Text = "";
                        comboBoxItem.Text = "";
                        comboBoxTransaction.Text = "";
                        dataGridTransactionItem.ItemsSource = context.TransactionItems.ToList();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("input failed");
                Console.WriteLine(err.Message);
            }

        }

        private void txtSearchItem_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredData = context.TransactionItems.Where(I => I.Id.ToString().Contains(txtSearchItem.Text) || I.Quantity.ToString().Contains(txtSearchItem.Text) || I.Item_Id.ToString().Contains(txtSearchItem.Text) || I.Transaction_Id.ToString().Contains(txtSearchItem.Text)).ToList();
            dataGridTransactionItem.ItemsSource = filteredData;
        }

        private void btnSearchItem_Click(object sender, RoutedEventArgs e)
        {
            var filteredData = context.TransactionItems.Where(I => I.Id.ToString().Contains(txtSearchItem.Text) || I.Quantity.ToString().Contains(txtSearchItem.Text) || I.Item_Id.ToString().Contains(txtSearchItem.Text) || I.Transaction_Id.ToString().Contains(txtSearchItem.Text)).ToList();
            dataGridTransactionItem.ItemsSource = filteredData;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Equals("") || txtQuantity.Text.Equals(""))
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
                        int Id = Convert.ToInt32(txtId.Text);
                        var item = context.TransactionItems.Find(Id);
                        context.TransactionItems.Remove(item);
                        context.SaveChanges();
                        dataGridTransactionItem.ItemsSource = context.TransactionItems.ToList();
                        dataGridTransactionItem.SelectedItem = null;
                        txtId.Text = "";
                        txtSearchItem.Text = "";
                        txtQuantity.Text = "";
                        comboBoxItem.Text = "";
                        comboBoxTransaction.Text = "";
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("please, select the data");
                Console.WriteLine(er.Message);
            }
        }

        private void DataGridTransactionItem_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGridTransactionItem.SelectedItem != null)
            {
                var item = dataGridTransactionItem.SelectedItem as Item;
                txtId.Text = Convert.ToString(item.Id);
                txtQuantity.Text = Convert.ToString(item.Price);
                comboBoxItem.Text = Convert.ToString(item.Stock);
                comboBoxTransaction.Text = item.Supplier_Id;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Equals("") || txtQuantity.Text.Equals(""))
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
                        int Id = Convert.ToInt32(txtId.Text);
                        var item = context.TransactionItems.Find(Id);
                        item.Quantity = Convert.ToInt32(txtQuantity.Text);
                        item.Item_Id = Convert.ToInt32(comboBoxItem.Text);
                        item.Transaction_Id = comboBoxTransaction.Text;

                        context.SaveChanges();
                        dataGridTransactionItem.ItemsSource = context.TransactionItems.ToList();
                        txtId.Text = "";
                        txtQuantity.Text = "";
                        comboBoxItem.Text = "";
                        comboBoxTransaction.Text = "";
                    }
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Update gagal!");
                Console.WriteLine(Err.Message);
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
                    int Id = Convert.ToInt32(txtId.Text);
                    var item = context.TransactionItems.Find(Id);
                    context.TransactionItems.Remove(item);
                    context.SaveChanges();
                    dataGridTransactionItem.ItemsSource = context.TransactionItems.ToList();
                    dataGridTransactionItem.SelectedItem = null;
                    txtId.Text = "";
                    txtQuantity.Text = "";
                    comboBoxItem.Text = "";
                    comboBoxTransaction.Text = "";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("please, select the data");
                Console.WriteLine(er.Message);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtQuantity.Text = "";
            comboBoxItem.Text = "";
            comboBoxTransaction.Text = "";
            dataGridTransactionItem.ItemsSource = context.TransactionItems.ToList();
        }

        private void dataGridTransactionItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }

    
}
