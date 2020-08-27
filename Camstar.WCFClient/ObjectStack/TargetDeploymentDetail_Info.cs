// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetDeploymentDetail_Info
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
  public class TargetDeploymentDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_StatusName")]
    protected Info _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_TargetDeployment")]
    protected Info _TargetDeployment;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_TrackableObject")]
    protected Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_TargetSystem")]
    protected TargetSystem_Info _TargetSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_ExportTargetId")]
    protected Info _ExportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_ExportHeaderId")]
    protected Info _ExportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_LastUpdatedDate")]
    protected Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_LastUpdatedDateGMT")]
    protected Info _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_ExportDateGMT")]
    protected Info _ExportDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_ImportSequence")]
    protected Info _ImportSequence;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_ExportDate")]
    protected Info _ExportDate;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_Message")]
    protected Info _Message;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Info_TargetSystemName")]
    protected Info _TargetSystemName;

    public Info StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusName));
      }
    }

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

    public Info TargetDeployment
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetDeployment));
      }
    }

    public Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public TargetSystem_Info TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Info) this.PropertyGet(nameof (TargetSystem));
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

    public Info ExportDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportDateGMT));
      }
    }

    public Info ImportSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportSequence));
      }
    }

    public Info ExportDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportDate));
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

    public Info TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSystemName));
      }
    }
  }
}
