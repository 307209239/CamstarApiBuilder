// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkCenterChanges_Info
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
  public class WorkCenterChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_MfgCalendar")]
    protected Info _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_Image")]
    protected Info _Image;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_DispatchRule")]
    protected Info _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_FastQueueTime")]
    protected Info _FastQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_NormalQueueTime")]
    protected Info _NormalQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_DispatchMethod")]
    protected Info _DispatchMethod;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Info_WorkSchedule")]
    protected Info _WorkSchedule;

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Info MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public Info Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Image));
      }
    }

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Info DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info FastQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastQueueTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FastQueueTime));
      }
    }

    public Info NormalQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalQueueTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NormalQueueTime));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info DispatchMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchMethod), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispatchMethod));
      }
    }

    public Info WorkSchedule
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkSchedule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkSchedule));
      }
    }
  }
}
