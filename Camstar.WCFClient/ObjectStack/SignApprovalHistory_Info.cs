// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SignApprovalHistory_Info
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
  public class SignApprovalHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ApproverRole")]
    protected Info _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_DecisionType")]
    protected Info _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ApprovalSheetEntry")]
    protected Info _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ApprovalDecision")]
    protected Info _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ProcessObject")]
    protected Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_LastRoutedOnGMT")]
    protected Info _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_SheetLevel")]
    protected Info _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_CompleteBy")]
    protected Info _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_CompleteByGMT")]
    protected Info _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_LastCompletedOnGMT")]
    protected Info _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_LastRoutedOn")]
    protected Info _LastRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_LastCompletedOn")]
    protected Info _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ApprovalCycleGMT")]
    protected Info _ApprovalCycleGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_TrackableObject")]
    protected Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ApprovalCycle")]
    protected Info _ApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_ApprovedBy")]
    protected Info _ApprovedBy;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Info_Approver")]
    protected Info _Approver;

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

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

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetEntry));
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

    public Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Info ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheet));
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

    public Info ApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalCycleGMT));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Info ApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycle), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalCycle));
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
