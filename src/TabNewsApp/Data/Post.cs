using Newtonsoft.Json;

namespace TabNewsApp.Data
{
    public class Post : Base
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
       
        [JsonProperty("owner_id")]
        public Guid OwnerId { get; set; }

        [JsonProperty("parent_id")]
        public Guid? ParentId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
            
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("published_at")]
        public DateTime? PublishedAt { get; set; }
            
        [JsonProperty("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [JsonProperty("tabcoins")]
        public int TabCoins { get; set; }

        [JsonProperty("owner_username")]
        public string OwnerUsername { get; set; }

        [JsonProperty("children_deep_count")]
        public int ChildrenDeepCount { get; set; }
    }
}