using System.ComponentModel;
using TabNewsApp.Attributes;

namespace TabNewsApp.Enums
{
    internal enum EMenuNavigation
    {
        [Description("Relevantes")]
        [Icon("oi oi-fire")]
        [RouteDescription("/")]
        Relevant,
        [Description("Recentes")]
        [Icon("oi oi-clock")]
        [RouteDescription("/Recent")]
        New,
        [Description("Favorites")]
        [Icon("oi oi-star")]
        [RouteDescription("/Favorites")]
        Favorites,
        [Description("Perfil")]
        [Icon("oi oi-person")]
        [RouteDescription("/Profile")]
        Profile
    }
}
