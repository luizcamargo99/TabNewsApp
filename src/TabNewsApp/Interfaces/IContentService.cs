using TabNewsApp.Data;
using TabNewsApp.Enums;

namespace TabNewsApp.Interfaces;

internal interface IContentService
{
    Task<List<ContentModel>> GetAll(int page, int perPage, EStrategy strategy);
    Task<ContentModel> Get(string username, string slug);
    Task<List<ContentModel>> GetChildren(string username, string slug);
}
