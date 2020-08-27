// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteStepChanges
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
  public class RouteStepChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_ERPOperation")]
    protected Primitive<string> _ERPOperation;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Sequence")]
    protected Primitive<string> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "RouteStepChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is RouteStepChanges && object.Equals((object) this._ListItemToChange, (object) ((RouteStepChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((RouteStepChanges) obj)._ObjectToChange) && object.Equals((object) this._ERPOperation, (object) ((RouteStepChanges) obj)._ERPOperation)) && (object.Equals((object) this._Sequence, (object) ((RouteStepChanges) obj)._Sequence) && object.Equals((object) this._Description, (object) ((RouteStepChanges) obj)._Description) && object.Equals((object) this._Name, (object) ((RouteStepChanges) obj)._Name)) && base.Equals(obj);
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

    public Primitive<string> ERPOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPOperation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ERPOperation));
      }
    }

    public Primitive<string> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
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
