using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace CustomControl.Library
{  public class ButtonImage : Button
    {  
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(ButtonImage), new PropertyMetadata(null));
        
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ButtonImage), new PropertyMetadata(string.Empty));
      
        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(ButtonImage), new PropertyMetadata((double)30));
        
        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(ButtonImage), new PropertyMetadata((double)30));
        
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        
        public double ImageWidth
        {
            get { return (double)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }
        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }
       
        
        static ButtonImage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonImage), new FrameworkPropertyMetadata(typeof(ButtonImage)));
        }

    }
}