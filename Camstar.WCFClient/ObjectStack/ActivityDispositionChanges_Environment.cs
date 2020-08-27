// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityDispositionChanges_Environment
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
  public class ActivityDispositionChanges_Environment : ActivityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_EventFailures")]
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, false, "SubentityRef", 1052083, false, true, false, null)]
    protected Environment _EventFailures;
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, false, "EventFailure", 1052049, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_AvailableFailures")]
    protected EventFailure_Environment _AvailableFailures;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_DispositionData")]
    [Metadata("DispositionDataChanges", "DispositionDataChanges", false, false, false, "DispositionDataChanges", 1051588, false, true, false, null)]
    protected DispositionDataChanges_Environment _DispositionData;
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, true, false, "NamedObjectRef", 1051582, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_Disposition")]
    protected Environment _Disposition;
    [Metadata("This activity is used to disposition material reported in the quality system.", "ActivityDisposition", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_ReconcileQuantity")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052020, false, false, false, "0")]
    protected Environment _ReconcileQuantity;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052019, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_DisplayConformingQuantity")]
    protected Environment _DisplayConformingQuantity;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionChanges_Environment_Name")]
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

    public EventFailure_Environment AvailableFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableFailures), (object) value);
      }
      get
      {
        return (EventFailure_Environment) this.PropertyGet(nameof (AvailableFailures));
      }
    }

    public DispositionDataChanges_Environment DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (DispositionDataChanges_Environment) this.PropertyGet(nameof (DispositionData));
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
