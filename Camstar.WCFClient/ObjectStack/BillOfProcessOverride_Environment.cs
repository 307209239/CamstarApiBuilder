// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessOverride_Environment
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
  public class BillOfProcessOverride_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, true, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_ESigTxnMap")]
    [Metadata("Transaction Map for Container Transaction.", "ContainerESigTxnMap", false, false, true, "ContainerESigTxnMap", 1050351, false, true, false, null)]
    protected ContainerESigTxnMap_Environment _ESigTxnMap;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, true, "NamedObjectRef", 1050473, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_TrainingReqGroup")]
    protected Environment _TrainingReqGroup;
    [Metadata("Provides the framework for executing a series of Tasks at the Spec.  An Electronic Procedure defines a set of instructions (a checklisst for performing a set of tasks), and is compose of one ore more TaskLists.", "ElectronicProcedure", false, false, true, "RevisionedObjectRef", 1050523, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_ElectronicProcedure")]
    protected Environment _ElectronicProcedure;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, true, "NamedObjectRef", 1048761, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_ResourceGroup")]
    protected Environment _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_LabelTxnMap")]
    [Metadata("Contains a match between a service and a label definition to be printed.", "ContainerLabelMap", false, false, true, "ContainerLabelMap", 1050618, false, true, false, null)]
    protected ContainerLabelMap_Environment _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_TxnMap")]
    [Metadata("A Transaction Map is used within a Specification for three purposes. The first is to specify a User Defined transaction that is to take the place of a standard transaction. The second is to associate a Data Collection Definition to a transaction. The third is to determine which transactions (if any) must be performed and in what order, to consider the work complete (and allow a Move-out transaction).\r\n\r\nSequencing transactions and defining them as Required versus Optional is a simplistic approach to defining “What’s Next?” within a processing step. While this is more than adequate for a first release, this is an area where a more comprehensive approach (i.e., scripting logic) may be appropriate in future releases. Other similar areas include Instructions and Path Selection.", "TxnMap", false, false, true, "TxnMap", 1049022, false, true, false, null)]
    protected TxnMap_Environment _TxnMap;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, true, "RevisionedObjectRef", 1048606, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_RecipeFile")]
    protected Environment _RecipeFile;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1048646, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050932, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_Setup")]
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, true, "RevisionedObjectRef", 1049008, false, false, false, null)]
    protected Environment _Setup;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

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

    public ContainerESigTxnMap_Environment ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMap_Environment) this.PropertyGet(nameof (ESigTxnMap));
      }
    }

    public Environment TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Environment ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public ContainerLabelMap_Environment LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMap_Environment) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public TxnMap_Environment TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMap_Environment) this.PropertyGet(nameof (TxnMap));
      }
    }

    public Environment RecipeFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeFile));
      }
    }

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
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

    public Environment Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Setup));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
