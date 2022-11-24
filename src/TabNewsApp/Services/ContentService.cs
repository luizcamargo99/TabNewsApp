using TabNewsApp.Constants;
using TabNewsApp.Data;
using TabNewsApp.Enums;
using TabNewsApp.Interfaces;

namespace TabNewsApp.Services;

internal class ContentService : IContentService
{
    private IHttpService _httpService { get; set; }

    public ContentService(IHttpService httpService)
    {
        _httpService = httpService; 
    }

    public async Task<List<Content>> GetAll(int page, int perPage, EStrategy strategy = EStrategy.Relevant)
    {
        return await _httpService.RequestAsync<List<Content>>(() => _httpService.GetAsync($"{UrlConstant.BaseURL}/contents?page={page}&per_page={perPage}&strategy={strategy.ToString().ToLower()}"));
    }

    public async Task<Content> Get(string username, string slug)
    {
        return await _httpService.RequestAsync<Content>(() => _httpService.GetAsync($"{UrlConstant.BaseURL}/contents/{username}/{slug}"));
    }
}
