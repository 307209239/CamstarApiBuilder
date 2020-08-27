// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TextVariableChanges
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
  public class TextVariableChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_VariableExpression")]
    protected Primitive<string> _VariableExpression;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_UnresolvedValue")]
    protected Primitive<string> _UnresolvedValue;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_VariableUsage")]
    protected Enumeration<TextVariableTypeEnum, int> _VariableUsage;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TextVariableChanges && object.Equals((object) this._VariableExpression, (object) ((TextVariableChanges) obj)._VariableExpression) && (object.Equals((object) this._ObjectToChange, (object) ((TextVariableChanges) obj)._ObjectToChange) && object.Equals((object) this._UnresolvedValue, (object) ((TextVariableChanges) obj)._UnresolvedValue)) && (object.Equals((object) this._VariableUsage, (object) ((TextVariableChanges) obj)._VariableUsage) && object.Equals((object) this._Name, (object) ((TextVariableChanges) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<string> VariableExpression
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

    public Primitive<string> UnresolvedValue
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

    public Enumeration<TextVariableTypeEnum, int> VariableUsage
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
  }
}
