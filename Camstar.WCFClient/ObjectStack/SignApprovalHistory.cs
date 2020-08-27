// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SignApprovalHistory
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
  public class SignApprovalHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ApproverRole")]
    protected NamedObjectRef _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_DecisionType")]
    protected Enumeration<DecisionTypeEnum, int> _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ApprovalSheetEntry")]
    protected SubentityRef _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ApprovalDecision")]
    protected NamedSubentityRef _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ProcessObject")]
    protected NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_LastRoutedOnGMT")]
    protected Primitive<DateTime> _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_SheetLevel")]
    protected Primitive<int> _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_CompleteBy")]
    protected Primitive<DateTime> _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_CompleteByGMT")]
    protected Primitive<DateTime> _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_LastCompletedOnGMT")]
    protected Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_LastRoutedOn")]
    protected Primitive<DateTime> _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_LastCompletedOn")]
    protected Primitive<DateTime> _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ApprovalCycleGMT")]
    protected Primitive<DateTime> _ApprovalCycleGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_TrackableObject")]
    protected BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ApprovalCycle")]
    protected Primitive<DateTime> _ApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_ApprovedBy")]
    protected NamedObjectRef _ApprovedBy;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Approver")]
    protected NamedObjectRef _Approver;

    public override bool Equals(object obj)
    {
      return obj is SignApprovalHistory && object.Equals((object) this._QualityObject, (object) ((SignApprovalHistory) obj)._QualityObject) && (object.Equals((object) this._ExportImportKey, (object) ((SignApprovalHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((SignApprovalHistory) obj)._HistoryDetails)) && (object.Equals((object) this._SpecialInstructions, (object) ((SignApprovalHistory) obj)._SpecialInstructions) && object.Equals((object) this._Comments, (object) ((SignApprovalHistory) obj)._Comments) && (object.Equals((object) this._ApproverRole, (object) ((SignApprovalHistory) obj)._ApproverRole) && object.Equals((object) this._DecisionType, (object) ((SignApprovalHistory) obj)._DecisionType))) && (object.Equals((object) this._ApprovalSheetEntry, (object) ((SignApprovalHistory) obj)._ApprovalSheetEntry) && object.Equals((object) this._ApprovalDecision, (object) ((SignApprovalHistory) obj)._ApprovalDecision) && (object.Equals((object) this._ProcessObject, (object) ((SignApprovalHistory) obj)._ProcessObject) && object.Equals((object) this._ApprovalSheet, (object) ((SignApprovalHistory) obj)._ApprovalSheet)) && (object.Equals((object) this._LastRoutedOnGMT, (object) ((SignApprovalHistory) obj)._LastRoutedOnGMT) && object.Equals((object) this._SheetLevel, (object) ((SignApprovalHistory) obj)._SheetLevel) && (object.Equals((object) this._CompleteBy, (object) ((SignApprovalHistory) obj)._CompleteBy) && object.Equals((object) this._CompleteByGMT, (object) ((SignApprovalHistory) obj)._CompleteByGMT)))) && (object.Equals((object) this._LastCompletedOnGMT, (object) ((SignApprovalHistory) obj)._LastCompletedOnGMT) && object.Equals((object) this._LastRoutedOn, (object) ((SignApprovalHistory) obj)._LastRoutedOn) && (object.Equals((object) this._LastCompletedOn, (object) ((SignApprovalHistory) obj)._LastCompletedOn) && object.Equals((object) this._ApprovalCycleGMT, (object) ((SignApprovalHistory) obj)._ApprovalCycleGMT)) && (object.Equals((object) this._HistoryId, (object) ((SignApprovalHistory) obj)._HistoryId) && object.Equals((object) this._TrackableObject, (object) ((SignApprovalHistory) obj)._TrackableObject) && (object.Equals((object) this._ApprovalCycle, (object) ((SignApprovalHistory) obj)._ApprovalCycle) && object.Equals((object) this._ApprovedBy, (object) ((SignApprovalHistory) obj)._ApprovedBy))) && object.Equals((object) this._Approver, (object) ((SignApprovalHistory) obj)._Approver)) && base.Equals(obj);
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
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

    public Primitive<string> SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Primitive<string> Comments
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

    public NamedObjectRef ApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApproverRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApproverRole));
      }
    }

    public Enumeration<DecisionTypeEnum, int> DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Enumeration<DecisionTypeEnum, int>) this.PropertyGet(nameof (DecisionType));
      }
    }

    public SubentityRef ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalSheetEntry));
      }
    }

    public NamedSubentityRef ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public Primitive<DateTime> LastRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastRoutedOnGMT));
      }
    }

    public Primitive<int> SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Primitive<DateTime> CompleteBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteBy), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompleteBy));
      }
    }

    public Primitive<DateTime> CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public Primitive<DateTime> LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletedOnGMT));
      }
    }

    public Primitive<DateTime> LastRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastRoutedOn));
      }
    }

    public Primitive<DateTime> LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Primitive<DateTime> ApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ApprovalCycleGMT));
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

    public BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Primitive<DateTime> ApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycle), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ApprovalCycle));
      }
    }

    public NamedObjectRef ApprovedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovedBy));
      }
    }

    public NamedObjectRef Approver
    {
      [param: In] set
      {
        this.PropertySet(nameof (Approver), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Approver));
      }
    }
  }
}
