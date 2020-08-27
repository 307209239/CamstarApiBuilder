// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.UnknownObjectWriter
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Camstar.WCF.Service
{
  internal class UnknownObjectWriter
  {
    private object _Target;
    private Type _TargetType;

    public string this[string name]
    {
      set
      {
        this.SetField(name, value);
      }
    }

    public Type Type
    {
      get
      {
        return this._TargetType;
      }
    }

    public object Value
    {
      get
      {
        return this._Target;
      }
    }

    public UnknownObjectWriter(object target)
    {
      this._Target = target;
      this._TargetType = target.GetType();
    }

    public UnknownObjectWriter CreateField(string name)
    {
      UnknownObjectWriter unknownObjectWriter = (UnknownObjectWriter) null;
      FieldInfo field = this._TargetType.GetField(name, BindingFlags.Instance | BindingFlags.Public);
      if (field != (FieldInfo) null)
      {
        object target = (object) null;
        if (field.FieldType.FullName != typeof (string).FullName && !field.FieldType.IsArray)
          target = field.FieldType.Assembly.CreateInstance(field.FieldType.FullName);
        if (target != null)
        {
          field.SetValue(this._Target, target);
          unknownObjectWriter = new UnknownObjectWriter(target);
        }
      }
      return unknownObjectWriter;
    }

    public UnknownObjectWriter CreateField(string name, string typeName)
    {
      UnknownObjectWriter unknownObjectWriter = (UnknownObjectWriter) null;
      FieldInfo field = this._TargetType.GetField(name, BindingFlags.Instance | BindingFlags.Public);
      if (field != (FieldInfo) null)
      {
        object target = (object) null;
        if (field.FieldType.FullName != typeof (string).FullName)
          target = field.FieldType.Assembly.CreateInstance(field.FieldType.Namespace + "." + typeName);
        if (target != null)
        {
          field.SetValue(this._Target, target);
          unknownObjectWriter = new UnknownObjectWriter(target);
        }
      }
      return unknownObjectWriter;
    }

    public List<UnknownObjectWriter> CreateArray(string name, int count)
    {
      List<UnknownObjectWriter> unknownObjectWriterList = new List<UnknownObjectWriter>();
      FieldInfo field = this._TargetType.GetField(name, BindingFlags.Instance | BindingFlags.Public);
      Type elementType = field.FieldType.GetElementType();
      Array instance = Array.CreateInstance(elementType, count);
      field.SetValue(this._Target, (object) instance);
      for (int index = 0; index < instance.Length; ++index)
        instance.SetValue(elementType.Assembly.CreateInstance(elementType.FullName), index);
      foreach (object target in instance)
        unknownObjectWriterList.Add(new UnknownObjectWriter(target));
      return unknownObjectWriterList;
    }

    public UnknownObjectWriter SetArrayItem(
      int index,
      string name,
      string typeName)
    {
      FieldInfo field = this._TargetType.GetField(name, BindingFlags.Instance | BindingFlags.Public);
      Type elementType = field.FieldType.GetElementType();
      Array array = field.GetValue(this._Target) as Array;
      object instance = elementType.Assembly.CreateInstance(elementType.Namespace + "." + typeName);
      array.SetValue(instance, index);
      return new UnknownObjectWriter(instance);
    }

    public UnknownObjectWriter SetArrayItem(
      int index,
      string name,
      object value)
    {
      FieldInfo field = this._TargetType.GetField(name, BindingFlags.Instance | BindingFlags.Public);
      field.FieldType.GetElementType();
      (field.GetValue(this._Target) as Array).SetValue(value, index);
      return new UnknownObjectWriter(value);
    }

    public void SetField(string name, object value)
    {
      if (value is string)
      {
        this.SetField(name, value as string);
      }
      else
      {
        FieldInfo field = this._TargetType.GetField(name, BindingFlags.Instance | BindingFlags.Public);
        if (!(field != (FieldInfo) null))
          return;
        field.SetValue(this._Target, value);
      }
    }

    private void SetField(string name, string value)
    {
      FieldInfo field = this._TargetType.GetField(name, BindingFlags.Instance | BindingFlags.Public);
      if (!(field != (FieldInfo) null) || string.IsNullOrEmpty(value))
        return;
      object obj;
      if (field.FieldType.IsGenericType)
      {
        if (field.FieldType.GetInterface("IPrimitive") == (Type) null)
        {
          obj = Convert.ChangeType((object) value, field.FieldType.GetGenericArguments()[0]);
        }
        else
        {
          IPrimitive instance = field.FieldType.Assembly.CreateInstance(field.FieldType.FullName) as IPrimitive;
          instance.SetValue((object) value);
          obj = (object) instance;
        }
      }
      else if (field.FieldType == typeof (EncryptedField))
        obj = (object) new EncryptedField()
        {
          Value = value
        };
      else if (field.FieldType == typeof (PasswordFieldType))
      {
        PasswordFieldType passwordFieldType = new PasswordFieldType();
        passwordFieldType.Value = value;
        obj = (object) passwordFieldType;
      }
      else
        obj = Convert.ChangeType((object) value, field.FieldType);
      field.SetValue(this._Target, obj);
    }
  }
}
