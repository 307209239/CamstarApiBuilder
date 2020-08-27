// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserAttributeChanges
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
  public class UserAttributeChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_AttributeValue")]
    protected Primitive<string> _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_DataType")]
    protected Enumeration<TrivialTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_IsExpression")]
    protected Primitive<bool> _IsExpression;

    public override bool Equals(object obj)
    {
      return obj is UserAttributeChanges && object.Equals((object) this._AttributeValue, (object) ((UserAttributeChanges) obj)._AttributeValue) && (object.Equals((object) this._DataType, (object) ((UserAttributeChanges) obj)._DataType) && object.Equals((object) this._Name, (object) ((UserAttributeChanges) obj)._Name)) && (object.Equals((object) this._ObjectToChange, (object) ((UserAttributeChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((UserAttributeChanges) obj)._ListItemToChange) && object.Equals((object) this._IsExpression, (object) ((UserAttributeChanges) obj)._IsExpression)) && base.Equals(obj);
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

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
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
  }
}
