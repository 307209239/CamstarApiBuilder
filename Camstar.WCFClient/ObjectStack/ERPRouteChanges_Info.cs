// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPRouteChanges_Info
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
  public class ERPRouteChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Info_RouteStepItem")]
    protected Info _RouteStepItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Info_RouteSteps")]
    protected RouteStepChanges_Info _RouteSteps;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Info_ERPItem")]
    protected Info _ERPItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info RouteStepItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStepItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RouteStepItem));
      }
    }

    public RouteStepChanges_Info RouteSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteSteps), (object) value);
      }
      get
      {
        return (RouteStepChanges_Info) this.PropertyGet(nameof (RouteSteps));
      }
    }

    public Info ERPItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPItem));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
