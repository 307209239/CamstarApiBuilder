// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorEntryDetails_Info
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
  public class CollaboratorEntryDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_CollaboratorComments")]
    protected Info _CollaboratorComments;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_CollaboratorEntry")]
    protected Info _CollaboratorEntry;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_DurationUOM")]
    protected Info _DurationUOM;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_SubstituteOption")]
    protected Info _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_DelegationTask")]
    protected Info _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_SheetLevel")]
    protected Info _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_IsAbleToComplete")]
    protected Info _IsAbleToComplete;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_IsDefaultToComplete")]
    protected Info _IsDefaultToComplete;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_DueDateGMT")]
    protected Info _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_AssignedDateGMT")]
    protected Info _AssignedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_CompletionDateGMT")]
    protected Info _CompletionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_CompleteByGMT")]
    protected Info _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_CompleteWithin")]
    protected Info _CompleteWithin;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_CompletedBy")]
    protected Info _CompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_Duration")]
    protected Info _Duration;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_AssignedCollaborator")]
    protected Info _AssignedCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorEntryDetails_Info_Collaborator")]
    protected Info _Collaborator;

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Info CollaboratorComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaboratorComments));
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

    public Info CollaboratorEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaboratorEntry));
      }
    }

    public Info DurationUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (DurationUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DurationUOM));
      }
    }

    public Info SubstituteOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstituteOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubstituteOption));
      }
    }

    public Info DelegationTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationTask));
      }
    }

    public Info SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Info IsAbleToComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAbleToComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsAbleToComplete));
      }
    }

    public Info IsDefaultToComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefaultToComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsDefaultToComplete));
      }
    }

    public Info DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Info AssignedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignedDateGMT));
      }
    }

    public Info CompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionDateGMT));
      }
    }

    public Info CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public Info CompleteWithin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithin), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithin));
      }
    }

    public Info CompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletedBy));
      }
    }

    public Info Duration
    {
      [param: In] set
      {
        this.PropertySet(nameof (Duration), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Duration));
      }
    }

    public Info AssignedCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedCollaborator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignedCollaborator));
      }
    }

    public Info Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Collaborator));
      }
    }
  }
}
