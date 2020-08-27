// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDispositionDetail_Info
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
  public class EventDispositionDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Info_EventFailureDetails")]
    protected EventFailureDetail_Info _EventFailureDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Info_EventDisposition")]
    protected Info _EventDisposition;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Info_Disposition")]
    protected Info _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Info_ApplyEntireQty")]
    protected Info _ApplyEntireQty;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Info_Qty")]
    protected Info _Qty;

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

    public EventFailureDetail_Info EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail_Info) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public Info EventDisposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDisposition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventDisposition));
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

    public Info ApplyEntireQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyEntireQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApplyEntireQty));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
