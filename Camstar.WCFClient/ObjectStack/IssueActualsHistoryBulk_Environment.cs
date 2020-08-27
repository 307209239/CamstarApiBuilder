// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryBulk_Environment
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
  public class IssueActualsHistoryBulk_Environment : IssueActualsHistory_Environment
  {
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, true, "NamedObjectRef", 1051865, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Environment_FromCarrier")]
    protected Environment _FromCarrier;
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, true, "ContainerRef", 1051864, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Environment_FromBatch")]
    protected Environment _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Environment_IssuedFrom")]
    [Metadata("Generic String", "", false, false, true, "String", 1050419, false, false, false, null)]
    protected new Environment _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Environment_FromContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049456, false, false, false, null)]
    protected Environment _FromContainer;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049689, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Environment_FromLocation")]
    protected Environment _FromLocation;

    public Environment FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public Environment FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromBatch));
      }
    }

    public new Environment IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Environment FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Environment FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromLocation));
      }
    }
  }
}
