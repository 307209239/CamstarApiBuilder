// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionSummary
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
  public class DispositionSummary : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_EventFailures")]
    protected EventFailure[] _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_QuantityAssigned")]
    protected Primitive<string> _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_QuantityConforming")]
    protected Primitive<string> _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_QuantityDispositioned")]
    protected Primitive<string> _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Stage")]
    protected Enumeration<StageEnum, int> _Stage;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Activity")]
    protected NamedSubentityRef _Activity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_DispositionData")]
    protected SubentityRef _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_ReconcileQuantity")]
    protected Primitive<bool> _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_CompletionDate")]
    protected Primitive<DateTime> _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_ParentName")]
    protected Primitive<string> _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Comments")]
    protected Primitive<string> _Comments;

    public override bool Equals(object obj)
    {
      return obj is DispositionSummary && this.CompareArrays((Array) this._EventFailures, (Array) ((DispositionSummary) obj)._EventFailures) && (object.Equals((object) this._QuantityAssigned, (object) ((DispositionSummary) obj)._QuantityAssigned) && object.Equals((object) this._QuantityConforming, (object) ((DispositionSummary) obj)._QuantityConforming)) && (object.Equals((object) this._QuantityDispositioned, (object) ((DispositionSummary) obj)._QuantityDispositioned) && object.Equals((object) this._Stage, (object) ((DispositionSummary) obj)._Stage) && (object.Equals((object) this._Activity, (object) ((DispositionSummary) obj)._Activity) && object.Equals((object) this._DispositionData, (object) ((DispositionSummary) obj)._DispositionData))) && (object.Equals((object) this._Disposition, (object) ((DispositionSummary) obj)._Disposition) && object.Equals((object) this._ReconcileQuantity, (object) ((DispositionSummary) obj)._ReconcileQuantity) && (object.Equals((object) this._CompletionDate, (object) ((DispositionSummary) obj)._CompletionDate) && object.Equals((object) this._DueDate, (object) ((DispositionSummary) obj)._DueDate)) && (object.Equals((object) this._ParentName, (object) ((DispositionSummary) obj)._ParentName) && object.Equals((object) this._Comments, (object) ((DispositionSummary) obj)._Comments))) && base.Equals(obj);
    }

    public EventFailure[] EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (EventFailure[]) this.PropertyGet(nameof (EventFailures));
      }
    }

    public Primitive<string> QuantityAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAssigned), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityAssigned));
      }
    }

    public Primitive<string> QuantityConforming
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityConforming), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityConforming));
      }
    }

    public Primitive<string> QuantityDispositioned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityDispositioned), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityDispositioned));
      }
    }

    public Enumeration<StageEnum, int> Stage
    {
      [param: In] set
      {
        this.PropertySet(nameof (Stage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (Stage));
      }
    }

    public NamedSubentityRef Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Activity));
      }
    }

    public SubentityRef DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DispositionData));
      }
    }

    public NamedObjectRef Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Disposition));
      }
    }

    public Primitive<bool> ReconcileQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReconcileQuantity), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ReconcileQuantity));
      }
    }

    public Primitive<DateTime> CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionDate));
      }
    }

    public Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public Primitive<string> ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentName));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
