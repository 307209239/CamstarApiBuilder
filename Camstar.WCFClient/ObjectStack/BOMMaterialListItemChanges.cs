// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BOMMaterialListItemChanges
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
  public class BOMMaterialListItemChanges : ERPMaterialListItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BOMMaterialListItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BOMMaterialListItemChanges_RouteStep")]
    protected new NamedSubentityRef _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "BOMMaterialListItemChanges_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "BOMMaterialListItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BOMMaterialListItemChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BOMMaterialListItemChanges && object.Equals((object) this._ListItemToChange, (object) ((BOMMaterialListItemChanges) obj)._ListItemToChange) && (object.Equals((object) this._RouteStep, (object) ((BOMMaterialListItemChanges) obj)._RouteStep) && object.Equals((object) this._IssueControl, (object) ((BOMMaterialListItemChanges) obj)._IssueControl)) && (object.Equals((object) this._ObjectToChange, (object) ((BOMMaterialListItemChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((BOMMaterialListItemChanges) obj)._Name)) && base.Equals(obj);
    }

    public new NamedSubentityRef ListItemToChange
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

    public new NamedSubentityRef RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (RouteStep));
      }
    }

    public new Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public new NamedSubentityRef ObjectToChange
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
