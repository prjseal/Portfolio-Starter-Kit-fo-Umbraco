namespace Portfolio.Core.Extensions
{
    public static class StringExtensions
    {
        public static string ToIconClass(this string iconName)
        {
            if (string.IsNullOrWhiteSpace(iconName)) return null;

            return $"ion-{iconName.ToLower().Replace(" ", "-")}";
        }
    }
}
