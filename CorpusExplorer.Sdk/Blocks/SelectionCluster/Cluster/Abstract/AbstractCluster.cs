﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CorpusExplorer.Sdk.Blocks.SelectionCluster.Cluster.Abstract
{
  public abstract class AbstractCluster
  {
    private readonly ConcurrentBag<Guid> _documentGuids = new ConcurrentBag<Guid>();

    public abstract object CentralValue { get; }

    public abstract string Displayname { get; }

    public IEnumerable<Guid> DocumentGuids => _documentGuids;

    protected void Add(Guid documentGuid) { _documentGuids.Add(documentGuid); }

    public abstract bool Add(Guid documentGuid, object obj);
  }
}