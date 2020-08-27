// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackTargetDeploymentHistory_Info
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
  public class TrackTargetDeploymentHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_LastUpdatedDateGMT")]
    protected Info _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_ExportHeaderId")]
    protected Info _ExportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_ExportTargetId")]
    protected Info _ExportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_LastUpdatedDate")]
    protected Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeploymentHistory_Info_Message")]
    protected Info _Message;

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
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

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Info ExportHeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportHeaderId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportHeaderId));
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

    public Info ExportTargetId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportTargetId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportTargetId));
      }
    }

    public Info LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Info Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Message));
      }
    }
  }
}
