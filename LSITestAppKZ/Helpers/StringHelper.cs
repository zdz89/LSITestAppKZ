namespace LSITestApp
{
    public static class StringHelper
    {
        public static bool IsNullEmptyOrWhiteSpace(this string input)
        {
            return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input);
        }
    }
}
