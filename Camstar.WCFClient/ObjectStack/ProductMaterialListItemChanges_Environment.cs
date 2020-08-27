// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductMaterialListItemChanges_Environment
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
  public class ProductMaterialListItemChanges_Environment : MaterialListItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Environment_ListItemToChange")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "ProductMaterialListItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, true, false, "Integer", 1049491, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Environment_IssueControl")]
    protected new Environment _IssueControl;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Environment_ObjectToChange")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "ProductMaterialListItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A bill of material defines the materials needed to produce a specific product.", "BOM", false, false, false, "RevisionedObjectRef", 1049924, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Environment_PhantomBill")]
    protected new Environment _PhantomBill;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049914, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Environment_IssuePoint")]
    protected new Environment _IssuePoint;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051653, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Environment_Name")]
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

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
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

    public new Environment IssuePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuePoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuePoint));
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
