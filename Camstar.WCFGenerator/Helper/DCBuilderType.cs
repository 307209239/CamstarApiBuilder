// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.DCBuilderType
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System;
using System.Reflection.Emit;

namespace Camstar.WCF.Generator.Helper
{
  internal class DCBuilderType
  {
    private string _Name;
    private Type _Type;
    private TypeBuilder _TypeBuilder;
    private bool _IsSimpleType;
    private bool _IsEmptyEnum;

    public DCBuilderType(string name, Type type, TypeBuilder typeBuilder, bool isSimpleType)
    {
      this._Name = name;
      this._Type = type;
      this._TypeBuilder = typeBuilder;
      this._IsSimpleType = isSimpleType;
    }

    public DCBuilderType(
      string name,
      Type type,
      TypeBuilder typeBuilder,
      bool isSimpleType,
      bool isEmptyEnum)
      : this(name, type, typeBuilder, isSimpleType)
    {
      this._IsEmptyEnum = isEmptyEnum;
    }

    public string Name
    {
      get
      {
        return this._Name;
      }
    }

    public Type Type
    {
      get
      {
        return this._Type;
      }
    }

    public TypeBuilder TypeBuilder
    {
      get
      {
        return this._TypeBuilder;
      }
    }

    public bool IsSimpleType
    {
      get
      {
        return this._IsSimpleType;
      }
    }

    public bool IsEmptyEnum
    {
      get
      {
        return this._IsEmptyEnum;
      }
    }
  }
}
