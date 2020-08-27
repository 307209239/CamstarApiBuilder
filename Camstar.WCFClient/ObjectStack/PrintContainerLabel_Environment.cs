// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintContainerLabel_Environment
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
  public class PrintContainerLabel_Environment : PrintLabelTxn_Environment
  {
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, true, false, "NamedObjectRef", 1050609, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_PrintQueue")]
    protected new Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_CurrentContainerStatus")]
    [Metadata("Current status information of a Container", "CurrentContainerStatus", false, false, true, "CurrentContainerStatus", 1050388, true, false, false, null)]
    protected CurrentContainerStatus_Environment _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_PrinterLabelDefinition")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, true, false, "RevisionedObjectRef", 1050616, false, false, true, null)]
    protected new Environment _PrinterLabelDefinition;
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, false, false, "RevisionedObjectRef", 1051849, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_RecipeList")]
    protected Environment _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    protected Environment _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_LabelCount")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1050617, false, false, false, null)]
    protected new Environment _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_HistoryId")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_NoPrinterDefinition")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053058, false, false, false, "0")]
    protected Environment _NoPrinterDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected new Environment _Factory;
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_WorkCenter")]
    protected Environment _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, false, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "PrintContainerLabel_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _Resource;

    public new Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public CurrentContainerStatus_Environment CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus_Environment) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public new Environment PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public Environment RecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeList));
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

    public new Environment LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelCount));
      }
    }

    public Environment Container
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment NoPrinterDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (NoPrinterDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NoPrinterDefinition));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }

    public Environment WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
