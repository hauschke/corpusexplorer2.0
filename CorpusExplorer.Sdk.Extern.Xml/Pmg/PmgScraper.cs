﻿using System.Collections.Generic;
using System.Linq;
using CorpusExplorer.Sdk.Extern.Xml.Abstract;
using CorpusExplorer.Sdk.Extern.Xml.Helper;
using CorpusExplorer.Sdk.Extern.Xml.Pmg.Extension;
using CorpusExplorer.Sdk.Extern.Xml.Pmg.Model;

namespace CorpusExplorer.Sdk.Extern.Xml.Pmg
{
  public class PmgScraper : AbstractXmlScraper
  {
    public override string DisplayName => "PMG-XML";
    protected override IEnumerable<Dictionary<string, object>> Execute(string file)
    {
      var model = XmlSerializerHelper.Deserialize<artikelliste>(file);
      return from artikel in model.artikel
        where artikel != null
        select new Dictionary<string, object>
        {
          {"Artikel-ID", artikel.metadaten?.artikelid},
          {"Zeitung", artikel.metadaten?.quelle?.name},
          {"Ausgabe", artikel.metadaten?.quelle?.nummer},
          {"Url", artikel.metadaten?.weblink},
          {"Autor", artikel.metadaten?.person == null ? "" : string.Join(" | ", artikel.metadaten?.person)},
          {"Titel", artikel.inhalt?.titelliste?.titel},
          {"Rubrik", artikel.inhalt?.titelliste?.rubrik},
          {"Ressort", artikel.inhalt?.titelliste?.ressort},
          {"Untertitel", artikel.inhalt?.titelliste?.untertitel},
          {"Seitentitel", artikel.inhalt?.titelliste?.seitentitel},
          {"Dachzeile", artikel.inhalt?.titelliste?.dachzeile},
          {"Vorspann", artikel.inhalt?.vorspann == null ? "" : string.Join(" ", artikel.inhalt?.vorspann)},
          {"Text", artikel.inhalt?.text.Plaintext()}
        };
    }
  }
}