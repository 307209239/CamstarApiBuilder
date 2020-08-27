// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPMaterialListItemChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BOMMaterialListItemChanges_Environment))]
  [KnownType(typeof (MfgOrderMaterialListItmChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ERPMaterialListItemChanges_Environment : MaterialListItemChanges_Environment
  {
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_PhantomBill")]
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOM", false, false, false, "RevisionedObjectRef", 1049924, false, false, true, null)]
    protected new Environment _PhantomBill;
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, false, "NamedSubentityRef", 1049917, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_RouteStep")]
    protected Environment _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_IssueControl")]
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049491, false, false, true, null)]
    protected new Environment _IssueControl;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050327, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_ERPReportingFlag")]
    protected Environment _ERPReportingFlag;
    [Metadata("Generic String", "", false, false, false, "String", 1050325, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_DefaultLot")]
    protected Environment _DefaultLot;
    [Metadata("Generic String", "", false, false, false, "String", 1050329, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_ERPLineItem")]
    protected Environment _ERPLineItem;
    [Metadata("Generic String", "", false, false, false, "String", 1050328, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_DefaultStockPoint")]
    protected Environment _DefaultStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_SubFactory")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050316, false, false, false, null)]
    protected Environment _SubFactory;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051649, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItemChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment PhantomBill
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBill), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhantomBill));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteStep));
      }
    }

    public new Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Environment ERPReportingFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPReportingFlag), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPReportingFlag));
      }
    }

    public Environment DefaultLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultLot));
      }
    }

    public Environment ERPLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPLineItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPLineItem));
      }
    }

    public Environment DefaultStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultStockPoint));
      }
    }

    public Environment SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubFactory));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
