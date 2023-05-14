using Midterm;
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
using System.Windows.Shapes;

namespace Midterm2
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
            lstBox.ItemsSource = Data.DataClass.ProductCollection;
            PopulateSizeComboBox();
            
        }

        private void Coffeebtn_Click(object sender, RoutedEventArgs e)
        {

            // Validate the price
            if (!Double.TryParse(txtboxPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate the points
            if (!Int32.TryParse(txtboxPoint.Text, out int points))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }

            // Get the selected size
            Coffee.Size size = (Coffee.Size)cboSize.SelectedIndex;

            // Create the coffee product
            Coffee coffee = new Coffee(txtboxName.Text.ToString(), Convert.ToDouble(txtboxPrice.Text), Convert.ToInt32(txtboxPoint.Text), size, txtboxRoast.Text.ToString());

            // Add the coffee product to the ProductCollection

            Data.DataClass.ProductCollection.Add(coffee);           



        }

        void PopulateSizeComboBox()

        {

            cboSize.Items.Add("Short");
            cboSize.Items.Add("Tall");
            cboSize.Items.Add("Grande");
            cboSize.Items.Add("Venti");
            cboSize.Items.Add("Trenta");
            cboSize.SelectedIndex = 0;

        }

        private void TeaBtn_Click(object sender, RoutedEventArgs e)

        {
            // Validate the price
            if (!Double.TryParse(txtboxPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate the points
            if (!Int32.TryParse(txtboxPoint.Text, out int points))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }
            // Get the selected size
            Tea.Size size = (Tea.Size)cboSize.SelectedIndex;
                Tea tea = new Tea(txtboxName.Text.ToString(), Convert.ToDouble(txtboxPrice.Text), Convert.ToInt32(txtboxPoint.Text), size, txtboxRoast.Text.ToString());

                // Add the coffee product to the ProductCollection

                Data.DataClass.ProductCollection.Add(tea);
        }

        private void IsHeated_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BreakfastBtn_Click(object sender, RoutedEventArgs e)
        {
            // Validate the price
            if (!Double.TryParse(txtboxPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate the points
            if (!Int32.TryParse(txtboxPoint.Text, out int points))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }
            Breakfast breakfast = new Breakfast(txtboxName.Text.ToString(), Convert.ToDouble(txtboxPrice.Text), Convert.ToInt32(txtboxPoint.Text), IsHeated.IsChecked.Value, ComboODairy.IsChecked.Value);
            Data.DataClass.ProductCollection.Add(breakfast);
        }

        private void Lunch_Click(object sender, RoutedEventArgs e)
        {
            // Validate the price
            if (!Double.TryParse(txtboxPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate the points
            if (!Int32.TryParse(txtboxPoint.Text, out int points))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }
            Lunch lunch = new Lunch(txtboxName.Text.ToString(), Convert.ToDouble(txtboxPrice.Text), Convert.ToInt32(txtboxPoint.Text), IsHeated.IsChecked.Value, ComboODairy.IsChecked.Value);
            Data.DataClass.ProductCollection.Add(lunch);
        }

        private void ColorBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TumblerBtn_Click(object sender, RoutedEventArgs e)
        {
            // Validate the price
            if (!Double.TryParse(txtboxPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate the points
            if (!Int32.TryParse(txtboxPoint.Text, out int points))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }
            Tumbler tumbler = new Tumbler(txtboxName.Text.ToString(), Convert.ToDouble(txtboxPrice.Text), Convert.ToInt32(txtboxPoint.Text), ColorBox.ToString());
            Data.DataClass.ProductCollection.Add(tumbler);
        }

        private void MugBtn_Click(object sender, RoutedEventArgs e)
        {
            // Validate the price
            if (!Double.TryParse(txtboxPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate the points
            if (!Int32.TryParse(txtboxPoint.Text, out int points))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }
            Mug mug = new Mug(txtboxName.Text.ToString(), Convert.ToDouble(txtboxPrice.Text), Convert.ToInt32(txtboxPoint.Text), ColorBox.ToString());
            Data.DataClass.ProductCollection.Add(mug);
        }

        private void GiftCardBtn_Click(object sender, RoutedEventArgs e)
        {
            // Validate the price
            if (!Double.TryParse(txtboxPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate the points
            if (!Int32.TryParse(txtboxPoint.Text, out int points))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }
            // validate the giftcard amount
            if (!Double.TryParse(GiftCardAmount.Text, out double Amount))
            {
                MessageBox.Show("Please enter a valid number for GiftCard.");
                return;
            }
            GiftCard giftCard = new GiftCard(txtboxName.Text.ToString(), Convert.ToDouble(txtboxPrice.Text), Convert.ToInt32(txtboxPoint.Text), Convert.ToInt32(GiftCardAmount.Text));
            Data.DataClass.ProductCollection.Add(giftCard);
        }
    }
}
