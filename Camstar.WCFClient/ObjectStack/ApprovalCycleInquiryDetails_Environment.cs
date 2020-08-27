// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails_Environment
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
  public class ApprovalCycleInquiryDetails_Environment : ServiceData_Environment
  {
    [Metadata("URL", "", false, false, false, "String", 16777612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_PLMApprovalURL")]
    protected Environment _PLMApprovalURL;
    [Metadata("Comments", "", false, false, true, "String", 1051983, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_SpecialInstructions")]
    protected Environment _SpecialInstructions;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_ApproverRole")]
    protected Environment _ApproverRole;
    [Metadata("Comments", "", false, false, true, "String", 1052011, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Brief Description", "", false, false, false, "String", 16777611, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_PLMApprovalCode")]
    protected Environment _PLMApprovalCode;
    [Metadata("The decisions that can be made regarding the approval of an object.", "DecisionTypeEnum", false, false, true, "Integer", 1051875, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_DecisionType")]
    protected Environment _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_LastRoutedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051684, false, false, false, null)]
    protected Environment _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_LastCompletedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051796, false, false, false, null)]
    protected Environment _LastCompletedOnGMT;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048809, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_SheetLevel")]
    protected Environment _SheetLevel;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_CompleteByGMT")]
    protected Environment _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_DecisionTypeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051875, false, false, false, null)]
    protected Environment _DecisionTypeName;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_Approver")]
    protected Environment _Approver;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052266, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Environment_ApprovedBy")]
    protected Environment _ApprovedBy;

    public Environment PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public Environment SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Environment ApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApproverRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApproverRole));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public Environment DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecisionType));
      }
    }

    public Environment LastRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRoutedOnGMT));
      }
    }

    public Environment LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedOnGMT));
      }
    }

    public Environment SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Environment CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public Environment DecisionTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecisionTypeName));
      }
    }

    public Environment Approver
    {
      [param: In] set
      {
        this.PropertySet(nameof (Approver), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Approver));
      }
    }

    public Environment ApprovedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovedBy));
      }
    }
  }
}
