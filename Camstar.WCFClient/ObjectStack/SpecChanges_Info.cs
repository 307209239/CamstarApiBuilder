// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecChanges_Info
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
  public class SpecChanges_Info : BusinessProcessSpecChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_ElectronicProcedure")]
    protected Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_SchedulingDetail")]
    protected SpecSchedulingDetailChanges_Info _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_TxnMapItem")]
    protected TxnMapChanges_Info _TxnMapItem;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_BillOfProcessAssignments")]
    protected BillOfProcess_Info _BillOfProcessAssignments;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_LabelTxnMap")]
    protected ContainerLabelMapChanges_Info _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_TxnMap")]
    protected TxnMapChanges_Info _TxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_ESigTxnMap")]
    protected ContainerESigTxnMapChanges_Info _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_EndTimerTxnMap")]
    protected EndTimerTxnMapChanges_Info _EndTimerTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_StartTimerTxnMap")]
    protected StartTimerTxnMapChanges_Info _StartTimerTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_ValidateLotSamplingComplete")]
    protected Info _ValidateLotSamplingComplete;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_AllowOverrides")]
    protected Info _AllowOverrides;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_AllowReworkTo")]
    protected Info _AllowReworkTo;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_ValidateMaterialConsumption")]
    protected Info _ValidateMaterialConsumption;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_Setup")]
    protected Info _Setup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_MaxQueueTime")]
    protected Info _MaxQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_WarningQueueTime")]
    protected Info _WarningQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_RecipeFile")]
    protected Info _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_MaxQueueTimeAction")]
    protected Info _MaxQueueTimeAction;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Info_Operation")]
    protected Info _Operation;

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

    public Info ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public SpecSchedulingDetailChanges_Info SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SpecSchedulingDetailChanges_Info) this.PropertyGet(nameof (SchedulingDetail));
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

    public TxnMapChanges_Info TxnMapItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMapItem), (object) value);
      }
      get
      {
        return (TxnMapChanges_Info) this.PropertyGet(nameof (TxnMapItem));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public BillOfProcess_Info BillOfProcessAssignments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcessAssignments), (object) value);
      }
      get
      {
        return (BillOfProcess_Info) this.PropertyGet(nameof (BillOfProcessAssignments));
      }
    }

    public ContainerLabelMapChanges_Info LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMapChanges_Info) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public TxnMapChanges_Info TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMapChanges_Info) this.PropertyGet(nameof (TxnMap));
      }
    }

    public ContainerESigTxnMapChanges_Info ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMapChanges_Info) this.PropertyGet(nameof (ESigTxnMap));
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

    public EndTimerTxnMapChanges_Info EndTimerTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerTxnMap), (object) value);
      }
      get
      {
        return (EndTimerTxnMapChanges_Info) this.PropertyGet(nameof (EndTimerTxnMap));
      }
    }

    public StartTimerTxnMapChanges_Info StartTimerTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerTxnMap), (object) value);
      }
      get
      {
        return (StartTimerTxnMapChanges_Info) this.PropertyGet(nameof (StartTimerTxnMap));
      }
    }

    public Info ValidateLotSamplingComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateLotSamplingComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidateLotSamplingComplete));
      }
    }

    public Info AllowOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverrides), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowOverrides));
      }
    }

    public Info AllowReworkTo
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReworkTo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowReworkTo));
      }
    }

    public Info ValidateMaterialConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateMaterialConsumption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidateMaterialConsumption));
      }
    }

    public Info Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Setup));
      }
    }

    public Info MaxQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxQueueTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxQueueTime));
      }
    }

    public Info WarningQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQueueTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WarningQueueTime));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
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

    public Info RecipeFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeFile));
      }
    }

    public Info MaxQueueTimeAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxQueueTimeAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxQueueTimeAction));
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
  }
}
