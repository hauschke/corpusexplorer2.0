﻿using System.Text;
using Elasticsearch.Net;
using Nest;

namespace CorpusExplorer.Sdk.Db.Elastic.Sdk.Context
{
  public class ElasticSearchContextBase
  {
    protected ElasticClient _client;
    protected IConnectionPool _connection;
    protected ConnectionSettings _settings;
    protected string _index;

    private ElasticSearchContextBase() { }

    public string Connection
    {
      get
      {
        var stb = new StringBuilder();
        foreach (var node in _connection.Nodes)
          stb.AppendLine(node.Uri.ToString());
        return stb.ToString();
      }
    }

    public ElasticClient Client => _client;

    public string Index => _index;

    public ConnectionSettings Settings => _settings;

    public ElasticSearchContextBase(
      IConnectionPool connectionPool,
      string index,
      ElasticSearchContextCredentials credentials = null)
    {
      _index = index;
      _connection = connectionPool;
      _settings = new ConnectionSettings(connectionPool);

      if (credentials != null)
        _settings.BasicAuthentication(credentials.Username, credentials.Password);

      _settings.DefaultIndex(index);
      _client = new ElasticClient(_settings);

      if (!_client.IndexExists(index).Exists)
        _client.CreateIndex(index);
    }
  }
}
