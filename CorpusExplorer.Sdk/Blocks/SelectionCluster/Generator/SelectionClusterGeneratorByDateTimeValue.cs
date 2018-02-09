using System;
using CorpusExplorer.Sdk.Blocks.SelectionCluster.Cluster;
using CorpusExplorer.Sdk.Blocks.SelectionCluster.Cluster.Abstract;
using CorpusExplorer.Sdk.Blocks.SelectionCluster.Generator.Abstract;

namespace CorpusExplorer.Sdk.Blocks.SelectionCluster.Generator
{
  public class SelectionClusterGeneratorByDateTimeValue :
    AbstractSelectionClusterGeneratorByValue
  {
    protected override AbstractCluster NewCluster(object value)
    {
      return new DateTimeCluster(value as DateTime? ?? DateTime.MinValue);
    }
  }
}