namespace TabNewsApp.Attributes
{
    public class RouteDescriptionAttribute : Attribute
    {
        public string RouteDescription { get; private set; }

        public RouteDescriptionAttribute(string routeDescription)
        {
            RouteDescription = routeDescription;
        }
    }
}
