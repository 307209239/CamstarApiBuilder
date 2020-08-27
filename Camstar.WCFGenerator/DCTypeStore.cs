// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.DCTypeStore
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using System;
using System.Collections;
using System.Reflection.Emit;

namespace Camstar.WCF.Generator
{
  internal class DCTypeStore
  {
    private Hashtable _Types = new Hashtable();

    public void Add(
      string name,
      Type type,
      TypeBuilder typeBuilder,
      bool isSimpleType,
      bool isEmptyEnum)
    {
      if (!(type != (Type) null))
        return;
      DCBuilderType dcBuilderType = new DCBuilderType(name, type, typeBuilder, isSimpleType, isEmptyEnum);
      this._Types.Add((object) name, (object) dcBuilderType);
    }

    public void Add(string name, Type type, TypeBuilder typeBuilder, bool isSimpleType)
    {
      this.Add(name, type, typeBuilder, isSimpleType, false);
    }

    public void Add(string name, Type type, TypeBuilder typeBuilder)
    {
      this.Add(name, type, typeBuilder, false);
    }

    public DCBuilderType GetDCBuilderType(string name)
    {
      DCBuilderType dcBuilderType = (DCBuilderType) null;
      if (this._Types.ContainsKey((object) name))
        dcBuilderType = this._Types[(object) name] as DCBuilderType;
      return dcBuilderType;
    }

    public Type this[string name]
    {
      get
      {
        return this.GetDCBuilderType(name).Type;
      }
    }
  }
}
