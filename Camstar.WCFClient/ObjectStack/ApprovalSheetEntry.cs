// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetEntry
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
  public class ApprovalSheetEntry : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_ApproverRole")]
    protected NamedObjectRef _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_PLMApprovalURL")]
    protected Primitive<string> _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_DelegationTask")]
    protected SubentityRef _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_PLMApprovalCode")]
    protected Primitive<string> _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_CompleteWithinUOM")]
    protected Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_LastDecision")]
    protected SubentityRef _LastDecision;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_SubstituteOption")]
    protected Enumeration<ApprovalSubstituteOptionEnum, int> _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_EditOption")]
    protected Enumeration<ApprovalEditOptionEnum, int> _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_ApprovalDecision")]
    protected NamedSubentityRef _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_DecisionType")]
    protected Enumeration<DecisionTypeEnum, int> _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Status")]
    protected Enumeration<ApprovalStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_CompleteBy")]
    protected Primitive<DateTime> _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_FirstRoutedOnGMT")]
    protected Primitive<DateTime> _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_CompleteWithinQty")]
    protected Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_LastCompletedOn")]
    protected Primitive<DateTime> _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_LastCompletedOnGMT")]
    protected Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_FirstRoutedOn")]
    protected Primitive<DateTime> _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_SheetLevel")]
    protected Primitive<int> _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_LastRoutedOn")]
    protected Primitive<DateTime> _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_LastRoutedOnGMT")]
    protected Primitive<DateTime> _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_EntryRequired")]
    protected Primitive<bool> _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_ObjectToApprove")]
    protected BaseObjectRef _ObjectToApprove;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_CompleteByGMT")]
    protected Primitive<DateTime> _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_CompleteWithin")]
    protected Primitive<double> _CompleteWithin;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_AssignedApprover")]
    protected NamedObjectRef _AssignedApprover;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_ApprovedBy")]
    protected NamedObjectRef _ApprovedBy;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Approver")]
    protected NamedObjectRef _Approver;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheetEntry && object.Equals((object) this._ExportImportKey, (object) ((ApprovalSheetEntry) obj)._ExportImportKey) && (object.Equals((object) this._SpecialInstructions, (object) ((ApprovalSheetEntry) obj)._SpecialInstructions) && object.Equals((object) this._ApproverRole, (object) ((ApprovalSheetEntry) obj)._ApproverRole)) && (object.Equals((object) this._Comments, (object) ((ApprovalSheetEntry) obj)._Comments) && object.Equals((object) this._PLMApprovalURL, (object) ((ApprovalSheetEntry) obj)._PLMApprovalURL) && (object.Equals((object) this._DelegationTask, (object) ((ApprovalSheetEntry) obj)._DelegationTask) && object.Equals((object) this._PLMApprovalCode, (object) ((ApprovalSheetEntry) obj)._PLMApprovalCode))) && (object.Equals((object) this._CompleteWithinUOM, (object) ((ApprovalSheetEntry) obj)._CompleteWithinUOM) && object.Equals((object) this._LastDecision, (object) ((ApprovalSheetEntry) obj)._LastDecision) && (object.Equals((object) this._SubstituteOption, (object) ((ApprovalSheetEntry) obj)._SubstituteOption) && object.Equals((object) this._EditOption, (object) ((ApprovalSheetEntry) obj)._EditOption)) && (object.Equals((object) this._ApprovalDecision, (object) ((ApprovalSheetEntry) obj)._ApprovalDecision) && object.Equals((object) this._DecisionType, (object) ((ApprovalSheetEntry) obj)._DecisionType) && (object.Equals((object) this._Status, (object) ((ApprovalSheetEntry) obj)._Status) && object.Equals((object) this._CompleteBy, (object) ((ApprovalSheetEntry) obj)._CompleteBy)))) && (object.Equals((object) this._FirstRoutedOnGMT, (object) ((ApprovalSheetEntry) obj)._FirstRoutedOnGMT) && object.Equals((object) this._CompleteWithinQty, (object) ((ApprovalSheetEntry) obj)._CompleteWithinQty) && (object.Equals((object) this._LastCompletedOn, (object) ((ApprovalSheetEntry) obj)._LastCompletedOn) && object.Equals((object) this._LastCompletedOnGMT, (object) ((ApprovalSheetEntry) obj)._LastCompletedOnGMT)) && (object.Equals((object) this._FirstRoutedOn, (object) ((ApprovalSheetEntry) obj)._FirstRoutedOn) && object.Equals((object) this._SheetLevel, (object) ((ApprovalSheetEntry) obj)._SheetLevel) && (object.Equals((object) this._LastRoutedOn, (object) ((ApprovalSheetEntry) obj)._LastRoutedOn) && object.Equals((object) this._LastRoutedOnGMT, (object) ((ApprovalSheetEntry) obj)._LastRoutedOnGMT))) && (object.Equals((object) this._EntryRequired, (object) ((ApprovalSheetEntry) obj)._EntryRequired) && object.Equals((object) this._ObjectToApprove, (object) ((ApprovalSheetEntry) obj)._ObjectToApprove) && (object.Equals((object) this._CompleteByGMT, (object) ((ApprovalSheetEntry) obj)._CompleteByGMT) && object.Equals((object) this._IsFrozen, (object) ((ApprovalSheetEntry) obj)._IsFrozen)) && (object.Equals((object) this._CompleteWithin, (object) ((ApprovalSheetEntry) obj)._CompleteWithin) && object.Equals((object) this._AssignedApprover, (object) ((ApprovalSheetEntry) obj)._AssignedApprover) && (object.Equals((object) this._ApprovedBy, (object) ((ApprovalSheetEntry) obj)._ApprovedBy) && object.Equals((object) this._Approver, (object) ((ApprovalSheetEntry) obj)._Approver))))) && base.Equals(obj);
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

    public Primitive<string> PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public SubentityRef DelegationTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTask), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DelegationTask));
      }
    }

    public Primitive<string> PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public Enumeration<DurationUOMEnum, string> CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Enumeration<DurationUOMEnum, string>) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public SubentityRef LastDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDecision), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (LastDecision));
      }
    }

    public Enumeration<ApprovalSubstituteOptionEnum, int> SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalSubstituteOptionEnum, int>) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Enumeration<ApprovalEditOptionEnum, int> EditOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (EditOption), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalEditOptionEnum, int>) this.PropertyGet(nameof (EditOption));
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

    public Enumeration<ApprovalStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (Status));
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

    public Primitive<DateTime> FirstRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FirstRoutedOnGMT));
      }
    }

    public Primitive<int> CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CompleteWithinQty));
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

    public Primitive<DateTime> FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FirstRoutedOn));
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

    public Primitive<bool> EntryRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (EntryRequired));
      }
    }

    public BaseObjectRef ObjectToApprove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToApprove), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ObjectToApprove));
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

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Primitive<double> CompleteWithin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithin), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CompleteWithin));
      }
    }

    public NamedObjectRef AssignedApprover
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedApprover), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssignedApprover));
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
