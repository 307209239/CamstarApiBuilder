// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetEntry_Info
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
  public class ApprovalSheetEntry_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_ApproverRole")]
    protected Info _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_PLMApprovalURL")]
    protected Info _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_DelegationTask")]
    protected Info _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_PLMApprovalCode")]
    protected Info _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_CompleteWithinUOM")]
    protected Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_LastDecision")]
    protected Info _LastDecision;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_SubstituteOption")]
    protected Info _SubstituteOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_EditOption")]
    protected Info _EditOption;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_ApprovalDecision")]
    protected Info _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_DecisionType")]
    protected Info _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_CompleteBy")]
    protected Info _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_FirstRoutedOnGMT")]
    protected Info _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_CompleteWithinQty")]
    protected Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_LastCompletedOn")]
    protected Info _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_LastCompletedOnGMT")]
    protected Info _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_FirstRoutedOn")]
    protected Info _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_SheetLevel")]
    protected Info _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_LastRoutedOn")]
    protected Info _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_LastRoutedOnGMT")]
    protected Info _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_EntryRequired")]
    protected Info _EntryRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_ObjectToApprove")]
    protected Info _ObjectToApprove;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_CompleteByGMT")]
    protected Info _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_CompleteWithin")]
    protected Info _CompleteWithin;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_AssignedApprover")]
    protected Info _AssignedApprover;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_ApprovedBy")]
    protected Info _ApprovedBy;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetEntry_Info_Approver")]
    protected Info _Approver;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public Info Comments
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

    public Info LastDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDecision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDecision));
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

    public Info DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecisionType));
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

    public Info FirstRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FirstRoutedOnGMT));
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

    public Info LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Info LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedOnGMT));
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

    public Info LastRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRoutedOn));
      }
    }

    public Info LastRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRoutedOnGMT));
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

    public Info ObjectToApprove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToApprove), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToApprove));
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

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
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

    public Info ApprovedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovedBy));
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
  }
}
