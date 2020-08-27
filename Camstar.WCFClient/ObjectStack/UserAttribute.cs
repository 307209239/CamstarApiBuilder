// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserAttribute
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UserAttribute : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_AttributeValue")]
    protected Primitive<string> _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_DataType")]
    protected Enumeration<TrivialTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_IsExpression")]
    protected Primitive<bool> _IsExpression;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UserAttribute && object.Equals((object) this._ExportImportKey, (object) ((UserAttribute) obj)._ExportImportKey) && (object.Equals((object) this._AttributeValue, (object) ((UserAttribute) obj)._AttributeValue) && object.Equals((object) this._DataType, (object) ((UserAttribute) obj)._DataType)) && (object.Equals((object) this._Name, (object) ((UserAttribute) obj)._Name) && object.Equals((object) this._IsExpression, (object) ((UserAttribute) obj)._IsExpression) && object.Equals((object) this._IsFrozen, (object) ((UserAttribute) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> AttributeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeValue));
      }
    }

    public Enumeration<TrivialTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<bool> IsExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsExpression), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsExpression));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
