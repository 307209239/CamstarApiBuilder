// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackTargetDeploymentHistory
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
  public class TrackTargetDeploymentHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Owner")]
    protected Primitive<string> _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Status")]
    protected Enumeration<TargetDeliveryStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_LastUpdatedDateGMT")]
    protected Primitive<DateTime> _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_ExportHeaderId")]
    protected Primitive<int> _ExportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_ExportTargetId")]
    protected Primitive<int> _ExportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_LastUpdatedDate")]
    protected Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Message")]
    protected Primitive<string> _Message;

    public override bool Equals(object obj)
    {
      return obj is TrackTargetDeploymentHistory && object.Equals((object) this._Owner, (object) ((TrackTargetDeploymentHistory) obj)._Owner) && (object.Equals((object) this._ExportImportKey, (object) ((TrackTargetDeploymentHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((TrackTargetDeploymentHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Status, (object) ((TrackTargetDeploymentHistory) obj)._Status) && object.Equals((object) this._LastUpdatedDateGMT, (object) ((TrackTargetDeploymentHistory) obj)._LastUpdatedDateGMT) && (object.Equals((object) this._ExportHeaderId, (object) ((TrackTargetDeploymentHistory) obj)._ExportHeaderId) && object.Equals((object) this._HistoryId, (object) ((TrackTargetDeploymentHistory) obj)._HistoryId))) && (object.Equals((object) this._ExportTargetId, (object) ((TrackTargetDeploymentHistory) obj)._ExportTargetId) && object.Equals((object) this._LastUpdatedDate, (object) ((TrackTargetDeploymentHistory) obj)._LastUpdatedDate) && object.Equals((object) this._Message, (object) ((TrackTargetDeploymentHistory) obj)._Message)) && base.Equals(obj);
    }

    public Primitive<string> Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Owner));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Enumeration<TargetDeliveryStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<TargetDeliveryStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<DateTime> LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Primitive<int> ExportHeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportHeaderId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExportHeaderId));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> ExportTargetId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportTargetId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExportTargetId));
      }
    }

    public Primitive<DateTime> LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Primitive<string> Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Message));
      }
    }
  }
}
