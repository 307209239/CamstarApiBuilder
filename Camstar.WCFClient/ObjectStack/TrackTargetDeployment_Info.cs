// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackTargetDeployment_Info
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
  public class TrackTargetDeployment_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_ServiceDetails")]
    protected TargetDeploymentDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_TargetDeployments")]
    protected TargetDeploymentDetail_Info _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_ExportHeaderId")]
    protected Info _ExportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_ExportTargetId")]
    protected Info _ExportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_LastUpdatedDateGMT")]
    protected Info _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_LastUpdatedDate")]
    protected Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Info_Message")]
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

    public TargetDeploymentDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Info) this.PropertyGet(nameof (ServiceDetails));
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

    public TargetDeploymentDetail_Info TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail_Info) this.PropertyGet(nameof (TargetDeployments));
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
