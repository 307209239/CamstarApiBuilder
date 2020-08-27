// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalEntryDetails_Info
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
  public class ApprovalEntryDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_PLMApprovalURL")]
    protected Info _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_ApprovalComments")]
    protected Info _ApprovalComments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_ApproverRole")]
    protected Info _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_ApprovalDecision")]
    protected Info _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_EditOption")]
    protected Info _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_SubstituteOption")]
    protected Info _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_ApprovalEntry")]
    protected Info _ApprovalEntry;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_CompleteWithinUOM")]
    protected Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_DelegationTask")]
    protected Info _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_PLMApprovalCode")]
    protected Info _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_ApprovalDate")]
    protected Info _ApprovalDate;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_CompleteWithinQty")]
    protected Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_CompleteBy")]
    protected Info _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_FirstRoutedOn")]
    protected Info _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_EntryRequired")]
    protected Info _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_SheetLevel")]
    protected Info _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_Approver")]
    protected Info _Approver;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalEntryDetails_Info_AssignedApprover")]
    protected Info _AssignedApprover;

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

    public Info PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public Info ApprovalComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalComments));
      }
    }

    public Info ApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApproverRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApproverRole));
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

    public Info ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public Info EditOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (EditOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EditOption));
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

    public Info ApprovalEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalEntry));
      }
    }

    public Info CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinUOM));
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

    public Info PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public Info ApprovalDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalDate));
      }
    }

    public Info CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public Info CompleteBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteBy));
      }
    }

    public Info FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FirstRoutedOn));
      }
    }

    public Info EntryRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EntryRequired));
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

    public Info Approver
    {
      [param: In] set
      {
        this.PropertySet(nameof (Approver), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Approver));
      }
    }

    public Info AssignedApprover
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedApprover), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignedApprover));
      }
    }
  }
}
