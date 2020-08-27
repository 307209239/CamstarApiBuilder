// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanDisposition_Environment
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
  public class PlanDisposition_Environment : Plan_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanDisposition_Environment_EventLots")]
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, true, "SubentityRef", 1051071, false, true, false, null)]
    protected Environment _EventLots;
    [DataMember(EmitDefaultValue = false, Name = "PlanDisposition_Environment_AssignedLots")]
    [Metadata("Service details for available lots", "AvailableLotDetail", false, false, true, "AvailableLotDetail", 1052032, false, true, false, null)]
    protected AvailableLotDetail_Environment _AssignedLots;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanDisposition_Environment_Name")]
    protected new Environment _Name;

    public Environment EventLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLots), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventLots));
      }
    }

    public AvailableLotDetail_Environment AssignedLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail_Environment) this.PropertyGet(nameof (AssignedLots));
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
