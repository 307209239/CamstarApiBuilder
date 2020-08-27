// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalEntryDetails
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
  public class ApprovalEntryDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_PLMApprovalURL")]
    protected Primitive<string> _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_ApprovalComments")]
    protected Primitive<string> _ApprovalComments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_ApproverRole")]
    protected NamedObjectRef _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Status")]
    protected Enumeration<ApprovalStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_ApprovalDecision")]
    protected NamedSubentityRef _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_EditOption")]
    protected Enumeration<ApprovalEditOptionEnum, int> _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_SubstituteOption")]
    protected Enumeration<ApprovalSubstituteOptionEnum, int> _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_ApprovalEntry")]
    protected SubentityRef _ApprovalEntry;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_CompleteWithinUOM")]
    protected Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_DelegationTask")]
    protected SubentityRef _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_PLMApprovalCode")]
    protected Primitive<string> _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_ApprovalDate")]
    protected Primitive<DateTime> _ApprovalDate;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_CompleteWithinQty")]
    protected Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_CompleteBy")]
    protected Primitive<DateTime> _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_FirstRoutedOn")]
    protected Primitive<DateTime> _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_EntryRequired")]
    protected Primitive<bool> _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_SheetLevel")]
    protected Primitive<int> _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Approver")]
    protected NamedObjectRef _Approver;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_AssignedApprover")]
    protected NamedObjectRef _AssignedApprover;

    public override bool Equals(object obj)
    {
      return obj is ApprovalEntryDetails && object.Equals((object) this._SpecialInstructions, (object) ((ApprovalEntryDetails) obj)._SpecialInstructions) && (object.Equals((object) this._PLMApprovalURL, (object) ((ApprovalEntryDetails) obj)._PLMApprovalURL) && object.Equals((object) this._ApprovalComments, (object) ((ApprovalEntryDetails) obj)._ApprovalComments)) && (object.Equals((object) this._ApproverRole, (object) ((ApprovalEntryDetails) obj)._ApproverRole) && object.Equals((object) this._Status, (object) ((ApprovalEntryDetails) obj)._Status) && (object.Equals((object) this._ApprovalDecision, (object) ((ApprovalEntryDetails) obj)._ApprovalDecision) && object.Equals((object) this._EditOption, (object) ((ApprovalEntryDetails) obj)._EditOption))) && (object.Equals((object) this._SubstituteOption, (object) ((ApprovalEntryDetails) obj)._SubstituteOption) && object.Equals((object) this._ApprovalEntry, (object) ((ApprovalEntryDetails) obj)._ApprovalEntry) && (object.Equals((object) this._CompleteWithinUOM, (object) ((ApprovalEntryDetails) obj)._CompleteWithinUOM) && object.Equals((object) this._DelegationTask, (object) ((ApprovalEntryDetails) obj)._DelegationTask)) && (object.Equals((object) this._PLMApprovalCode, (object) ((ApprovalEntryDetails) obj)._PLMApprovalCode) && object.Equals((object) this._ApprovalDate, (object) ((ApprovalEntryDetails) obj)._ApprovalDate) && (object.Equals((object) this._CompleteWithinQty, (object) ((ApprovalEntryDetails) obj)._CompleteWithinQty) && object.Equals((object) this._CompleteBy, (object) ((ApprovalEntryDetails) obj)._CompleteBy)))) && (object.Equals((object) this._FirstRoutedOn, (object) ((ApprovalEntryDetails) obj)._FirstRoutedOn) && object.Equals((object) this._EntryRequired, (object) ((ApprovalEntryDetails) obj)._EntryRequired) && (object.Equals((object) this._SheetLevel, (object) ((ApprovalEntryDetails) obj)._SheetLevel) && object.Equals((object) this._Approver, (object) ((ApprovalEntryDetails) obj)._Approver)) && object.Equals((object) this._AssignedApprover, (object) ((ApprovalEntryDetails) obj)._AssignedApprover)) && base.Equals(obj);
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

    public Primitive<string> ApprovalComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ApprovalComments));
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

    public SubentityRef ApprovalEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntry), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalEntry));
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

    public Primitive<DateTime> ApprovalDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ApprovalDate));
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
  }
}
