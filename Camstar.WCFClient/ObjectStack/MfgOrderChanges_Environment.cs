// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgOrderChanges_Environment
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
  public class MfgOrderChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("ERP Production Order status.  Can include values like \"Released\", \"Completed\", \"In Process\", \"Closed\", \"Cancelled\"", "OrderStatus", false, false, false, "NamedObjectRef", 1050326, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_OrderStatus")]
    protected Environment _OrderStatus;
    [Metadata("ERP Manufaturing Order type.  Several different values that can appear here include: \"Standard\", \"Rework\", \"Test Run\", etc", "OrderType", false, false, false, "NamedObjectRef", 1050323, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_OrderType")]
    protected Environment _OrderType;
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOM", false, false, false, "RevisionedObjectRef", 1049920, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ERPBOM")]
    protected Environment _ERPBOM;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1049648, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_UOM2")]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected Environment _UOM;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049652, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_Qty2")]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_WIPMsgDefMgr")]
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ERPRoute")]
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a mirror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRoute", false, false, false, "RevisionedObjectRef", 1049919, false, false, true, null)]
    protected Environment _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_MaterialList")]
    [Metadata("Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.  This particular type of material list item is used on Mfg orders, and was created so that MfgOrder component lists could be stored in a separate table from BOM or Container component lists.", "MfgOrderMaterialListItmChanges", false, false, false, "MfgOrderMaterialListItmChanges", 1049427, false, true, false, null)]
    protected MfgOrderMaterialListItmChanges_Environment _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_BillOfProcess")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, true, null)]
    protected Environment _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_Attributes")]
    [Metadata("A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.", "UserAttributeChanges", false, false, false, "UserAttributeChanges", 1051932, false, true, false, null)]
    protected UserAttributeChanges_Environment _Attributes;
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, false, "NamedObjectRef", 1051905, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ContainerNumberingRule")]
    protected Environment _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_PlannedStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050318, false, false, false, null)]
    protected Environment _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ExternallyControlled")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050310, false, false, false, "0")]
    protected Environment _ExternallyControlled;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051453, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_PlannedStartDateGMT")]
    protected Environment _PlannedStartDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051452, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_PlannedCompletionDateGMT")]
    protected Environment _PlannedCompletionDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ReleaseDateGMT")]
    protected Environment _ReleaseDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_PlannedCompletionDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050319, false, false, false, null)]
    protected Environment _PlannedCompletionDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050322, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ReleaseDate")]
    protected Environment _ReleaseDate;
    [Metadata("Generic String", "", false, false, false, "String", 1050325, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_DefaultLot")]
    protected Environment _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ObjectToChange")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050068, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, false, "NamedObjectRef", 1050015, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_Priority")]
    protected Environment _Priority;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048623, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_Containers")]
    protected Environment _Containers;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048712, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_DefaultPutawayStockPoint")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050320, false, false, false, null)]
    protected Environment _DefaultPutawayStockPoint;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1050324, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_ReportingFactory")]
    protected Environment _ReportingFactory;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_BeginProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048996, false, false, true, null)]
    protected Environment _BeginProduct;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _Product;

    public Environment OrderStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrderStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OrderStatus));
      }
    }

    public Environment OrderType
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrderType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OrderType));
      }
    }

    public Environment ERPBOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPBOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPBOM));
      }
    }

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Environment ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public MfgOrderMaterialListItmChanges_Environment MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (MfgOrderMaterialListItmChanges_Environment) this.PropertyGet(nameof (MaterialList));
      }
    }

    public Environment BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public UserAttributeChanges_Environment Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges_Environment) this.PropertyGet(nameof (Attributes));
      }
    }

    public Environment ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Environment PlannedStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedStartDate));
      }
    }

    public Environment ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExternallyControlled));
      }
    }

    public Environment PlannedStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedStartDateGMT));
      }
    }

    public Environment PlannedCompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCompletionDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedCompletionDateGMT));
      }
    }

    public Environment ReleaseDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReleaseDateGMT));
      }
    }

    public Environment PlannedCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCompletionDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedCompletionDate));
      }
    }

    public Environment ReleaseDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReleaseDate));
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

    public Environment Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Priority));
      }
    }

    public Environment Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Containers));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public Environment DefaultPutawayStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPutawayStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultPutawayStockPoint));
      }
    }

    public Environment ReportingFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingFactory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportingFactory));
      }
    }

    public Environment BeginProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BeginProduct));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }
  }
}
