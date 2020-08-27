// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MovementHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MoveInHistory_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ThruputHistory_Environment))]
  [KnownType(typeof (MoveHistory_Environment))]
  [Serializable]
  public class MovementHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_HistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    protected Environment _Qty2;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048854, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_UOM2")]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048853, false, false, false, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_UnitCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048852, false, false, false, null)]
    protected Environment _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_ChildCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048770, false, false, false, null)]
    protected Environment _ChildCount;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_Owner")]
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [Metadata("Current Setup number. This value is used to identify all of the work that is performed using a specific Setup. The value is set (incremented) as part of the Resource Setup transaction. All Throughput and Movement transactions record this value in their history transactions.", "", false, false, false, "String", 1048668, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_Run")]
    protected Environment _Run;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_Setup")]
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1049008, false, false, false, null)]
    protected Environment _Setup;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_CycleTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049198, false, false, false, null)]
    protected Environment _CycleTime;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049199, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MovementHistory_Environment_ElapsedTime")]
    protected Environment _ElapsedTime;

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

    public Environment UnitCount
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

    public Environment ChildCount
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

    public Environment Owner
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

    public Environment Run
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

    public Environment CycleTime
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

    public Environment ElapsedTime
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
  }
}
