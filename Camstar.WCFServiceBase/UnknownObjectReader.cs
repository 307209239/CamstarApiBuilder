// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.UnknownObjectReader
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Camstar.WCF.Service
{
  internal class UnknownObjectReader
  {
    private object _Target;
    private Type _TargetType;
    private string _Name;

    public string Name
    {
      get
      {
        return this._Name;
      }
    }

    public object Value
    {
      get
      {
        return this._Target;
      }
    }

    public Type Type
    {
      get
      {
        return this._TargetType;
      }
    }

    public List<UnknownObjectReader> Fields
    {
      get
      {
        return this.GetFields();
      }
    }

    public List<UnknownObjectReader> ArrayItems
    {
      get
      {
        return this.GetItems();
      }
    }

    public bool IsArray
    {
      get
      {
        return this._TargetType.IsArray;
      }
    }

    public bool IsSimpleType
    {
      get
      {
        bool flag = false;
        if (this._TargetType.BaseType == typeof (object) || this._TargetType.IsValueType || (this._TargetType.IsEnum || this._Target is IPrimitive) || this._Target is EncryptedField)
          flag = true;
        return flag;
      }
    }

    public UnknownObjectReader this[string name]
    {
      get
      {
        UnknownObjectReader unknownObjectReader = (UnknownObjectReader) null;
        foreach (UnknownObjectReader field in this.GetFields())
        {
          if (field._Name == name)
            unknownObjectReader = field;
        }
        return unknownObjectReader;
      }
    }

    public UnknownObjectReader(object target)
    {
      this._Target = target;
      this._TargetType = target.GetType();
    }

    private UnknownObjectReader(string name, object target)
      : this(target)
    {
      this._Name = name;
    }

    private List<UnknownObjectReader> GetFields()
    {
      List<UnknownObjectReader> unknownObjectReaderList = new List<UnknownObjectReader>();
      if (!this.IsArray)
      {
        foreach (FieldInfo field in this._TargetType.GetFields())
        {
          object target = field.GetValue(this._Target);
          if (target != null)
            unknownObjectReaderList.Add(new UnknownObjectReader(field.Name, target));
        }
      }
      unknownObjectReaderList.Sort(new Comparison<UnknownObjectReader>(this.MethodComparer));
      return unknownObjectReaderList;
    }

    private int MethodComparer(UnknownObjectReader x, UnknownObjectReader y)
    {
      return x.Name == "Level" ? 1 : string.Compare(x.Name, y.Name);
    }

    private List<UnknownObjectReader> GetItems()
    {
      List<UnknownObjectReader> unknownObjectReaderList = new List<UnknownObjectReader>();
      if (this.IsArray)
      {
        foreach (object target in this._Target as Array)
        {
          if (target != null)
            unknownObjectReaderList.Add(new UnknownObjectReader(target));
        }
      }
      return unknownObjectReaderList;
    }
  }
}
