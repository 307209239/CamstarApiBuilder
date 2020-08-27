// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.DCType
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.ObjectModel;
using System.Collections.Generic;

namespace Camstar.WCF.Generator
{
  internal class DCType
  {
    private List<DCField> _Fields;
    private string _Name;
    private int _ParentId;
    private string _ParentName;
    private int _Id;
    private string _Description;
    private bool _IsSubentity;
    private bool _IsEnum;

    public DCType(
      string name,
      int id,
      int parentId,
      string parentName,
      bool isSubentity,
      bool isEnum)
    {
      this._Name = name;
      this._Id = id;
      this._ParentId = parentId;
      this._ParentName = parentName;
      this._IsSubentity = isSubentity;
      this._IsEnum = isEnum;
    }

    public DCType(int id)
      : this(string.Empty, id, 0, string.Empty, false, false)
    {
    }

    public DCType(int id, bool isSubentity)
      : this(string.Empty, id, 0, string.Empty, isSubentity, false)
    {
    }

    public DCType(int id, bool isSubentity, bool IsEnum)
      : this(string.Empty, id, 0, string.Empty, isSubentity, IsEnum)
    {
    }

    public string Name
    {
      get
      {
        return this._Name;
      }
    }

    public int ParentId
    {
      get
      {
        return this._ParentId;
      }
    }

    public string ParentName
    {
      get
      {
        return this._ParentName;
      }
      set
      {
        this._ParentName = value;
      }
    }

    public string Description
    {
      get
      {
        return this._Description;
      }
    }

    public int ID
    {
      get
      {
        return this._Id;
      }
    }

    public bool IsSubentity
    {
      get
      {
        return this._IsSubentity;
      }
    }

    public bool IsEnum
    {
      get
      {
        return this._IsEnum;
      }
    }

    public List<DCField> GetFields()
    {
      if (this._Fields == null)
      {
        List<CDOField> fields = CDORequestor.CurrentRequestor.GetFields(this.ID);
        this._Fields = new List<DCField>(fields.Count);
        foreach (CDOField cdoField in fields)
        {
          this._Name = cdoField.CDOTypeName;
          this._Description = cdoField.CDOTypeDescription;
          this._ParentId = cdoField.CDOParentTypeID;
          if (!cdoField.IsTypeNull)
            this._Fields.Add(new DCField(cdoField, this.IsEnum));
        }
      }
      return this._Fields;
    }
  }
}
