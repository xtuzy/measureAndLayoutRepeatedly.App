using System.Diagnostics;

namespace measureAndLayoutRepeatedly
{
    internal class MyVerticalStackLayout : VerticalStackLayout
    {
        protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
        {
            Debug.WriteLine($"[{nameof(MyVerticalStackLayout)}] [MeasureOverride] Id={Id}");
            return base.MeasureOverride(widthConstraint, heightConstraint);
        }

        protected override Size ArrangeOverride(Rect bounds)
        {
            Debug.WriteLine($"[{nameof(MyVerticalStackLayout)}] [ArrangeOverride] Id={Id}");
            return base.ArrangeOverride(bounds);
        }
    }
}
