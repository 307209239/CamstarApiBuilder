// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDispositionHistoryDetail_Info
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
  public class EventDispositionHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Info_EventFailureHistoryDetails")]
    protected EventFailureHistoryDetail_Info _EventFailureHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Info_Disposition")]
    protected Info _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Info_Lot")]
    protected Info _Lot;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public EventFailureHistoryDetail_Info EventFailureHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureHistoryDetail_Info) this.PropertyGet(nameof (EventFailureHistoryDetails));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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

    public Info Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Lot));
      }
    }
  }
}
