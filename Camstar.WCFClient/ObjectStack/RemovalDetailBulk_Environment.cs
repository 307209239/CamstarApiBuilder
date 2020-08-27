// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetailBulk_Environment
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
  public class RemovalDetailBulk_Environment : RemovalDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Environment_IssueControl")]
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049463, false, false, true, "2")]
    protected new Environment _IssueControl;
    [Metadata("Records the actual values issued to meet the BOM line item requirements for issue type bulk.", "IssueActualsHistoryBulk", false, false, false, "SubentityRef", 1049872, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Environment_IssueActualHistory")]
    protected new Environment _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Environment_OpenClosedContainer")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049874, false, false, false, "1")]
    protected Environment _OpenClosedContainer;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049492, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Environment_DestinationContainer")]
    protected Environment _DestinationContainer;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779407, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Environment_ScrapContainer")]
    protected Environment _ScrapContainer;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailBulk_Environment_DestinationLocation")]
    protected Environment _DestinationLocation;

    public new Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public new Environment IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualHistory));
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

    public Environment ScrapContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScrapContainer));
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
