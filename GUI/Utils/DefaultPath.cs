namespace GUI.Utils
{
    public static class DefaultPath
    {
        static string guiPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                   .Parent.Parent.Parent.FullName;
        public static readonly string ICON_IMG_PATH = Path.Combine(guiPath, "Img", "Icon");
        public static readonly string PRODUCT_IMG_PATH = Path.Combine(guiPath, "Img", "Product");
    }
}
