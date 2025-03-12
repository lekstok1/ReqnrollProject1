
[Binding]
public class Transforms
{
    [StepArgumentTransformation(@"in (\d+) days?")]
    public DateTime InXDaysTransform(int days)
    {
        return DateTime.Today.AddDays(days);
    }
}