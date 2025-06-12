using GROUP04DataAccess.Models;
using System;
using System.Windows;

namespace GROUP04WPF.Views
{
    public partial class RoomDialog : Window
    {
        public RoomInformation Room { get; set; }

        public RoomDialog(RoomInformation room)
        {
            InitializeComponent();
            Room = room;
            DataContext = Room;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Room.RoomNumber) || Room.RoomTypeID <= 0 || Room.RoomPricePerDay <= 0)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}