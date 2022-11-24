using System.ComponentModel;
using TabNewsApp.Attributes;

namespace TabNewsApp.Enums
{
    internal enum EMenuNavigation
    {
        [Description("Relevante")]
        [Icon("oi oi-fire")]
        Relevant,
        [Description("Recentes")]
        [Icon("oi oi-clock")]
        New,
        [Description("Status")]
        [Icon("oi oi-graph")]
        Status,
        [Description("Perfil")]
        [Icon("oi oi-person")]
        Profile
    }
}
