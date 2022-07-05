using Microsoft.UI.Xaml.Controls;
using SkiaSharp.Views.Windows;
using SkiaSharp;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoAppSkia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnPaintCanvas(object sender, SKPaintSurfaceEventArgs e)
        {
            using var p = new SKPaint { Color = SKColors.Blue };
            e.Surface.Canvas.DrawText("hola", new SKPoint(100, 100), p);
        }
    }
}
