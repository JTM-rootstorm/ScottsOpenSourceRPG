namespace Engine.Utilities
{
    internal static class ExtensionMethods
    {
        internal static string InCurrentLanguage(this string text)
        {
            return Resources.Literals.ResourceManager.GetString(text) ?? text;
        }
    }
}
