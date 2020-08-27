// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.DCTypeCache
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.ObjectModel;
using System.Collections.Generic;

namespace Camstar.WCF.Generator
{
  internal class DCTypeCache
  {
    private List<DCType> _DCTypes = new List<DCType>();
    private List<DCType> _ChildTypes = new List<DCType>();
    private List<DCType> _PreparedTypes = new List<DCType>();

    public string AddDCType(DCType dCType)
    {
      string empty = string.Empty;
      string str;
      if (!this.IsContains(dCType, this._DCTypes) && !this.IsContains(dCType, this._PreparedTypes))
      {
        this._PreparedTypes.Add(dCType);
        List<DCField> fields = dCType.GetFields();
        str = dCType.Name;
        if (dCType.ParentId != 0)
        {
          DCType dCType1 = new DCType(dCType.ParentId, dCType.IsSubentity);
          dCType.ParentName = this.AddDCType(dCType1);
        }
        this._DCTypes.Add(dCType);
        this._PreparedTypes.Remove(dCType);
        foreach (DCField dcField in fields)
        {
          if (!dcField.IsSimpleType)
          {
            if (dcField.DCType.IsSubentity)
              this.AddDCChildren(dcField.DCType);
            if (!this.IsContains(dcField.DCType, this._DCTypes))
              this.AddDCType(dcField.DCType);
          }
          else if (dcField.IsEnum && !this.IsContains(dcField.DCType, this._DCTypes))
          {
            dcField.DCType.GetFields();
            this._DCTypes.Add(dcField.DCType);
          }
        }
      }
      else
        str = this.GetDCName(dCType);
      return str;
    }

    private void AddEnumeration(DCType dCType)
    {
      CDORequestor.CurrentRequestor.GetFields(dCType.ID);
    }

    private void AddDCChildren(DCType dCType)
    {
      if (this.IsContains(dCType, this._ChildTypes) || dCType.ID == 3730)
        return;
      this._ChildTypes.Add(dCType);
      foreach (CDODefinition child in CDORequestor.CurrentRequestor.GetChildren(dCType.ID))
      {
        DCType dCType1 = new DCType(child.Name, child.CDOId, dCType.ID, dCType.Name, true, false);
        this.AddDCChildren(dCType1);
        this.AddDCType(dCType1);
      }
    }

    public List<DCType> GetSortedDCTypes()
    {
      return this._DCTypes;
    }

    private string GetDCName(DCType dCType)
    {
      string str = string.Empty;
      foreach (DCType dcType in this._DCTypes)
      {
        if (dcType.ID == dCType.ID)
        {
          str = dcType.Name;
          break;
        }
      }
      if (string.IsNullOrEmpty(str))
      {
        foreach (DCType preparedType in this._PreparedTypes)
        {
          if (preparedType.ID == dCType.ID)
          {
            str = preparedType.Name;
            break;
          }
        }
      }
      return str;
    }

    private bool IsContains(DCType dCType, List<DCType> types)
    {
      bool flag = false;
      if (dCType.ID != 0)
      {
        foreach (DCType type in types)
        {
          if (type.ID == dCType.ID)
          {
            flag = true;
            break;
          }
        }
      }
      else
        flag = true;
      return flag;
    }
  }
}
