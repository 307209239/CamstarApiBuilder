// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerTxn
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
  public class ContainerTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_CalledByTransactionTask")]
    protected new NamedSubentityRef _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_DispatchRule")]
    protected new NamedObjectRef _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_CurrentContainerStatus")]
    protected CurrentContainerStatus _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_WIPMsgMgr")]
    protected new WIPMsgMgr _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_MfgCalendar")]
    protected new NamedObjectRef _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_ESigRequirement")]
    protected new NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_ESigProcessTimerDetails")]
    protected ESigProcessTimerServiceDetail[] _ESigProcessTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_CollectDataPoints")]
    protected CollectDataPoints _CollectDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_ProcessTimerHistoryDetail")]
    protected SubentityRef _ProcessTimerHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_SamplingPlan")]
    protected new RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_UseQueue")]
    protected Primitive<bool> _UseQueue;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_IsRemoteService")]
    protected new Primitive<bool> _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_IsConfirmation")]
    protected Primitive<bool> _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_UseMfgNCR")]
    protected Primitive<bool> _UseMfgNCR;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_TaskContainer")]
    protected new ContainerRef _TaskContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxn_WorkCenter")]
    protected NamedObjectRef _WorkCenter;

    public override bool Equals(object obj)
    {
      return obj is ContainerTxn && object.Equals((object) this._CalledByTransactionTask, (object) ((ContainerTxn) obj)._CalledByTransactionTask) && (object.Equals((object) this._PrintQueue, (object) ((ContainerTxn) obj)._PrintQueue) && object.Equals((object) this._DispatchRule, (object) ((ContainerTxn) obj)._DispatchRule)) && (object.Equals((object) this._Comments, (object) ((ContainerTxn) obj)._Comments) && object.Equals((object) this._CurrentContainerStatus, (object) ((ContainerTxn) obj)._CurrentContainerStatus) && (object.Equals((object) this._WIPMsgMgr, (object) ((ContainerTxn) obj)._WIPMsgMgr) && object.Equals((object) this._MfgCalendar, (object) ((ContainerTxn) obj)._MfgCalendar))) && (object.Equals((object) this._DataCollectionDef, (object) ((ContainerTxn) obj)._DataCollectionDef) && object.Equals((object) this._ESigRequirement, (object) ((ContainerTxn) obj)._ESigRequirement) && (object.Equals((object) this._MfgProcessOverrides, (object) ((ContainerTxn) obj)._MfgProcessOverrides) && this.CompareArrays((Array) this._ESigProcessTimerDetails, (Array) ((ContainerTxn) obj)._ESigProcessTimerDetails)) && (object.Equals((object) this._Carrier, (object) ((ContainerTxn) obj)._Carrier) && object.Equals((object) this._CollectDataPoints, (object) ((ContainerTxn) obj)._CollectDataPoints) && (object.Equals((object) this._ProcessTimerHistoryDetail, (object) ((ContainerTxn) obj)._ProcessTimerHistoryDetail) && object.Equals((object) this._SamplingPlan, (object) ((ContainerTxn) obj)._SamplingPlan)))) && (object.Equals((object) this._ProcessESignatures, (object) ((ContainerTxn) obj)._ProcessESignatures) && object.Equals((object) this._UseQueue, (object) ((ContainerTxn) obj)._UseQueue) && (object.Equals((object) this._IsRemoteService, (object) ((ContainerTxn) obj)._IsRemoteService) && object.Equals((object) this._IsConfirmation, (object) ((ContainerTxn) obj)._IsConfirmation)) && (object.Equals((object) this._UseMfgNCR, (object) ((ContainerTxn) obj)._UseMfgNCR) && object.Equals((object) this._TaskContainer, (object) ((ContainerTxn) obj)._TaskContainer) && (object.Equals((object) this._UseDispatch, (object) ((ContainerTxn) obj)._UseDispatch) && object.Equals((object) this._Container, (object) ((ContainerTxn) obj)._Container))) && (object.Equals((object) this._Factory, (object) ((ContainerTxn) obj)._Factory) && object.Equals((object) this._Operation, (object) ((ContainerTxn) obj)._Operation) && (object.Equals((object) this._MfgOrder, (object) ((ContainerTxn) obj)._MfgOrder) && object.Equals((object) this._WorkCenter, (object) ((ContainerTxn) obj)._WorkCenter)))) && base.Equals(obj);
    }

    public new NamedSubentityRef CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public new NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public new NamedObjectRef DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public new Primitive<string> Comments
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

    public CurrentContainerStatus CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public new WIPMsgMgr WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public new NamedObjectRef MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public new RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new RevisionedObjectRef MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public ESigProcessTimerServiceDetail[] ESigProcessTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigProcessTimerDetails), (object) value);
      }
      get
      {
        return (ESigProcessTimerServiceDetail[]) this.PropertyGet(nameof (ESigProcessTimerDetails));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public CollectDataPoints CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public SubentityRef ProcessTimerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ProcessTimerHistoryDetail));
      }
    }

    public new RevisionedObjectRef SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Primitive<bool> UseQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseQueue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseQueue));
      }
    }

    public new Primitive<bool> IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Primitive<bool> IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsConfirmation));
      }
    }

    public Primitive<bool> UseMfgNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMfgNCR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseMfgNCR));
      }
    }

    public new ContainerRef TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public new Primitive<bool> UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public new NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public new NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public NamedObjectRef WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCenter));
      }
    }
  }
}
