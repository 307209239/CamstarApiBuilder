// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentContainerStatus_Environment
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
  public class CurrentContainerStatus_Environment : ViewContainerAsParent_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048837, false, false, false, null)]
    protected new Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_MasterRecipe")]
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    protected Environment _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Attributes")]
    [Metadata("A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.", "UserAttribute", false, false, true, "UserAttribute", 1051932, false, true, false, null)]
    protected UserAttribute_Environment _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, true, "NamedObjectRef", 1051807, false, false, false, null)]
    protected Environment _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Timers")]
    [Metadata("Timer", "Timer", false, false, false, "Timer", 16778633, false, true, false, null)]
    protected Timer_Environment _Timers;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052559, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_IsOnHold")]
    protected Environment _IsOnHold;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_ContainerStatusName")]
    [Metadata("Generic String", "", false, false, false, "String", 1049675, false, false, false, null)]
    protected Environment _ContainerStatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_BatchStatus")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051848, false, false, false, null)]
    protected Environment _BatchStatus;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Generic String", "", false, false, true, "String", 1051848, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_BatchStatusName")]
    protected Environment _BatchStatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_FactoryStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049313, false, false, false, null)]
    protected Environment _FactoryStartDate;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_ExpirationDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050479, false, false, false, null)]
    protected Environment _ExpirationDate;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049086, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_PriorityCodeName")]
    protected new Environment _PriorityCodeName;
    [Metadata("A Document Entry is used to include a Document in a Document and provide a description for it within the Document Set. If there is more than one Document within a Document Set when a request is made to display a Document Set, the list of Document Entries is used to build a selection list. (Note that a one-to-one relationship between a Document Set and a Document is likely the common scenario).", "DocumentEntry", false, false, false, "NamedSubentityRef", 16777592, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Documents")]
    protected Environment _Documents;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049278, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_ContainerLevelName")]
    protected new Environment _ContainerLevelName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_ContainerName")]
    protected new Environment _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_NextOperationName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050387, false, false, false, null)]
    protected Environment _NextOperationName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_UOMName")]
    protected new Environment _UOMName;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Qty")]
    protected new Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048709, false, false, false, null)]
    protected new Environment _ProductName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048810, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_MfgOrderName")]
    protected new Environment _MfgOrderName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_WorkflowName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050233, false, false, false, null)]
    protected Environment _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected new Environment _Product;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "DocumentSet", 1048646, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_DocumentSets")]
    protected DocumentSet_Environment _DocumentSets;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_CarrierName")]
    protected Environment _CarrierName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_UOM2Name")]
    protected new Environment _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_StatusName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050396, false, false, false, null)]
    protected new Environment _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_MasterRecipeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050229, false, false, false, null)]
    protected Environment _MasterRecipeName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentContainerStatus_Environment_SpecName")]
    protected Environment _SpecName;

    public new Environment Qty2
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

    public UserAttribute_Environment Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttribute_Environment) this.PropertyGet(nameof (Attributes));
      }
    }

    public Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public Timer_Environment Timers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timers), (object) value);
      }
      get
      {
        return (Timer_Environment) this.PropertyGet(nameof (Timers));
      }
    }

    public Environment IsOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOnHold), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsOnHold));
      }
    }

    public Environment ContainerStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerStatusName));
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

    public Environment BatchStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BatchStatusName));
      }
    }

    public Environment FactoryStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryStartDate));
      }
    }

    public Environment ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public new Environment PriorityCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCodeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityCodeName));
      }
    }

    public Environment Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Documents));
      }
    }

    public new Environment ContainerLevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerLevelName));
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

    public Environment NextOperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextOperationName));
      }
    }

    public new Environment UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOMName));
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

    public new Environment ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductName));
      }
    }

    public new Environment MfgOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrderName));
      }
    }

    public Environment WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowName));
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

    public DocumentSet_Environment DocumentSets
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSets), (object) value);
      }
      get
      {
        return (DocumentSet_Environment) this.PropertyGet(nameof (DocumentSets));
      }
    }

    public Environment CarrierName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CarrierName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CarrierName));
      }
    }

    public new Environment UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2Name));
      }
    }

    public new Environment StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusName));
      }
    }

    public Environment MasterRecipeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MasterRecipeName));
      }
    }

    public Environment SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecName));
      }
    }
  }
}
