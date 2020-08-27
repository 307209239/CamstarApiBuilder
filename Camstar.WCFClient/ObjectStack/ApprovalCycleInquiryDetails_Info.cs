// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails_Info
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
  public class ApprovalCycleInquiryDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_PLMApprovalURL")]
    protected Info _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_ApproverRole")]
    protected Info _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_PLMApprovalCode")]
    protected Info _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_DecisionType")]
    protected Info _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_LastRoutedOnGMT")]
    protected Info _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_LastCompletedOnGMT")]
    protected Info _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_SheetLevel")]
    protected Info _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_CompleteByGMT")]
    protected Info _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_DecisionTypeName")]
    protected Info _DecisionTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_Approver")]
    protected Info _Approver;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Info_ApprovedBy")]
    protected Info _ApprovedBy;

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

    public Info DecisionTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecisionTypeName));
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
  }
}
