// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerTxn_Info
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
  public class ContainerTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_CalledByTransactionTask")]
    protected new Info _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_DispatchRule")]
    protected new Info _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_CurrentContainerStatus")]
    protected CurrentContainerStatus_Info _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_WIPMsgMgr")]
    protected new WIPMsgMgr_Info _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_MfgCalendar")]
    protected new Info _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_ESigRequirement")]
    protected new Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_ESigProcessTimerDetails")]
    protected ESigProcessTimerServiceDetail_Info _ESigProcessTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_CollectDataPoints")]
    protected CollectDataPoints_Info _CollectDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_ProcessTimerHistoryDetail")]
    protected Info _ProcessTimerHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_SamplingPlan")]
    protected new Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_ProcessESignatures")]
    protected new Info _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_UseQueue")]
    protected Info _UseQueue;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_IsRemoteService")]
    protected new Info _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_IsConfirmation")]
    protected Info _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_UseMfgNCR")]
    protected Info _UseMfgNCR;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_TaskContainer")]
    protected new Info _TaskContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_MfgOrder")]
    protected new Info _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Info_WorkCenter")]
    protected Info _WorkCenter;

    public new Info CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public new Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public new Info DispatchRule
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

    public new Info Comments
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

    public CurrentContainerStatus_Info CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus_Info) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public new WIPMsgMgr_Info WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Info) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public new Info MfgCalendar
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

    public new Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Info MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public ESigProcessTimerServiceDetail_Info ESigProcessTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerDetails), (object) value);
      }
      get
      {
        return (ESigProcessTimerServiceDetail_Info) this.PropertyGet(nameof (ESigProcessTimerDetails));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public CollectDataPoints_Info CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints_Info) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public Info ProcessTimerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerHistoryDetail));
      }
    }

    public new Info SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public new Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Info UseQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseQueue));
      }
    }

    public new Info IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Info IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsConfirmation));
      }
    }

    public Info UseMfgNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMfgNCR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseMfgNCR));
      }
    }

    public new Info TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public new Info UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public new Info MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
      }
    }
  }
}
