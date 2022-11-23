using TabNewsApp.Data;
using TabNewsApp.Enums;

namespace TabNewsApp.Interfaces;

internal interface IPostService
{
    Task<List<Post>> GetAll(int page, int perPage, EStrategy strategy);
    Task<Post> Get(string username, string slug);
}
