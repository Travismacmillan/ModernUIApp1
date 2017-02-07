using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUIApp1
{
    public class ControlList
    {
        private bool isLoop;
        public bool IsLoop
        {
            get { return isLoop; }
            set
            {
                if (value == isLoop) return;
                isLoop = value;
            }
        }

        private string controlLabel;
        public string ControlLabel
        {
            get { return controlLabel; }
            set
            {
                if (value == controlLabel) return;
                controlLabel = value;
            }
        }

        private ObservableCollection<ControlList> childControlList;
        public ObservableCollection<ControlList> ChildControlList
        {
            get { return childControlList; }
            set
            {
                if (value == childControlList) return;
                childControlList = value;
            }
        }
    }
}
