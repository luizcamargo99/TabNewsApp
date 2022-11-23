﻿namespace TabNewsApp.Interfaces;

internal interface IHttpService
{
    bool IsLoading { get; }
    Task<T> RequestAsync<T>(Func<Task<HttpResponseMessage>> requestAction);
    Task<HttpResponseMessage> GetAsync(string request, string query = "");
    Task<HttpResponseMessage> PostAsync(string request, string jsonString);
}
