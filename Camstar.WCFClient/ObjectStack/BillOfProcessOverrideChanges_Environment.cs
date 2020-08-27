// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessOverrideChanges_Environment
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
  public class BillOfProcessOverrideChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_ESigTxnMap")]
    [Metadata("Transaction map for container services.", "ContainerESigTxnMapChanges", false, false, false, "ContainerESigTxnMapChanges", 1050351, false, true, false, null)]
    protected ContainerESigTxnMapChanges_Environment _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_ResourceGroup")]
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    protected Environment _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_ObjectToChange")]
    [Metadata("A new Named Subentity is added to the system to maintain the Bill of Process overrides to the Spec values", "BillOfProcessOverride", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Provides the framework for executing a series of Tasks at the Spec.  An Electronic Procedure defines a set of instructions (a checklisst for performing a set of tasks), and is compose of one ore more TaskLists.", "ElectronicProcedure", false, false, false, "RevisionedObjectRef", 1050523, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_ElectronicProcedure")]
    protected Environment _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_TrainingReqGroup")]
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    protected Environment _TrainingReqGroup;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, true, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_Spec")]
    protected Environment _Spec;
    [Metadata("Changes CDO for TxnMap.", "TxnMapChanges", false, false, false, "TxnMapChanges", 1049022, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_TxnMap")]
    protected TxnMapChanges_Environment _TxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_LabelTxnMap")]
    [Metadata("Contains a match between a service and a label definition to be printed.", "ContainerLabelMapChanges", false, false, false, "ContainerLabelMapChanges", 1050618, false, true, false, null)]
    protected ContainerLabelMapChanges_Environment _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_ListItemToChange")]
    [Metadata("Changes CDO for Bill Of Process Override", "BillOfProcessOverrideChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_SpecDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _SpecDescription;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_RecipeFile")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048606, false, false, true, null)]
    protected Environment _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_DocumentSet")]
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    protected Environment _DocumentSet;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1049008, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_Setup")]
    protected Environment _Setup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050932, false, false, false, null)]
    protected new Environment _Name;

    public ContainerESigTxnMapChanges_Environment ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMapChanges_Environment) this.PropertyGet(nameof (ESigTxnMap));
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

    public TxnMapChanges_Environment TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMapChanges_Environment) this.PropertyGet(nameof (TxnMap));
      }
    }

    public ContainerLabelMapChanges_Environment LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMapChanges_Environment) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

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

    public Environment SpecDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecDescription));
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
