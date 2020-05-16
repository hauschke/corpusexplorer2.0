#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using CorpusExplorer.Sdk.Db.QuickSearchDb;

namespace CorpusExplorer.Sdk.Db.QuickSearchDb	
{
	public partial class Document
	{
		private ulong _id;
		public virtual ulong Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private Corpus _corpus;
		public virtual Corpus Corpus
		{
			get
			{
				return this._corpus;
			}
			set
			{
				this._corpus = value;
			}
		}
		
		private IList<DocumentMetadata> _documentMetadatas = new List<DocumentMetadata>();
		public virtual IList<DocumentMetadata> DocumentMetadatas
		{
			get
			{
				return this._documentMetadatas;
			}
		}
		
		private IList<DocumentTermRelation> _documentTermRelations = new List<DocumentTermRelation>();
		public virtual IList<DocumentTermRelation> DocumentTermRelations
		{
			get
			{
				return this._documentTermRelations;
			}
		}
		
	}
}
#pragma warning restore 1591
