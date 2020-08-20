using BelajarCRUDWPFAldyCahya.Context;
using BelajarCRUDWPFAldyCahya.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
    /// Interaction logic for CtrlItem.xaml
    /// </summary>
    public partial class CtrlItem : UserControl
    {
        MyContext myContext = new MyContext();
        public CtrlItem()
        {
            InitializeComponent();
            fillComboBox();
            dataGridItem.ItemsSource = myContext.Items.ToList();
        }
        public void fillComboBox()
        {
            try
            {
                using (MyContext c = new MyContext())
                {
                    comboBox1.ItemsSource = c.Suppliers.ToList();
                    comboBox1.SelectedValuePath = "Id";
                    comboBox1.DisplayMemberPath = "Nama";
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
                if (txtItemName.Text.Equals("") || txtPrice.Text.Equals("") || txtStock.Text.Equals(""))
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
                        var input = new Item()
                        {
                            Name = txtItemName.Text,
                            Id = Convert.ToInt32(txtItemId.Text),
                            Price = Convert.ToInt32(txtPrice.Text),
                            Stock=Convert.ToInt32(txtStock.Text),
                            Supplier_Id = comboBox1.Text
                        };
                        myContext.Items.Add(input);
                        myContext.SaveChanges();
                        txtItemName.Text = "";
                        txtItemId.Text = "";
                        txtPrice.Text = "";
                        txtStock.Text = "";
                        comboBox1.Text = "";
                        dataGridItem.ItemsSource = myContext.Items.ToList();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("input failed");
            }

        }
        private void txtSearchItem_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredData = myContext.Items.Where(I => I.Id.ToString().Contains(txtSearchItem.Text) || I.Name.Contains(txtSearchItem.Text) || I.Price.ToString().Contains(txtSearchItem.Text) || I.Stock.ToString().Contains(txtSearchItem.Text) || I.Supplier_Id.ToString().Contains(txtSearchItem.Text)).ToList();
            dataGridItem.ItemsSource = filteredData;
        }
        private void btnSearchItem_Click(object sender, RoutedEventArgs e)
        {
            var filteredData = myContext.Items.Where(I => I.Id.ToString().Contains(txtSearchItem.Text) || I.Name.Contains(txtSearchItem.Text) || I.Price.ToString().Contains(txtSearchItem.Text) || I.Stock.ToString().Contains(txtSearchItem.Text) || I.Supplier_Id.ToString().Contains(txtSearchItem.Text)).ToList();
            dataGridItem.ItemsSource = filteredData;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtItemName.Text.Equals("") || txtItemId.Text.Equals("") || txtPrice.Text.Equals("") || txtStock.Text.Equals(""))
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
                        int Id = Convert.ToInt32(txtItemId.Text);
                        var item = myContext.Items.Find(Id);
                        myContext.Items.Remove(item);
                        myContext.SaveChanges();
                        dataGridItem.ItemsSource = myContext.Items.ToList();
                        dataGridItem.SelectedItem = null;
                        txtItemId.Text = "";
                        txtItemName.Text = "";
                        txtSearchItem.Text = "";
                        txtPrice.Text = "";
                        txtStock.Text = "";
                        comboBox1.Text = "";
                    }
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("please, select the data");
                Console.WriteLine(er.Message);
            }
        }
        private void DataGridItem_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dataGridItem.SelectedItem != null)
            {
                var item = dataGridItem.SelectedItem as Item;
                txtItemId.Text = Convert.ToString(item.Id);
                txtItemName.Text = item.Name;
                txtPrice.Text = Convert.ToString(item.Price);
                txtStock.Text = Convert.ToString(item.Stock);
                comboBox1.Text = item.Supplier_Id;
            }
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtItemName.Text.Equals("") || txtItemId.Text.Equals("") || txtPrice.Text.Equals("") || txtStock.Text.Equals(""))
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
                        int Id = Convert.ToInt32(txtItemId.Text);
                        var item = myContext.Items.Find(Id);
                        item.Name = txtItemName.Text;
                        item.Price = Convert.ToInt32(txtPrice.Text);
                        item.Stock = Convert.ToInt32(txtStock.Text);
                        myContext.SaveChanges();
                        dataGridItem.ItemsSource = myContext.Items.ToList();
                        txtItemId.Text = "";
                        txtItemName.Text = "";
                        txtSearchItem.Text = "";
                        txtPrice.Text = "";
                        txtStock.Text = "";
                        comboBox1.Text = "";
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("please, select the data");
                Console.WriteLine(err.Message);
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
                    int Id = Convert.ToInt32(txtItemId.Text);
                    var item = myContext.Items.Find(Id);
                    myContext.Items.Remove(item);
                    myContext.SaveChanges();
                    dataGridItem.ItemsSource = myContext.Items.ToList();
                    dataGridItem.SelectedItem = null;
                    txtItemId.Text = "";
                    txtItemName.Text = "";
                    txtSearchItem.Text = "";
                    txtPrice.Text = "";
                    txtStock.Text = "";
                    comboBox1.Text = "";
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
            txtItemId.Text = "";
            txtItemName.Text = "";
            txtSearchItem.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            comboBox1.Text = "";
            dataGridItem.ItemsSource = myContext.Items.ToList();
        }
    }
}
