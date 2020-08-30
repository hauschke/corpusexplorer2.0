﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 21.01.2019 11:56:30
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace CorpusExplorer.Sdk.Db.SqLite.Model.CoQuery
{

    [DatabaseAttribute(Name = "main")]
    [ProviderAttribute(typeof(Devart.Data.SQLite.Linq.Provider.SQLiteDataProvider))]
    public partial class CoQueryDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(CoQueryDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertLexicon(Lexicon instance);
        partial void UpdateLexicon(Lexicon instance);
        partial void DeleteLexicon(Lexicon instance);
        partial void InsertFile(File instance);
        partial void UpdateFile(File instance);
        partial void DeleteFile(File instance);
        partial void InsertCorpus(Corpus instance);
        partial void UpdateCorpus(Corpus instance);
        partial void DeleteCorpus(Corpus instance);

        #endregion

        public CoQueryDataContext() :
        base(GetConnectionString("CoQueryDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        public CoQueryDataContext(MappingSource mappingSource) :
        base(GetConnectionString("CoQueryDataContextConnectionString"), mappingSource)
        {
            OnCreated();
        }

        private static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        public CoQueryDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public CoQueryDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public CoQueryDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public CoQueryDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Lexicon> Lexicons
        {
            get
            {
                return this.GetTable<Lexicon>();
            }
        }

        public Devart.Data.Linq.Table<File> Files
        {
            get
            {
                return this.GetTable<File>();
            }
        }

        public Devart.Data.Linq.Table<Corpus> Corpora
        {
            get
            {
                return this.GetTable<Corpus>();
            }
        }
    }
}

namespace CorpusExplorer.Sdk.Db.SqLite.Model.CoQuery
{

    /// <summary>
    /// There are no comments for CorpusExplorer.Sdk.Db.SqLite.Model.CoQuery.Lexicon in the schema.
    /// </summary>
    [Table(Name = @"""main"".Lexicon")]
    public partial class Lexicon : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _WordId;

        private string _Lemma;

        private string _POS;

        private string _Word;
        #pragma warning restore 0649

        private EntityRef<Corpus> _Corpus;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnWordIdChanging(int value);
        partial void OnWordIdChanged();
        partial void OnLemmaChanging(string value);
        partial void OnLemmaChanged();
        partial void OnPOSChanging(string value);
        partial void OnPOSChanged();
        partial void OnWordChanging(string value);
        partial void OnWordChanged();
        #endregion

        public Lexicon()
        {
            this._Corpus  = default(EntityRef<Corpus>);
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for WordId in the schema.
        /// </summary>
        [Column(Storage = "_WordId", CanBeNull = false, DbType = "INT NOT NULL", IsPrimaryKey = true)]
        public int WordId
        {
            get
            {
                return this._WordId;
            }
            set
            {
                if (this._WordId != value)
                {
                    if (this._Corpus.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnWordIdChanging(value);
                    this.SendPropertyChanging("WordId");
                    this._WordId = value;
                    this.SendPropertyChanged("WordId");
                    this.OnWordIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Lemma in the schema.
        /// </summary>
        [Column(Storage = "_Lemma", CanBeNull = false, DbType = "VARCHAR NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Lemma
        {
            get
            {
                return this._Lemma;
            }
            set
            {
                if (this._Lemma != value)
                {
                    this.OnLemmaChanging(value);
                    this.SendPropertyChanging("Lemma");
                    this._Lemma = value;
                    this.SendPropertyChanged("Lemma");
                    this.OnLemmaChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for POS in the schema.
        /// </summary>
        [Column(Storage = "_POS", CanBeNull = false, DbType = "VARCHAR NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string POS
        {
            get
            {
                return this._POS;
            }
            set
            {
                if (this._POS != value)
                {
                    this.OnPOSChanging(value);
                    this.SendPropertyChanging("POS");
                    this._POS = value;
                    this.SendPropertyChanged("POS");
                    this.OnPOSChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Word in the schema.
        /// </summary>
        [Column(Storage = "_Word", CanBeNull = false, DbType = "VARCHAR NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Word
        {
            get
            {
                return this._Word;
            }
            set
            {
                if (this._Word != value)
                {
                    this.OnWordChanging(value);
                    this.SendPropertyChanging("Word");
                    this._Word = value;
                    this.SendPropertyChanged("Word");
                    this.OnWordChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Corpus in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Corpus_Lexicon", Storage="_Corpus", ThisKey="WordId", OtherKey="WordId", IsForeignKey=true)]
        public Corpus Corpus
        {
            get
            {
                return this._Corpus.Entity;
            }
            set
            {
                Corpus previousValue = this._Corpus.Entity;
                if ((previousValue != value) || (this._Corpus.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging("Corpus");
                    if (previousValue != null)
                    {
                        this._Corpus.Entity = null;
                        previousValue.Lexicons.Remove(this);
                    }
                    this._Corpus.Entity = value;
                    if (value != null)
                    {
                        this._WordId = value.WordId;
                        value.Lexicons.Add(this);
                    }
                    else
                    {
                        this._WordId = default(int);
                    }
                    this.SendPropertyChanged("Corpus");
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for CorpusExplorer.Sdk.Db.SqLite.Model.CoQuery.File in the schema.
    /// </summary>
    [Table(Name = @"""main"".Files")]
    public partial class File : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _FileId;

        private string _Filename;

        private string _Path;
        #pragma warning restore 0649

        private EntitySet<Corpus> _Corpora;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnFileIdChanging(int value);
        partial void OnFileIdChanged();
        partial void OnFilenameChanging(string value);
        partial void OnFilenameChanged();
        partial void OnPathChanging(string value);
        partial void OnPathChanged();
        #endregion

        public File()
        {
            this._Corpora = new EntitySet<Corpus>(new Action<Corpus>(this.attach_Corpora), new Action<Corpus>(this.detach_Corpora));
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for FileId in the schema.
        /// </summary>
        [Column(Storage = "_FileId", CanBeNull = false, DbType = "INT NOT NULL", IsPrimaryKey = true)]
        public int FileId
        {
            get
            {
                return this._FileId;
            }
            set
            {
                if (this._FileId != value)
                {
                    this.OnFileIdChanging(value);
                    this.SendPropertyChanging("FileId");
                    this._FileId = value;
                    this.SendPropertyChanged("FileId");
                    this.OnFileIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Filename in the schema.
        /// </summary>
        [Column(Storage = "_Filename", CanBeNull = false, DbType = "VARCHAR NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Filename
        {
            get
            {
                return this._Filename;
            }
            set
            {
                if (this._Filename != value)
                {
                    this.OnFilenameChanging(value);
                    this.SendPropertyChanging("Filename");
                    this._Filename = value;
                    this.SendPropertyChanged("Filename");
                    this.OnFilenameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Path in the schema.
        /// </summary>
        [Column(Storage = "_Path", CanBeNull = false, DbType = "VARCHAR NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Path
        {
            get
            {
                return this._Path;
            }
            set
            {
                if (this._Path != value)
                {
                    this.OnPathChanging(value);
                    this.SendPropertyChanging("Path");
                    this._Path = value;
                    this.SendPropertyChanged("Path");
                    this.OnPathChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Corpora in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="File_Corpus", Storage="_Corpora", ThisKey="FileId", OtherKey="FileId")]
        public EntitySet<Corpus> Corpora
        {
            get
            {
                return this._Corpora;
            }
            set
            {
                this._Corpora.Assign(value);
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void attach_Corpora(Corpus entity)
        {
            this.SendPropertyChanging("Corpora");
            entity.File = this;
        }
    
        private void detach_Corpora(Corpus entity)
        {
            this.SendPropertyChanging("Corpora");
            entity.File = null;
        }
    }

    /// <summary>
    /// There are no comments for CorpusExplorer.Sdk.Db.SqLite.Model.CoQuery.Corpus in the schema.
    /// </summary>
    [Table(Name = @"""main"".Corpus")]
    public partial class Corpus : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private long _ID;

        private int _SentenceId;

        private int _WordId;

        private int _FileId;
        #pragma warning restore 0649

        private EntitySet<Lexicon> _Lexicons;

        private EntityRef<File> _File;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
        partial void OnSentenceIdChanging(int value);
        partial void OnSentenceIdChanged();
        partial void OnWordIdChanging(int value);
        partial void OnWordIdChanged();
        partial void OnFileIdChanging(int value);
        partial void OnFileIdChanged();
        #endregion

        public Corpus()
        {
            this._Lexicons = new EntitySet<Lexicon>(new Action<Lexicon>(this.attach_Lexicons), new Action<Lexicon>(this.detach_Lexicons));
            this._File  = default(EntityRef<File>);
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [Column(Storage = "_ID", CanBeNull = false, DbType = "BIGINT NOT NULL", IsPrimaryKey = true)]
        public long ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if (this._ID != value)
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging("ID");
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for SentenceId in the schema.
        /// </summary>
        [Column(Name = @"Sentence_Id", Storage = "_SentenceId", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int SentenceId
        {
            get
            {
                return this._SentenceId;
            }
            set
            {
                if (this._SentenceId != value)
                {
                    this.OnSentenceIdChanging(value);
                    this.SendPropertyChanging("SentenceId");
                    this._SentenceId = value;
                    this.SendPropertyChanged("SentenceId");
                    this.OnSentenceIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for WordId in the schema.
        /// </summary>
        [Column(Storage = "_WordId", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int WordId
        {
            get
            {
                return this._WordId;
            }
            set
            {
                if (this._WordId != value)
                {
                    this.OnWordIdChanging(value);
                    this.SendPropertyChanging("WordId");
                    this._WordId = value;
                    this.SendPropertyChanged("WordId");
                    this.OnWordIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FileId in the schema.
        /// </summary>
        [Column(Storage = "_FileId", CanBeNull = false, DbType = "INT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int FileId
        {
            get
            {
                return this._FileId;
            }
            set
            {
                if (this._FileId != value)
                {
                    if (this._File.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnFileIdChanging(value);
                    this.SendPropertyChanging("FileId");
                    this._FileId = value;
                    this.SendPropertyChanged("FileId");
                    this.OnFileIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Lexicons in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Corpus_Lexicon", Storage="_Lexicons", ThisKey="WordId", OtherKey="WordId")]
        public EntitySet<Lexicon> Lexicons
        {
            get
            {
                return this._Lexicons;
            }
            set
            {
                this._Lexicons.Assign(value);
            }
        }

    
        /// <summary>
        /// There are no comments for File in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="File_Corpus", Storage="_File", ThisKey="FileId", OtherKey="FileId", IsForeignKey=true)]
        public File File
        {
            get
            {
                return this._File.Entity;
            }
            set
            {
                File previousValue = this._File.Entity;
                if ((previousValue != value) || (this._File.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging("File");
                    if (previousValue != null)
                    {
                        this._File.Entity = null;
                        previousValue.Corpora.Remove(this);
                    }
                    this._File.Entity = value;
                    if (value != null)
                    {
                        this._FileId = value.FileId;
                        value.Corpora.Add(this);
                    }
                    else
                    {
                        this._FileId = default(int);
                    }
                    this.SendPropertyChanged("File");
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void attach_Lexicons(Lexicon entity)
        {
            this.SendPropertyChanging("Lexicons");
            entity.Corpus = this;
        }
    
        private void detach_Lexicons(Lexicon entity)
        {
            this.SendPropertyChanging("Lexicons");
            entity.Corpus = null;
        }
    }

}
