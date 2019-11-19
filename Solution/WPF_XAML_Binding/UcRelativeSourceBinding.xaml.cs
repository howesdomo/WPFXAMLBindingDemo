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
    /// UcRelativeSourceBinding.xaml 的交互逻辑
    /// </summary>
    public partial class UcRelativeSourceBinding : UserControl
    {
        public UcRelativeSourceBinding()
        {
            InitializeComponent();
        }
    }

    public class UcRelativeSourceBinding_ViewModel : BaseViewModel
    {
        public UcRelativeSourceBinding_ViewModel()
        {
            var l = new List<DO>();

            for (int i = 0; i < 10; i++)
            {
                l.Add(new DO()
                {
                    No = (i + 1).ToString(),
                    OrderNo = "ABC111" + i,
                    EntryTime = DateTime.Now.ToString()
                });
            }

            this.List = l;
        }

        private List<DO> _List;
        public List<DO> List
        {
            get
            {
                return _List;
            }
            set 
            {
                _List = value;
                this.OnPropertyChanged("List");
            }
        }
    }

    public class DO
    { 
        public string No { get; set; }
        public string OrderNo { get; set; }
        public string EntryTime { get; set; }
    }
}
