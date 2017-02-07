using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ModernUIApp1
{
    /// <summary>
    /// Interaction logic for Protocol.xaml
    /// </summary>
    public partial class Protocol : UserControl
    {
        private ObservableCollection<ControlList> treeControlList = new ObservableCollection<ControlList>();
        public ObservableCollection<ControlList> TreeControlList
        {
            get { return treeControlList; }
            set
            {
                if (value == treeControlList) return;
                treeControlList = value;
            }
        }
        public Protocol()
        {
            

            ControlList child = new ControlList();
            child.ControlLabel = "child1";
            child.IsLoop = false;

            ControlList child2 = new ControlList();
            child2.ControlLabel = "child2";
            child2.IsLoop = false;



            ControlList loop2 = new ControlList();
            loop2.ControlLabel = "Loop2";
            loop2.IsLoop = true;
            loop2.ChildControlList = new ObservableCollection<ControlList>();
            loop2.ChildControlList.Add(child2);

            ControlList loop = new ControlList();
            loop.ControlLabel = "Loop1";
            loop.IsLoop = true;
            loop.ChildControlList = new ObservableCollection<ControlList>();
            loop.ChildControlList.Add(child);
            loop.ChildControlList.Add(loop2);

            TreeControlList.Add(loop);
            DataContext = this;
            InitializeComponent();
            
        }
    }
}
