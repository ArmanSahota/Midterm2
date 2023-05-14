using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Midterm2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            Member member = (Member)cbMember.SelectedItem;
            Product product = (Product)ProductListBox.SelectedItem;
            ProductListBox.ItemsSource = Data.DataClass.ProductCollection;
            cbMember.ItemsSource = Data.DataClass.MemberCollection;
            if (member != null)
            {
                TransactionBox.ItemsSource = member.PreviousTransactions;
            }



        }




        private void CurrentMember(Member member)
        {
            cbMember.SelectedItem = Data.DataClass.CurrentMember;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            new ProductWindow().Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MemberPage().Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Member member = (Member)cbMember.SelectedItem;
            Product product = (Product)ProductListBox.SelectedItem;
            

            //TransactionBox.Items.Clear();

            if (cbMember.SelectedItem != null && ProductListBox.SelectedItem != null)
            {

                member.AddProduct(product);
                
                if (member != null)
                {
                    TransactionBox.ItemsSource = member.PreviousTransactions;
                }
                cbMember.Items.Refresh();
                member.AddPoints(product);
                PointsTxt.Text = "User Points:" + member.PointAmount.ToString();


            }

        }
        
        private void cbMember_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Member member = (Member)cbMember.SelectedItem;
            Product product = (Product)ProductListBox.SelectedItem;
            if (member != null)
            {
                TransactionBox.ItemsSource = member.PreviousTransactions;
            }
            cbMember.Items.Refresh();
            PointsTxt.Text = "User Points:" + member.PointAmount.ToString();


        }

        private void TransactionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Member member = (Member)cbMember.SelectedItem;
            Product product = (Product)ProductListBox.SelectedItem;
            if (member != null)
            {
                TransactionBox.ItemsSource = member.PreviousTransactions;
            }
            cbMember.Items.Refresh();
            
            if(member.PointAmount>= product.Points)
            {
                member.AddProduct(product);
                member.DeductPoints(product);
            }
            else { MessageBox.Show("Not Enough Points"); }

            PointsTxt.Text = "User Points:" + member.PointAmount.ToString();

        }
    }
}













