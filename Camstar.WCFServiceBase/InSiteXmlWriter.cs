// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.InSiteXmlWriter
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using Camstar.Util;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Camstar.WCF.Service
{
  internal class InSiteXmlWriter
  {
    private List<string> _ResolvedElements = new List<string>();
    private List<string> _EndResolvedElements = new List<string>();
    private const string InSiteTag = "__InSite";
    private const string versionTag = "__version";
    private const string sessionTag = "__session";
    private const string filterTag = "__filter";
    private const string filterTagAccessTag = "__allowUntaggedInstances";
    private const string tagsTag = "__tags";
    private const string languageTag = "__language";
    private const string connectTag = "__connect";
    private const string useSessionTag = "__useSession";
    private const string userTag = "user";
    private const string nameTag = "__name";
    private const string sessionIdTag = "sessionId";
    private const string passwordTag = "password";
    private const string encryptedTag = "__encrypted";
    private const string encryptionTag = "__encryption";
    private const string startRowTag = "__startRow";
    private const string rowSetSizeTag = "__rowSetSize";
    private const string requestRecordCountTag = "__requestRecordCount";
    private const string requestRecordSetAndCountTag = "__requestRecordSetAndCount";
    private const string requestHeadersOnlyTag = "__requestHeadersOnly";
    private const string requestHeadersAndRowCountTag = "__requestHeadersAndRowCount";
    private XmlTextWriter _Writer;
    private StringWriter _StringWriter;
    private string _XmlString;
    private bool _IsClosed;

    public InSiteXmlWriter(UserProfile userProfile)
    {
      this._StringWriter = new StringWriter();
      this._Writer = new XmlTextWriter((TextWriter) this._StringWriter);
      this.WriteSkeleton(userProfile);
    }

    public void BeginElement(string name)
    {
      this.BeginElement(name, (UnknownObjectReader) null);
    }

    public void BeginElement(string name, UnknownObjectReader value)
    {
      this.BeginElement(name, value, (string[]) null, (object[]) null);
    }

    public void BeginElement(string name, string[] attributeNames, object[] attributeValues)
    {
      this.BeginElement(name, (UnknownObjectReader) null, attributeNames, attributeValues);
    }

    public void BeginElement(
      string name,
      UnknownObjectReader value,
      string[] attributeNames,
      object[] attributeValues)
    {
      foreach (string resolvedElement in this._ResolvedElements)
        this._Writer.WriteStartElement(resolvedElement);
      this._ResolvedElements.Clear();
      this._Writer.WriteStartElement(name);
      if (attributeNames != null && attributeValues != null)
      {
        int num = 0;
        foreach (string attributeName in attributeNames)
          this._Writer.WriteAttributeString(attributeName, attributeValues[num++].ToString());
      }
      if (value == null)
        return;
      if (value.Value is string || value.Value is IPrimitive)
      {
        if (value.Value is PasswordFieldType)
        {
          this._Writer.WriteAttributeString("__encrypted", "yes");
          this._Writer.WriteCData(CryptUtil.Encrypt(value.Value.ToString()));
        }
        else
          this._Writer.WriteCData(value.Value.ToString());
      }
      else if (value.Value is EncryptedField)
      {
        this._Writer.WriteAttributeString("__encrypted", "yes");
        EncryptedField encryptedField = value.Value as EncryptedField;
        if (encryptedField.IsEncrypted)
          this._Writer.WriteCData(encryptedField.Value);
        else
          this._Writer.WriteCData(CryptUtil.Encrypt(encryptedField.Value));
      }
      else
        this._Writer.WriteCData(value.Value.ToString().ToLower());
    }

    public void Write(string xml)
    {
      this._Writer.WriteRaw(xml);
    }

    public void EndElement()
    {
      this._Writer.WriteEndElement();
    }

    public void ReserveElement(string name)
    {
      this._ResolvedElements.Add(name);
    }

    public void ConfirmReserveElement(string name)
    {
      if (this._ResolvedElements.Count != 0)
      {
        foreach (string resolvedElement in this._ResolvedElements)
        {
          this._Writer.WriteStartElement(resolvedElement);
          this._EndResolvedElements.Add(resolvedElement);
        }
        this._Writer.WriteStartElement(name);
        this._ResolvedElements.Clear();
      }
      else
        this.BeginElement(name);
    }

    public void EndReserveElement()
    {
      if (this._EndResolvedElements.Count == 0)
        return;
      foreach (string endResolvedElement in this._EndResolvedElements)
        this._Writer.WriteEndElement();
      this._EndResolvedElements.Clear();
      this._ResolvedElements.Clear();
    }

    public void RollBackElement()
    {
      this._ResolvedElements.RemoveAt(this._ResolvedElements.Count - 1);
    }

    public void WriteOptions(QueryOptions options)
    {
      if (options == null)
        return;
      if (options.StartRow.HasValue)
      {
        this._Writer.WriteStartElement("__startRow");
        this._Writer.WriteCData(options.StartRow.ToString());
        this._Writer.WriteEndElement();
      }
      if (options.RowSetSize.HasValue)
      {
        this._Writer.WriteStartElement("__rowSetSize");
        this._Writer.WriteCData(options.RowSetSize.ToString());
        this._Writer.WriteEndElement();
      }
      if (options.RequestRecordCount)
      {
        this._Writer.WriteStartElement("__requestRecordCount");
        this._Writer.WriteCData(bool.TrueString.ToLower());
        this._Writer.WriteEndElement();
      }
      if (options.RequestRecordSetAndCount)
      {
        this._Writer.WriteStartElement("__requestRecordSetAndCount");
        this._Writer.WriteCData(bool.TrueString.ToLower());
        this._Writer.WriteEndElement();
      }
      if (options.RequestHeadersOnly)
      {
        this._Writer.WriteStartElement("__requestHeadersOnly");
        this._Writer.WriteCData(bool.TrueString.ToLower());
        this._Writer.WriteEndElement();
      }
      if (!options.RequestHeadersAndRowCount)
        return;
      this._Writer.WriteStartElement("__requestHeadersAndRowCount");
      this._Writer.WriteCData(bool.TrueString.ToLower());
      this._Writer.WriteEndElement();
    }

    public string XmlToString()
    {
      return this._XmlString;
    }

    public void Close()
    {
      if (this._IsClosed)
        return;
      this.WriteEnd();
      this._XmlString = this._StringWriter.ToString();
      this._IsClosed = true;
    }

    private void WriteSkeleton(UserProfile userProfile)
    {
      bool flag = false;
      if (userProfile.SessionID != null && !string.IsNullOrEmpty(userProfile.SessionID.Value))
        flag = true;
      this._Writer.WriteStartDocument();
      this._Writer.WriteStartElement("__InSite");
      this._Writer.WriteAttributeString("__version", "1.1");
      this._Writer.WriteAttributeString("__encryption", "2");
      this._Writer.WriteStartElement("__session");
      if (!string.IsNullOrEmpty(userProfile.FilterTags) || !string.IsNullOrEmpty(userProfile.FilterTagAccess))
      {
        this._Writer.WriteStartElement("__filter");
        if (!string.IsNullOrEmpty(userProfile.FilterTags))
        {
          this._Writer.WriteStartElement("__tags");
          this._Writer.WriteCData(userProfile.FilterTags);
          this._Writer.WriteEndElement();
        }
        if (!string.IsNullOrEmpty(userProfile.FilterTagAccess) && int.TryParse(userProfile.FilterTagAccess, out int _))
        {
          this._Writer.WriteStartElement("__allowUntaggedInstances");
          this._Writer.WriteCData(userProfile.FilterTagAccess);
          this._Writer.WriteEndElement();
        }
        this._Writer.WriteEndElement();
      }
      if (!string.IsNullOrEmpty(userProfile.Dictionary))
      {
        this._Writer.WriteStartElement("__language");
        this._Writer.WriteStartElement("__name");
        this._Writer.WriteCData(userProfile.Dictionary);
        this._Writer.WriteEndElement();
        this._Writer.WriteEndElement();
      }
      if (flag)
        this._Writer.WriteStartElement("__useSession");
      else
        this._Writer.WriteStartElement("__connect");
      this._Writer.WriteStartElement("user");
      this._Writer.WriteStartElement("__name");
      this._Writer.WriteCData(userProfile.Name);
      this._Writer.WriteEndElement();
      this._Writer.WriteEndElement();
      EncryptedField encryptedField;
      if (flag)
      {
        encryptedField = userProfile.SessionID;
        this._Writer.WriteStartElement("sessionId");
      }
      else
      {
        encryptedField = userProfile.Password;
        this._Writer.WriteStartElement("password");
      }
      this._Writer.WriteAttributeString("__encrypted", "no");
      if (encryptedField != null)
      {
        if (encryptedField.IsEncrypted)
          this._Writer.WriteCData(CryptUtil.Decrypt(encryptedField.Value));
        else
          this._Writer.WriteCData(encryptedField.Value);
      }
      else
        this._Writer.WriteCData(string.Empty);
      this._Writer.WriteEndElement();
      this._Writer.WriteEndElement();
      this._Writer.WriteEndElement();
    }

    private void WriteEnd()
    {
      this._Writer.WriteEndElement();
    }
  }
}
