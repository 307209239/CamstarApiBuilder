// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelTagChanges
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
  public class LabelTagChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_Expression")]
    protected Primitive<string> _Expression;
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_DefaultValue")]
    protected Primitive<string> _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is LabelTagChanges && object.Equals((object) this._ListItemToChange, (object) ((LabelTagChanges) obj)._ListItemToChange) && (object.Equals((object) this._Expression, (object) ((LabelTagChanges) obj)._Expression) && object.Equals((object) this._DefaultValue, (object) ((LabelTagChanges) obj)._DefaultValue)) && (object.Equals((object) this._ObjectToChange, (object) ((LabelTagChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((LabelTagChanges) obj)._Name)) && base.Equals(obj);
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

    public Primitive<string> Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Expression));
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
