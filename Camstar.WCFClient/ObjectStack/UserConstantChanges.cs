// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserConstantChanges
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
  public class UserConstantChanges : TextVariableChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_VariableExpression")]
    protected new Primitive<string> _VariableExpression;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_DataType")]
    protected Enumeration<DataTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_UnresolvedValue")]
    protected new Primitive<string> _UnresolvedValue;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_VariableUsage")]
    protected new Enumeration<TextVariableTypeEnum, int> _VariableUsage;

    public override bool Equals(object obj)
    {
      return obj is UserConstantChanges && object.Equals((object) this._VariableExpression, (object) ((UserConstantChanges) obj)._VariableExpression) && (object.Equals((object) this._ObjectToChange, (object) ((UserConstantChanges) obj)._ObjectToChange) && object.Equals((object) this._DataType, (object) ((UserConstantChanges) obj)._DataType)) && (object.Equals((object) this._Name, (object) ((UserConstantChanges) obj)._Name) && object.Equals((object) this._UnresolvedValue, (object) ((UserConstantChanges) obj)._UnresolvedValue) && object.Equals((object) this._VariableUsage, (object) ((UserConstantChanges) obj)._VariableUsage)) && base.Equals(obj);
    }

    public new Primitive<string> VariableExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableExpression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (VariableExpression));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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

    public new Primitive<string> UnresolvedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnresolvedValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UnresolvedValue));
      }
    }

    public new Enumeration<TextVariableTypeEnum, int> VariableUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableUsage), (object) value);
      }
      get
      {
        return (Enumeration<TextVariableTypeEnum, int>) this.PropertyGet(nameof (VariableUsage));
      }
    }
  }
}
