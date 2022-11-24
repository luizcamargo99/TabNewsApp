namespace TabNewsApp.Attributes
{
    public class IconAttribute : Attribute
    {
        public string IconValue { get; private set; }

        public IconAttribute(string iconValue)
        {
            IconValue = iconValue;
        }
    }
}
