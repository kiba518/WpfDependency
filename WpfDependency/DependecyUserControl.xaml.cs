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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDependency
{
    /// <summary>
    /// DependecyUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class DependecyUserControl : UserControl
    {
        //public static readonly DependencyProperty IsSpinningProperty =
        //DependencyProperty.Register("IsSpinning", typeof(bool), typeof(DependecyUserControl));
        //public bool IsSpinning
        //{
        //    get { return (bool)GetValue(IsSpinningProperty); }
        //    set { SetValue(IsSpinningProperty, value); }
        //}
        
        public string HeaderTitle
        {
            get { return (string)GetValue(HeaderTitleProperty); }
            set { SetValue(HeaderTitleProperty, value); }
        } 
        public static readonly DependencyProperty HeaderTitleProperty = DependencyProperty.Register("HeaderTitle", typeof(string), typeof(DependecyUserControl), null); 
        public DependecyUserControl()
        {
            this.DataContext = this;
            InitializeComponent();
        }
    }
}
