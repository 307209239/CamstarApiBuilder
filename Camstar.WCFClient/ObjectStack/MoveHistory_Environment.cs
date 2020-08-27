// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (TransferHistory_Environment))]
  [KnownType(typeof (ShipHistory_Environment))]
  [KnownType(typeof (ReworkHistory_Environment))]
  [Serializable]
  public class MoveHistory_Environment : MovementHistory_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Step")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1049032, false, false, false, null)]
    protected Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_HistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Qty2")]
    protected new Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_ToStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1048929, false, false, false, null)]
    protected Environment _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048854, false, false, false, null)]
    protected new Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048853, false, false, false, null)]
    protected new Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_ChildCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048770, false, false, false, null)]
    protected new Environment _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049202, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Close")]
    protected Environment _Close;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049217, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_ToStepUsage")]
    protected Environment _ToStepUsage;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_UnitCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048852, false, false, false, null)]
    protected new Environment _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_MoveAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049211, false, false, false, "0")]
    protected Environment _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_ElapsedTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049199, false, false, false, null)]
    protected new Environment _ElapsedTime;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_ToLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, false, null)]
    protected Environment _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Owner")]
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048824, false, false, false, null)]
    protected new Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected new Environment _Product;
    [Metadata("Current Setup number. This value is used to identify all of the work that is performed using a specific Setup. The value is set (incremented) as part of the Resource Setup transaction. All Throughput and Movement transactions record this value in their history transactions.", "", false, false, false, "String", 1048668, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Run")]
    protected new Environment _Run;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1049055, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_ToResource")]
    protected Environment _ToResource;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Qty")]
    protected new Environment _Qty;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1049008, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Setup")]
    protected new Environment _Setup;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, true, "NamedSubentityRef", 1048660, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Location")]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_Path")]
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, false, "NamedSubentityRef", 1049030, false, false, false, null)]
    protected Environment _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Environment_CycleTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049198, false, false, false, null)]
    protected new Environment _CycleTime;

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

    public Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

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

    public Environment ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStep));
      }
    }

    public new Environment UOM2
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

    public new Environment ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildCount));
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

    public Environment Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Close));
      }
    }

    public Environment ToStepUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStepUsage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStepUsage));
      }
    }

    public new Environment UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Environment MoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MoveAllQty));
      }
    }

    public new Environment ElapsedTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElapsedTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ElapsedTime));
      }
    }

    public Environment ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToLocation));
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

    public new Environment Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Run));
      }
    }

    public Environment ToResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToResource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToResource));
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

    public new Environment Setup
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

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }

    public Environment Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Path));
      }
    }

    public new Environment CycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (CycleTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CycleTime));
      }
    }
  }
}
