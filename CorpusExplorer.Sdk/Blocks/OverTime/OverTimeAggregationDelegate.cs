﻿using System.Collections.Generic;

namespace CorpusExplorer.Sdk.Blocks.OverTime
{
  public delegate T OverTimeAggregationDelegate<T>(IEnumerable<T> data);
}