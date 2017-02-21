using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ScrollView), typeof(TrivialApp.UWP.Renderers.ScrollViewDisableRenderer))]
namespace TrivialApp.UWP.Renderers
{
    public class ScrollViewDisableRenderer : ScrollViewRenderer
    {

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Control.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            Control.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
        }
    }
}