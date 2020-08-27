// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.InSiteXmlReader
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Camstar.WCF.Service
{
  internal class InSiteXmlReader
  {
    private InSiteXmlReader[] _FieldsList;
    private InSiteXmlReader[] _Fields;
    private const string listItemTag = "__listItem";
    private XmlNode _XmlNode;
    private string _Name;
    private string _Value;

    public InSiteXmlReader[] Fields
    {
      get
      {
        return this.GetFields();
      }
    }

    public string Value
    {
      get
      {
        return this._Value;
      }
    }

    public string Name
    {
      get
      {
        return this._Name;
      }
    }

    public bool HasFields
    {
      get
      {
        return (uint) this.GetFields().Length > 0U;
      }
    }

    public bool IsList
    {
      get
      {
        bool flag = false;
        if (this._XmlNode.FirstChild != null)
          flag = this._XmlNode.FirstChild.Name == "__listItem";
        return flag;
      }
    }

    public InSiteXmlReader this[string name]
    {
      get
      {
        return ((IEnumerable<InSiteXmlReader>) this.GetFields()).FirstOrDefault<InSiteXmlReader>((Func<InSiteXmlReader, bool>) (f => f._Name == name));
      }
    }

    public InSiteXmlReader[] GetFields(string fieldName)
    {
      return ((IEnumerable<InSiteXmlReader>) this.GetFields()).Where<InSiteXmlReader>((Func<InSiteXmlReader, bool>) (reader => reader._Name == fieldName)).ToArray<InSiteXmlReader>();
    }

    public InSiteXmlReader(string xml)
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(xml);
      this._XmlNode = (XmlNode) xmlDocument;
      this._Name = this._XmlNode.Name;
    }

    public string GetAttribute(string name)
    {
      string empty = string.Empty;
      if (this._XmlNode.Attributes[name] != null)
        empty = this._XmlNode.Attributes[name].Value;
      return empty;
    }

    public XmlAttributeCollection GetAttributes()
    {
      return this._XmlNode.Attributes;
    }

    private InSiteXmlReader(string name, string value, XmlNode xmlNode)
    {
      this._Name = name;
      this._Value = value;
      this._XmlNode = xmlNode;
    }

    public InSiteXmlReader[] GetList()
    {
      InSiteXmlReader[] fieldsList = this._FieldsList;
      if (fieldsList == null)
      {
        this._FieldsList = this._XmlNode.ChildNodes.Cast<XmlNode>().Where<XmlNode>((Func<XmlNode, bool>) (node => node.NodeType == XmlNodeType.Element)).Select<XmlNode, InSiteXmlReader>((Func<XmlNode, InSiteXmlReader>) (node => new InSiteXmlReader(this._XmlNode.Name, node.InnerText, node))).ToArray<InSiteXmlReader>();
        fieldsList = this._FieldsList;
      }
      return fieldsList;
    }

    public InSiteXmlReader[] GetFields()
    {
      InSiteXmlReader[] fields = this._Fields;
      if (fields == null)
      {
        this._Fields = this._XmlNode.ChildNodes.Cast<XmlNode>().Where<XmlNode>((Func<XmlNode, bool>) (node => node.NodeType == XmlNodeType.Element)).Select<XmlNode, InSiteXmlReader>((Func<XmlNode, InSiteXmlReader>) (node => new InSiteXmlReader(node.Name, node.InnerText, node))).ToArray<InSiteXmlReader>();
        fields = this._Fields;
      }
      return fields;
    }
  }
}
