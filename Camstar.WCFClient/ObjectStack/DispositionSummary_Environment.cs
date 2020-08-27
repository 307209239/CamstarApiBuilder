// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionSummary_Environment
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
  public class DispositionSummary_Environment : ServiceDetails_Environment
  {
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, false, "EventFailure", 1052083, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_EventFailures")]
    protected EventFailure_Environment _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_QuantityAssigned")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052022, false, false, false, null)]
    protected Environment _QuantityAssigned;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052027, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_QuantityConforming")]
    protected Environment _QuantityConforming;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_QuantityDispositioned")]
    protected Environment _QuantityDispositioned;
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, false, "Integer", 1051356, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_Stage")]
    protected Environment _Stage;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_Activity")]
    [Metadata("This activity is used to disposition material reported in the quality system.", "ActivityDisposition", false, false, false, "NamedSubentityRef", 1050968, false, false, false, null)]
    protected Environment _Activity;
    [Metadata("Disposition Data", "DispositionData", false, false, false, "SubentityRef", 1051588, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_DispositionData")]
    protected Environment _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_Disposition")]
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, false, "NamedObjectRef", 1051582, false, false, false, null)]
    protected Environment _Disposition;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052020, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_ReconcileQuantity")]
    protected Environment _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_CompletionDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051796, false, false, false, null)]
    protected Environment _CompletionDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_DueDate")]
    protected Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_ParentName")]
    [Metadata("Generic String", "", false, false, false, "String", 1048825, false, false, false, null)]
    protected Environment _ParentName;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Environment_Comments")]
    protected Environment _Comments;

    public EventFailure_Environment EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (EventFailure_Environment) this.PropertyGet(nameof (EventFailures));
      }
    }

    public Environment QuantityAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAssigned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityAssigned));
      }
    }

    public Environment QuantityConforming
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityConforming), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityConforming));
      }
    }

    public Environment QuantityDispositioned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityDispositioned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityDispositioned));
      }
    }

    public Environment Stage
    {
      [param: In] set
      {
        this.PropertySet(nameof (Stage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Stage));
      }
    }

    public Environment Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Activity));
      }
    }

    public Environment DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispositionData));
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

    public Environment CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionDate));
      }
    }

    public Environment DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDate));
      }
    }

    public Environment ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentName));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
