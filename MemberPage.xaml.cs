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
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Window
    {
        public MemberPage()
        {
            InitializeComponent();

            // memberlist shows all the members that are in the static observable collection
            MemberList.ItemsSource = Data.DataClass.MemberCollection;

           
           

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AddMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            // checking if the member is a regulare member or a gold member
            if (RegMembership.IsChecked == true)
            {
                RegularMember regularMember = new RegularMember(FirstNameBox.Text.ToString(), LastNameBox.Text.ToString());
                Data.DataClass.MemberCollection.Add(regularMember);
            }
            else { if(GoldMembership.IsChecked == true) 
                {
                    GoldMember goldMember = new GoldMember(FirstNameBox.Text.ToString(), LastNameBox.Text.ToString());
                    Data.DataClass.MemberCollection.Add(goldMember);
                } }
        }

        private void MemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           Member member = MemberList.SelectedItem as Member;

            // since member starts as null we need the if statment for it to be the item source.
            if (member != null)
            {
                TransactionHistory.ItemsSource = member.PreviousTransactions;

            }
        }
    }
}
