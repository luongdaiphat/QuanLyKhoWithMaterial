using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyKhoBeta.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        // mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            MessageBox.Show("Đã vào trong MainViewModel -> DataContext của mainwindow.xaml");
        }
    }
}
