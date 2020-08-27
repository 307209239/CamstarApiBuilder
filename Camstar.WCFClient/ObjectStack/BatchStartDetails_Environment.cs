// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStartDetails_Environment
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
  public class BatchStartDetails_Environment : StartDetails_Environment
  {
    [Metadata("Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).", "StartReason", false, true, false, "NamedObjectRef", 1048846, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_StartReason")]
    protected new Environment _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, true, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected new Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_MasterRecipe")]
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, true, false, "RevisionedObjectRef", 1051846, false, false, true, null)]
    protected Environment _MasterRecipe;
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, true, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Status of a Batch.", "BatchStatusEnum", false, false, false, "Integer", 1051840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_BatchStatus")]
    protected Environment _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_ChildContainers")]
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "BatchStartDetails", false, false, false, "BatchStartDetails", 1048769, false, true, false, null)]
    protected BatchStartDetails_Environment _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_DueDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    protected new Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_ContainerName")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051841, false, false, false, null)]
    protected new Environment _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_PlannedQty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048827, false, false, false, null)]
    protected new Environment _PlannedQty;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, true, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_Owner")]
    protected new Environment _Owner;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_Qty")]
    protected new Environment _Qty;
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, false, "NamedObjectRef", 1049086, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_PriorityCode")]
    protected new Environment _PriorityCode;
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, true, false, "NamedObjectRef", 1048810, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_MfgOrder")]
    protected new Environment _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_BatchComments")]
    [Metadata("Message text.", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _BatchComments;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_Product")]
    protected new Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartDetails_Environment_Level")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, true, false, "NamedObjectRef", 1048809, false, false, true, null)]
    protected new Environment _Level;

    public new Environment StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartReason));
      }
    }

    public new Environment UOM
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

    public Environment MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment BatchStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BatchStatus));
      }
    }

    public BatchStartDetails_Environment ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (BatchStartDetails_Environment) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public new Environment DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDate));
      }
    }

    public new Environment ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerName));
      }
    }

    public new Environment PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public new Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }

    public new Environment Qty
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

    public new Environment PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public new Environment MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Environment BatchComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BatchComments));
      }
    }

    public new Environment Product
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

    public new Environment Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Level));
      }
    }
  }
}
