using GROUP04DataAccess.Models;
using GROUP04DataAccess.Repositories;
using GROUP04WPF.Helpers;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using GROUP04WPF.Views; // Thêm dòng này nếu thiếu

namespace GROUP04WPF.ViewModels
{
    public class RoomManagementViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<RoomInformation> rooms;
        private RoomInformation selectedRoom;
        private string searchKeyword;

        public ObservableCollection<RoomInformation> Rooms
        {
            get => rooms;
            set { rooms = value; OnPropertyChanged(nameof(Rooms)); }
        }
        public RoomInformation SelectedRoom
        {
            get => selectedRoom;
            set { selectedRoom = value; OnPropertyChanged(nameof(SelectedRoom)); }
        }
        public string SearchKeyword
        {
            get => searchKeyword;
            set { searchKeyword = value; OnPropertyChanged(nameof(SearchKeyword)); SearchRooms(); }
        }

        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }

        public RoomManagementViewModel()
        {
            Rooms = new ObservableCollection<RoomInformation>(RoomRepository.Instance.GetAll());
            AddCommand = new RelayCommand(AddRoom);
            UpdateCommand = new RelayCommand(UpdateRoom, () => SelectedRoom != null);
            DeleteCommand = new RelayCommand(DeleteRoom, () => SelectedRoom != null);
        }

        private void AddRoom()
        {
            var room = new RoomInformation { RoomID = RoomRepository.Instance.GetAll().Max(r => r.RoomID) + 1 };
            var dialog = new RoomDialog(room);
            if (dialog.ShowDialog() == true)
            {
                RoomRepository.Instance.Add(room);
                Rooms.Add(room);
            }
        }

        private void UpdateRoom()
        {
            if (SelectedRoom != null)
            {
                var dialog = new RoomDialog(SelectedRoom);
                if (dialog.ShowDialog() == true)
                {
                    RoomRepository.Instance.Update(SelectedRoom);
                    Rooms = new ObservableCollection<RoomInformation>(RoomRepository.Instance.GetAll());
                }
            }
        }

        private void DeleteRoom()
        {
            if (SelectedRoom != null && MessageBox.Show($"Are you sure to delete Room {SelectedRoom.RoomNumber}?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                RoomRepository.Instance.Delete(SelectedRoom.RoomID);
                Rooms.Remove(SelectedRoom);
            }
        }

        private void SearchRooms()
        {
            Rooms = new ObservableCollection<RoomInformation>(RoomRepository.Instance.Search(SearchKeyword ?? ""));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}