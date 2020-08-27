// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityDisposition_Environment
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
  public class ActivityDisposition_Environment : Activity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Environment_EventFailures")]
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, true, "SubentityRef", 1052083, false, true, false, null)]
    protected Environment _EventFailures;
    [Metadata("Disposition Data", "DispositionData", false, false, true, "DispositionData", 1051588, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Environment_DispositionData")]
    protected DispositionData_Environment _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Environment_Disposition")]
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, true, "NamedObjectRef", 1051582, false, false, false, null)]
    protected Environment _Disposition;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052020, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Environment_ReconcileQuantity")]
    protected Environment _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Environment_DisplayConformingQuantity")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052019, false, false, false, "0")]
    protected Environment _DisplayConformingQuantity;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDisposition_Environment_Name")]
    protected new Environment _Name;

    public Environment EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventFailures));
      }
    }

    public DispositionData_Environment DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (DispositionData_Environment) this.PropertyGet(nameof (DispositionData));
      }
    }

    public Environment Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Disposition));
      }
    }

    public Environment ReconcileQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReconcileQuantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReconcileQuantity));
      }
    }

    public Environment DisplayConformingQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayConformingQuantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayConformingQuantity));
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
