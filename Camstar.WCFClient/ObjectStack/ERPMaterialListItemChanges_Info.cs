// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPMaterialListItemChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (BOMMaterialListItemChanges_Info))]
  [KnownType(typeof (MfgOrderMaterialListItmChanges_Info))]
  [Serializable]
  public class ERPMaterialListItemChanges_Info : MaterialListItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_PhantomBill")]
    protected new Info _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_RouteStep")]
    protected Info _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_IssueControl")]
    protected new Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_ERPReportingFlag")]
    protected Info _ERPReportingFlag;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_DefaultLot")]
    protected Info _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_ERPLineItem")]
    protected Info _ERPLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_DefaultStockPoint")]
    protected Info _DefaultStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_SubFactory")]
    protected Info _SubFactory;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Info_Name")]
    protected new Info _Name;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Info PhantomBill
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBill), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhantomBill));
      }
    }

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

    public Info RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RouteStep));
      }
    }

    public new Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Info ERPReportingFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPReportingFlag), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPReportingFlag));
      }
    }

    public Info DefaultLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultLot));
      }
    }

    public Info ERPLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPLineItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPLineItem));
      }
    }

    public Info DefaultStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultStockPoint));
      }
    }

    public Info SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubFactory));
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
