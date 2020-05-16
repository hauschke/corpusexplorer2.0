﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Linq;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;

namespace CorpusExplorer.Sdk.Db.CollocationDb
{
  public class EntitiesModel : OpenAccessContext, IEntitiesModelUnitOfWork
  {
    private static readonly string connectionStringName = @"";
    private static readonly BackendConfiguration backend = GetBackendConfiguration();
    private static readonly MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntitiesModel.rlinq");

    public EntitiesModel()
      : base(connectionStringName, backend, metadataSource) { }

    public EntitiesModel(string connection)
      : base(connection, backend, metadataSource) { }

    public EntitiesModel(BackendConfiguration backendConfiguration)
      : base(connectionStringName, backendConfiguration, metadataSource) { }

    public EntitiesModel(string connection, MetadataSource metadataSource)
      : base(connection, backend, metadataSource) { }

    public EntitiesModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
      : base(connection, backendConfiguration, metadataSource) { }

    public IQueryable<TermRelation> TermRelations
    {
      get { return GetAll<TermRelation>(); }
    }

    public IQueryable<Term> Terms
    {
      get { return GetAll<Term>(); }
    }

    public static BackendConfiguration GetBackendConfiguration()
    {
      var backend = new BackendConfiguration
                    {
                      Backend = "SQLite",
                      ProviderName = "System.Data.SQLite"
                    };

      CustomizeBackendConfiguration(ref backend);

      return backend;
    }

    /// <summary>
    ///   Allows you to customize the BackendConfiguration of EntitiesModel.
    /// </summary>
    /// <param name="config">The BackendConfiguration of EntitiesModel.</param>
    static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
  }

  public interface IEntitiesModelUnitOfWork : IUnitOfWork
  {
    IQueryable<TermRelation> TermRelations { get; }

    IQueryable<Term> Terms { get; }
  }
}

#pragma warning restore 1591