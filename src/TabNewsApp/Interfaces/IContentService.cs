using TabNewsApp.Data;
using TabNewsApp.Enums;

namespace TabNewsApp.Interfaces;

internal interface IContentService
{
    Task<List<Content>> GetAll(int page, int perPage, EStrategy strategy);
    Task<Content> Get(string username, string slug);
}
