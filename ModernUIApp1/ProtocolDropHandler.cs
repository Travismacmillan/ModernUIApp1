using System.Windows;
using GongSolutions.Wpf.DragDrop;
using DragDrop = GongSolutions.Wpf.DragDrop.DragDrop;

namespace ModernUIApp1
{
    public class ProtocolDropHandler : IDropTarget
    {
        public void DragOver(IDropInfo dropInfo)
        {
            var target = dropInfo.TargetItem as ControlList;
            if (dropInfo.InsertPosition.HasFlag(RelativeInsertPosition.TargetItemCenter) && target != null && !target.IsLoop)
            {
                dropInfo.Effects = DragDropEffects.None;
            }
            else
            {
                // call the drag over method from the default drop handler
                // you can handle this also by yourself
                DragDrop.DefaultDropHandler.DragOver(dropInfo);
            }
        }

        public void Drop(IDropInfo dropInfo)
        {
            DragDrop.DefaultDropHandler.Drop(dropInfo);
        }
    }
}