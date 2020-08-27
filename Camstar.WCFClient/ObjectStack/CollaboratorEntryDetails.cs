// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorEntryDetails
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
  public class CollaboratorEntryDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_CollaboratorComments")]
    protected Primitive<string> _CollaboratorComments;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Status")]
    protected Enumeration<CollaborateStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_CollaboratorEntry")]
    protected SubentityRef _CollaboratorEntry;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_DurationUOM")]
    protected Enumeration<DurationUOMEnum, string> _DurationUOM;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_SubstituteOption")]
    protected Enumeration<ApprovalSubstituteOptionEnum, int> _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_DelegationTask")]
    protected SubentityRef _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_SheetLevel")]
    protected Primitive<int> _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_IsAbleToComplete")]
    protected Primitive<bool> _IsAbleToComplete;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_IsDefaultToComplete")]
    protected Primitive<bool> _IsDefaultToComplete;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_AssignedDateGMT")]
    protected Primitive<DateTime> _AssignedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_CompletionDateGMT")]
    protected Primitive<DateTime> _CompletionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_CompleteByGMT")]
    protected Primitive<DateTime> _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_CompleteWithin")]
    protected Primitive<double> _CompleteWithin;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_CompletedBy")]
    protected NamedObjectRef _CompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Duration")]
    protected Primitive<double> _Duration;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_AssignedCollaborator")]
    protected NamedObjectRef _AssignedCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Collaborator")]
    protected NamedObjectRef _Collaborator;

    public override bool Equals(object obj)
    {
      return obj is CollaboratorEntryDetails && object.Equals((object) this._Role, (object) ((CollaboratorEntryDetails) obj)._Role) && (object.Equals((object) this._SpecialInstructions, (object) ((CollaboratorEntryDetails) obj)._SpecialInstructions) && object.Equals((object) this._CollaboratorComments, (object) ((CollaboratorEntryDetails) obj)._CollaboratorComments)) && (object.Equals((object) this._Status, (object) ((CollaboratorEntryDetails) obj)._Status) && object.Equals((object) this._CollaboratorEntry, (object) ((CollaboratorEntryDetails) obj)._CollaboratorEntry) && (object.Equals((object) this._DurationUOM, (object) ((CollaboratorEntryDetails) obj)._DurationUOM) && object.Equals((object) this._SubstituteOption, (object) ((CollaboratorEntryDetails) obj)._SubstituteOption))) && (object.Equals((object) this._DelegationTask, (object) ((CollaboratorEntryDetails) obj)._DelegationTask) && object.Equals((object) this._SheetLevel, (object) ((CollaboratorEntryDetails) obj)._SheetLevel) && (object.Equals((object) this._IsAbleToComplete, (object) ((CollaboratorEntryDetails) obj)._IsAbleToComplete) && object.Equals((object) this._IsDefaultToComplete, (object) ((CollaboratorEntryDetails) obj)._IsDefaultToComplete)) && (object.Equals((object) this._DueDateGMT, (object) ((CollaboratorEntryDetails) obj)._DueDateGMT) && object.Equals((object) this._AssignedDateGMT, (object) ((CollaboratorEntryDetails) obj)._AssignedDateGMT) && (object.Equals((object) this._CompletionDateGMT, (object) ((CollaboratorEntryDetails) obj)._CompletionDateGMT) && object.Equals((object) this._CompleteByGMT, (object) ((CollaboratorEntryDetails) obj)._CompleteByGMT)))) && (object.Equals((object) this._CompleteWithin, (object) ((CollaboratorEntryDetails) obj)._CompleteWithin) && object.Equals((object) this._CompletedBy, (object) ((CollaboratorEntryDetails) obj)._CompletedBy) && (object.Equals((object) this._Duration, (object) ((CollaboratorEntryDetails) obj)._Duration) && object.Equals((object) this._AssignedCollaborator, (object) ((CollaboratorEntryDetails) obj)._AssignedCollaborator)) && object.Equals((object) this._Collaborator, (object) ((CollaboratorEntryDetails) obj)._Collaborator)) && base.Equals(obj);
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
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

    public Primitive<string> CollaboratorComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CollaboratorComments));
      }
    }

    public Enumeration<CollaborateStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<CollaborateStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public SubentityRef CollaboratorEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntry), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (CollaboratorEntry));
      }
    }

    public Enumeration<DurationUOMEnum, string> DurationUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationUOM), (object) value);
      }
      get
      {
        return (Enumeration<DurationUOMEnum, string>) this.PropertyGet(nameof (DurationUOM));
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

    public Primitive<bool> IsAbleToComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAbleToComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsAbleToComplete));
      }
    }

    public Primitive<bool> IsDefaultToComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefaultToComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsDefaultToComplete));
      }
    }

    public Primitive<DateTime> DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Primitive<DateTime> AssignedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (AssignedDateGMT));
      }
    }

    public Primitive<DateTime> CompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionDateGMT));
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

    public NamedObjectRef CompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CompletedBy));
      }
    }

    public Primitive<double> Duration
    {
      [param: In] set
      {
        this.PropertySet(nameof (Duration), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Duration));
      }
    }

    public NamedObjectRef AssignedCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedCollaborator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssignedCollaborator));
      }
    }

    public NamedObjectRef Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Collaborator));
      }
    }
  }
}
