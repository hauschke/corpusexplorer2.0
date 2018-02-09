﻿#region

using System.IO;
using System.Xml.Serialization;

#endregion

namespace CorpusExplorer.Sdk.Extern.Xml.Abstract.SerializerBasedScraper
{
  public abstract class AbstractGenericSerializer<T>
    where T : class
  {
    protected void CheckFileExtension(string path, string ext)
    {
      if (!path.ToLower().EndsWith(ext.ToLower()))
        throw new FileLoadException("File must have a ." + ext + "-Extension");
    }

    public virtual T Deserialize(string path)
    {
      DeserializePreValidation(path);
      T res;

      using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
      {
        res = Deserialize(fs);
      }

      DeserializePostValidation(res, path);

      return res;
    }

    public T Deserialize(Stream fs)
    {
      var xml = new XmlSerializer(typeof(T));
      return xml.Deserialize(fs) as T;
    }

    public virtual void Serialize(T obj, string path)
    {
      SerializePreValidation(obj, path);

      using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
      {
        var xml = new XmlSerializer(typeof(T));
        xml.Serialize(fs, obj);
      }

      SerializePostValidation(obj, path);
    }

    // ReSharper disable UnusedParameter.Global
    protected abstract void DeserializePostValidation(T obj, string path);
    protected abstract void DeserializePreValidation(string path);
    protected abstract void SerializePostValidation(T obj, string path);
    protected abstract void SerializePreValidation(T obj, string path);
    // ReSharper restore UnusedParameter.Global
  }
}