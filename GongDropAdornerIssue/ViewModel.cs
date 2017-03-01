using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using GongSolutions.Wpf.DragDrop;

namespace GongDropAdornerIssue
{
    public class ViewModel : IDragSource
    {
        public ImageSource Image { get; }
            = new BitmapImage(new Uri("94x94.png", UriKind.RelativeOrAbsolute));

        public void StartDrag(IDragInfo dragInfo)
        {
            dragInfo.Data = this;
            dragInfo.Effects = DragDropEffects.Move;
        }

        public bool CanStartDrag(IDragInfo dragInfo)
            => true;

        public void Dropped(IDropInfo dropInfo)
        {
        }

        public void DragCancelled()
        {
        }

        public bool TryCatchOccurredException(Exception exception)
            => false;
    }
}
