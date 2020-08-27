// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailSerial_Environment
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
  public class RemovalHistoryDetailSerial_Environment : RemovalHistoryDetail_Environment
  {
    [Metadata("Records the actual values issued to meet the BOM line item requirements for issue type serial.", "IssueActualsHistorySerial", false, false, true, "SubentityRef", 1049765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_Environment_IssueActualsHistory")]
    protected new Environment _IssueActualsHistory;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049492, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_Environment_DestinationContainer")]
    protected Environment _DestinationContainer;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049874, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_Environment_OpenClosedContainer")]
    protected Environment _OpenClosedContainer;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailSerial_Environment_DestinationLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049875, false, false, false, null)]
    protected Environment _DestinationLocation;

    public new Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Environment DestinationContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DestinationContainer));
      }
    }

    public Environment OpenClosedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenClosedContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OpenClosedContainer));
      }
    }

    public Environment DestinationLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DestinationLocation));
      }
    }
  }
}
