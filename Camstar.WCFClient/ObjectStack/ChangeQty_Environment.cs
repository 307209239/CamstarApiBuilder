// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeQty_Environment
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
  public class ChangeQty_Environment : ContainerTxn_Environment
  {
    [Metadata("The user code for rollup reason.", "RollupReason", false, false, false, "NamedObjectRef", 1049500, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_RollupReason")]
    protected Environment _RollupReason;
    [Metadata("ChangeQtyDetails are the individual items a user inputs to specifically explain why the quantity is being changed.", "ChangeQtyDetails", false, true, false, "ChangeQtyDetails", 1049662, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_ServiceDetails")]
    protected ChangeQtyDetails_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    protected new Environment _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_RecordAllQtySummaryOnly")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049347, false, false, false, "1")]
    protected Environment _RecordAllQtySummaryOnly;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049726, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_GenerateRollups")]
    protected Environment _GenerateRollups;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049346, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_ThruputSummary")]
    protected Environment _ThruputSummary;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_ProcessESignatures")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    protected new Environment _ProcessESignatures;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049665, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_DisassociateWhenClosed")]
    protected Environment _DisassociateWhenClosed;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_CloseWhenZero")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049342, false, false, false, "1")]
    protected Environment _CloseWhenZero;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_Resource")]
    protected Environment _Resource;
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1048988, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Environment_ThruputReportingLevel")]
    protected Environment _ThruputReportingLevel;

    public Environment RollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RollupReason));
      }
    }

    public ChangeQtyDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChangeQtyDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Environment Carrier
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

    public Environment RecordAllQtySummaryOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQtySummaryOnly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordAllQtySummaryOnly));
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

    public Environment GenerateRollups
    {
      [param: In] set
      {
        this.PropertySet(nameof (GenerateRollups), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GenerateRollups));
      }
    }

    public Environment ThruputSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputSummary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputSummary));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Environment DisassociateWhenClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateWhenClosed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisassociateWhenClosed));
      }
    }

    public Environment CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseWhenZero));
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

    public Environment ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }
  }
}
