using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace CustomEllipseButton
{
    public class EllipseButton : Button
    {
        private Rectangle rect;

        public ImageSource Source
        {
            get { return GetValue(SourceProperty) as ImageSource; }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(EllipseButton),null);

        public EllipseButton()
        {
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            rect = GetTemplateChild("LogoImage") as Rectangle;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return base.MeasureOverride(availableSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            if (null != rect)
            {
                rect.Height = finalSize.Height;
                rect.Width = finalSize.Height;
            }
            return base.ArrangeOverride(finalSize);
        }
    }
}
