using System.Diagnostics;

namespace measureAndLayoutRepeatedly;

class MyGrid : Grid
{
    protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
    {
        Debug.WriteLine($"[{nameof(MyGrid)}] [MeasureOverride] Id={Id}");
        return base.MeasureOverride(widthConstraint, heightConstraint);
    }

    protected override Size ArrangeOverride(Rect bounds)
    {
        Debug.WriteLine($"[{nameof(MyGrid)}] [ArrangeOverride] Id={Id}");
        return base.ArrangeOverride(bounds);
    }
}