#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace CorpusExplorer.Sdk.Db.CorpusDb	
{
	public partial class CorpusMetadata
	{
		private ulong _corpusId;
		public virtual ulong CorpusId
		{
			get
			{
				return this._corpusId;
			}
			set
			{
				this._corpusId = value;
			}
		}
		
		private string _name;
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		private string _value;
		public virtual string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
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
		
	}
}
#pragma warning restore 1591
