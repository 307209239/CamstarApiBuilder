// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPRouteChanges
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
  public class ERPRouteChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_RouteStepItem")]
    protected NamedSubentityRef _RouteStepItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_RouteSteps")]
    protected RouteStepChanges[] _RouteSteps;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_ERPItem")]
    protected Primitive<string> _ERPItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ERPRouteChanges && object.Equals((object) this._ObjectToChange, (object) ((ERPRouteChanges) obj)._ObjectToChange) && (object.Equals((object) this._Base, (object) ((ERPRouteChanges) obj)._Base) && object.Equals((object) this._RouteStepItem, (object) ((ERPRouteChanges) obj)._RouteStepItem)) && (this.CompareArrays((Array) this._RouteSteps, (Array) ((ERPRouteChanges) obj)._RouteSteps) && object.Equals((object) this._ERPItem, (object) ((ERPRouteChanges) obj)._ERPItem) && (object.Equals((object) this._Product, (object) ((ERPRouteChanges) obj)._Product) && object.Equals((object) this._Name, (object) ((ERPRouteChanges) obj)._Name))) && base.Equals(obj);
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public NamedSubentityRef RouteStepItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStepItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (RouteStepItem));
      }
    }

    public RouteStepChanges[] RouteSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteSteps), (object) value);
      }
      get
      {
        return (RouteStepChanges[]) this.PropertyGet(nameof (RouteSteps));
      }
    }

    public Primitive<string> ERPItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPItem), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ERPItem));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
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
