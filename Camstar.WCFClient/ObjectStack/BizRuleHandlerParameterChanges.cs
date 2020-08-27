// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleHandlerParameterChanges
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
  public class BizRuleHandlerParameterChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_ObjectDisplayValue")]
    protected Primitive<string> _ObjectDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_DefaultValue")]
    protected Primitive<string> _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_DataTypeName")]
    protected Primitive<string> _DataTypeName;

    public override bool Equals(object obj)
    {
      return obj is BizRuleHandlerParameterChanges && object.Equals((object) this._ObjectType, (object) ((BizRuleHandlerParameterChanges) obj)._ObjectType) && (object.Equals((object) this._ObjectDisplayValue, (object) ((BizRuleHandlerParameterChanges) obj)._ObjectDisplayValue) && object.Equals((object) this._DataType, (object) ((BizRuleHandlerParameterChanges) obj)._DataType)) && (object.Equals((object) this._DefaultValue, (object) ((BizRuleHandlerParameterChanges) obj)._DefaultValue) && object.Equals((object) this._Name, (object) ((BizRuleHandlerParameterChanges) obj)._Name) && (object.Equals((object) this._ObjectTypeName, (object) ((BizRuleHandlerParameterChanges) obj)._ObjectTypeName) && object.Equals((object) this._DataTypeName, (object) ((BizRuleHandlerParameterChanges) obj)._DataTypeName))) && base.Equals(obj);
    }

    public Primitive<int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Primitive<string> ObjectDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectDisplayValue));
      }
    }

    public Enumeration<DataTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public Primitive<string> DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultValue));
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

    public Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Primitive<string> DataTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DataTypeName));
      }
    }
  }
}
