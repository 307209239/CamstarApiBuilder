// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionSummary_Info
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
  public class DispositionSummary_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_EventFailures")]
    protected EventFailure_Info _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_QuantityAssigned")]
    protected Info _QuantityAssigned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_QuantityConforming")]
    protected Info _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_QuantityDispositioned")]
    protected Info _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_Stage")]
    protected Info _Stage;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_Activity")]
    protected Info _Activity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_DispositionData")]
    protected Info _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_Disposition")]
    protected Info _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_ReconcileQuantity")]
    protected Info _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_CompletionDate")]
    protected Info _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_ParentName")]
    protected Info _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionSummary_Info_Comments")]
    protected Info _Comments;

    public EventFailure_Info EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (EventFailure_Info) this.PropertyGet(nameof (EventFailures));
      }
    }

    public Info QuantityAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAssigned), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityAssigned));
      }
    }

    public Info QuantityConforming
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityConforming), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityConforming));
      }
    }

    public Info QuantityDispositioned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityDispositioned), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityDispositioned));
      }
    }

    public Info Stage
    {
      [param: In] set
      {
        this.PropertySet(nameof (Stage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Stage));
      }
    }

    public Info Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Activity));
      }
    }

    public Info DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispositionData));
      }
    }

    public Info Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Disposition));
      }
    }

    public Info ReconcileQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReconcileQuantity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReconcileQuantity));
      }
    }

    public Info CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionDate));
      }
    }

    public Info DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDate));
      }
    }

    public Info ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentName));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
