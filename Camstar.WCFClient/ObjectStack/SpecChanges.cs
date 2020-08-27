// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecChanges
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
  public class SpecChanges : BusinessProcessSpecChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_ElectronicProcedure")]
    protected RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_SchedulingDetail")]
    protected SpecSchedulingDetailChanges _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_TxnMapItem")]
    protected TxnMapChanges _TxnMapItem;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_BillOfProcessAssignments")]
    protected BillOfProcess[] _BillOfProcessAssignments;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_LabelTxnMap")]
    protected ContainerLabelMapChanges[] _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_TxnMap")]
    protected TxnMapChanges[] _TxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_ESigTxnMap")]
    protected ContainerESigTxnMapChanges[] _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_EndTimerTxnMap")]
    protected EndTimerTxnMapChanges[] _EndTimerTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_StartTimerTxnMap")]
    protected StartTimerTxnMapChanges[] _StartTimerTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_ValidateLotSamplingComplete")]
    protected Primitive<bool> _ValidateLotSamplingComplete;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_AllowOverrides")]
    protected Primitive<bool> _AllowOverrides;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_AllowReworkTo")]
    protected Primitive<bool> _AllowReworkTo;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_ValidateMaterialConsumption")]
    protected Primitive<bool> _ValidateMaterialConsumption;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Setup")]
    protected RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_MaxQueueTime")]
    protected Primitive<double> _MaxQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_WarningQueueTime")]
    protected Primitive<double> _WarningQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_RecipeFile")]
    protected RevisionedObjectRef _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_MaxQueueTimeAction")]
    protected Primitive<int> _MaxQueueTimeAction;
    [DataMember(EmitDefaultValue = false, Name = "SpecChanges_Operation")]
    protected NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is SpecChanges && object.Equals((object) this._ResourceGroup, (object) ((SpecChanges) obj)._ResourceGroup) && (object.Equals((object) this._ElectronicProcedure, (object) ((SpecChanges) obj)._ElectronicProcedure) && object.Equals((object) this._SchedulingDetail, (object) ((SpecChanges) obj)._SchedulingDetail)) && (object.Equals((object) this._TrainingReqGroup, (object) ((SpecChanges) obj)._TrainingReqGroup) && object.Equals((object) this._TxnMapItem, (object) ((SpecChanges) obj)._TxnMapItem) && (object.Equals((object) this._Base, (object) ((SpecChanges) obj)._Base) && this.CompareArrays((Array) this._BillOfProcessAssignments, (Array) ((SpecChanges) obj)._BillOfProcessAssignments))) && (this.CompareArrays((Array) this._LabelTxnMap, (Array) ((SpecChanges) obj)._LabelTxnMap) && this.CompareArrays((Array) this._TxnMap, (Array) ((SpecChanges) obj)._TxnMap) && (this.CompareArrays((Array) this._ESigTxnMap, (Array) ((SpecChanges) obj)._ESigTxnMap) && object.Equals((object) this._ObjectToChange, (object) ((SpecChanges) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._EndTimerTxnMap, (Array) ((SpecChanges) obj)._EndTimerTxnMap) && this.CompareArrays((Array) this._StartTimerTxnMap, (Array) ((SpecChanges) obj)._StartTimerTxnMap) && (object.Equals((object) this._ValidateLotSamplingComplete, (object) ((SpecChanges) obj)._ValidateLotSamplingComplete) && object.Equals((object) this._AllowOverrides, (object) ((SpecChanges) obj)._AllowOverrides)))) && (object.Equals((object) this._AllowReworkTo, (object) ((SpecChanges) obj)._AllowReworkTo) && object.Equals((object) this._ValidateMaterialConsumption, (object) ((SpecChanges) obj)._ValidateMaterialConsumption) && (object.Equals((object) this._Setup, (object) ((SpecChanges) obj)._Setup) && object.Equals((object) this._MaxQueueTime, (object) ((SpecChanges) obj)._MaxQueueTime)) && (object.Equals((object) this._WarningQueueTime, (object) ((SpecChanges) obj)._WarningQueueTime) && object.Equals((object) this._DocumentSet, (object) ((SpecChanges) obj)._DocumentSet) && (object.Equals((object) this._Name, (object) ((SpecChanges) obj)._Name) && object.Equals((object) this._RecipeFile, (object) ((SpecChanges) obj)._RecipeFile))) && (object.Equals((object) this._MaxQueueTimeAction, (object) ((SpecChanges) obj)._MaxQueueTimeAction) && object.Equals((object) this._Operation, (object) ((SpecChanges) obj)._Operation))) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public RevisionedObjectRef ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public SpecSchedulingDetailChanges SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SpecSchedulingDetailChanges) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public TxnMapChanges TxnMapItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMapItem), (object) value);
      }
      get
      {
        return (TxnMapChanges) this.PropertyGet(nameof (TxnMapItem));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public BillOfProcess[] BillOfProcessAssignments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcessAssignments), (object) value);
      }
      get
      {
        return (BillOfProcess[]) this.PropertyGet(nameof (BillOfProcessAssignments));
      }
    }

    public ContainerLabelMapChanges[] LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMapChanges[]) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public TxnMapChanges[] TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMapChanges[]) this.PropertyGet(nameof (TxnMap));
      }
    }

    public ContainerESigTxnMapChanges[] ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMapChanges[]) this.PropertyGet(nameof (ESigTxnMap));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public EndTimerTxnMapChanges[] EndTimerTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerTxnMap), (object) value);
      }
      get
      {
        return (EndTimerTxnMapChanges[]) this.PropertyGet(nameof (EndTimerTxnMap));
      }
    }

    public StartTimerTxnMapChanges[] StartTimerTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerTxnMap), (object) value);
      }
      get
      {
        return (StartTimerTxnMapChanges[]) this.PropertyGet(nameof (StartTimerTxnMap));
      }
    }

    public Primitive<bool> ValidateLotSamplingComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateLotSamplingComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ValidateLotSamplingComplete));
      }
    }

    public Primitive<bool> AllowOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverrides), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowOverrides));
      }
    }

    public Primitive<bool> AllowReworkTo
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReworkTo), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowReworkTo));
      }
    }

    public Primitive<bool> ValidateMaterialConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateMaterialConsumption), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ValidateMaterialConsumption));
      }
    }

    public RevisionedObjectRef Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Setup));
      }
    }

    public Primitive<double> MaxQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxQueueTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MaxQueueTime));
      }
    }

    public Primitive<double> WarningQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQueueTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (WarningQueueTime));
      }
    }

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public RevisionedObjectRef RecipeFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeFile), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RecipeFile));
      }
    }

    public Primitive<int> MaxQueueTimeAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxQueueTimeAction), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaxQueueTimeAction));
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
  }
}
