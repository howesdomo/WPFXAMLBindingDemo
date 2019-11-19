using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_XAML_Binding
{
    /// <summary>
    /// UcBasicBinding.xaml 的交互逻辑
    /// </summary>
    public partial class UcBasicBinding : UserControl
    {
        UcBasicBinding_ViewModel ViewModel { get; set; }

        public UcBasicBinding()
        {
            InitializeComponent();
            this.ViewModel = new UcBasicBinding_ViewModel();
            this.DataContext = this.ViewModel;
        }
    }

    public class UcBasicBinding_ViewModel : BaseViewModel
    {
        public UcBasicBinding_ViewModel()
        {
            SearchArgs = new SearchArgs();
            SearchArgs.OrderNo = "DO332211";
            SearchArgs.BatchNo = "95155";

            this.Address = "文函西街道";
        }

        private SearchArgs _SearchArgs;

        public SearchArgs SearchArgs
        {
            get { return _SearchArgs; }

            set
            {
                _SearchArgs = value;
                this.OnPropertyChanged("SearchArgs");
            }
        }

        private string _Address;

        public string Address
        {
            get { return _Address; }

            set
            {
                _Address = value;
                this.OnPropertyChanged("Address");
            }
        }
    }

    public class SearchArgs : BaseViewModel
    {
        private string _OrderNo;
        public string OrderNo
        {
            get { return _OrderNo; }
            set
            {
                _OrderNo = value;
                this.OnPropertyChanged("OrderNo");
            }
        }

        private string _BatchNo;
        public string BatchNo
        {
            get { return _BatchNo; }
            set
            {
                _BatchNo = value;
                this.OnPropertyChanged("BatchNo");
            }
        }

    }
}
