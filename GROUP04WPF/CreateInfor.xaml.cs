using BusinessObjects;
using Repositories;
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

<<<<<<< HEAD
namespace GROUP04WPF
=======
namespace FUMiniHotelManagement
>>>>>>> 4270bab (dự phòng)
{
    /// <summary>
    /// Interaction logic for CreateInfor.xaml
    /// </summary>
    public partial class CreateInfor : Window
    {
        private readonly IBookingInformationRepositories _bookingInformationRepositories;
        private readonly IRoomTypeRepositories _roomTypeRepositories;

        public CreateInfor()
        {
            InitializeComponent();
            _bookingInformationRepositories = new BookingInformationRepositories();
            _roomTypeRepositories = new RoomTypeRepositories();
            loadRoomType();
        }

        private int typeId;

        private void loadRoomType()
        {
            var room = _roomTypeRepositories.GetAllRoomTypes()
                .Select(rt => rt.RoomTypeName).ToList(); ;
            cbRoomTypeId.ItemsSource = room;
        }

        private void cbRoomTypeId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var type = _roomTypeRepositories.GetRoomTypeByName(cbRoomTypeId.SelectedValue.ToString());
            typeId = type.RoomTypeId;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            var infor = new RoomInformation
            {
                RoomNumber = txtRoomNumber.Text,
                RoomDetailDescription = txtRoomDetailDescription.Text,
                RoomMaxCapacity = int.Parse(txtRoomMaxCapacity.Text),
                RoomTypeId = typeId,
                RoomStatus = 1,
                RoomPricePerDay = decimal.Parse(txtRoomPricePerDay.Text),
            };
<<<<<<< HEAD
            if (infor != null)
=======
            if(infor != null )
>>>>>>> 4270bab (dự phòng)
            {
                _bookingInformationRepositories.CreateRoomInformation(infor);
                MessageBox.Show("Create room information successfully!");
                Close();
            }
            else
            {
                MessageBox.Show("Create room information failed!");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
