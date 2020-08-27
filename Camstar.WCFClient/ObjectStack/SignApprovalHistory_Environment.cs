// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SignApprovalHistory_Environment
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
  public class SignApprovalHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051298, false, false, false, null)]
    protected Environment _QualityObject;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_HistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("Comments", "", false, false, true, "String", 1051983, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_SpecialInstructions")]
    protected Environment _SpecialInstructions;
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ApproverRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1051622, false, false, false, null)]
    protected Environment _ApproverRole;
    [Metadata("The decisions that can be made regarding the approval of an object.", "DecisionTypeEnum", false, false, true, "Integer", 1051610, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_DecisionType")]
    protected Environment _DecisionType;
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, true, "SubentityRef", 1051640, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ApprovalSheetEntry")]
    protected Environment _ApprovalSheetEntry;
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecision", false, false, true, "NamedSubentityRef", 1051620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ApprovalDecision")]
    protected Environment _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ProcessObject")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "NamedSubentityRef", 1051396, false, false, false, null)]
    protected Environment _ProcessObject;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, true, "NamedSubentityRef", 1051639, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ApprovalSheet")]
    protected Environment _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_LastRoutedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051994, false, false, false, null)]
    protected Environment _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_SheetLevel")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051989, false, false, false, null)]
    protected Environment _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_CompleteBy")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051990, false, false, false, null)]
    protected Environment _CompleteBy;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051991, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_CompleteByGMT")]
    protected Environment _CompleteByGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051992, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_LastCompletedOnGMT")]
    protected Environment _LastCompletedOnGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051993, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_LastRoutedOn")]
    protected Environment _LastRoutedOn;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051534, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_LastCompletedOn")]
    protected Environment _LastCompletedOn;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051988, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ApprovalCycleGMT")]
    protected Environment _ApprovalCycleGMT;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_TrackableObject")]
    protected Environment _TrackableObject;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051987, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ApprovalCycle")]
    protected Environment _ApprovalCycle;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052266, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_ApprovedBy")]
    protected Environment _ApprovedBy;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051621, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignApprovalHistory_Environment_Approver")]
    protected Environment _Approver;

    public Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public Environment ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetEntry));
      }
    }

    public Environment ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Environment ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheet));
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

    public Environment CompleteBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteBy));
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

    public Environment LastRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRoutedOn));
      }
    }

    public Environment LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Environment ApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalCycleGMT));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Environment ApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycle), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalCycle));
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
  }
}
