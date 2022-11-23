using TabNewsApp.Constants;
using TabNewsApp.Data;
using TabNewsApp.Enums;
using TabNewsApp.Interfaces;

namespace TabNewsApp.Services;

internal class PostService : IPostService
{
    private IHttpService _httpService { get; set; }

    public PostService(IHttpService httpService)
    {
        _httpService = httpService; 
    }

    public async Task<List<Post>> GetAll(int page, int perPage, EStrategy strategy)
    {
        return await _httpService.RequestAsync<List<Post>>(() => _httpService.GetAsync($"{UrlConstant.BaseURL}/contents?page={page}&per_page={perPage}&strategy={strategy.ToString().ToLower()}"));
    }

    public async Task<Post> Get(string username, string slug)
    {
        return await _httpService.RequestAsync<Post>(() => _httpService.GetAsync($"{UrlConstant.BaseURL}/contents/{username}/{slug}"));
    }
}
