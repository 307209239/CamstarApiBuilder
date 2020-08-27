// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetHistory_Environment
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
  public class ApprovalSheetHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051298, false, false, false, null)]
    protected Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_HistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("Comments", "", false, false, true, "String", 1051979, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_GeneralInstructions")]
    protected Environment _GeneralInstructions;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_Status")]
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    protected Environment _Status;
    [Metadata("History of the Sign Approval transactions", "SignApprovalHistory", false, false, true, "SignApprovalHistory", 1051997, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_SignApprovalHistory")]
    protected SignApprovalHistory_Environment _SignApprovalHistory;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_ProcessObject")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "NamedSubentityRef", 1051396, false, false, false, null)]
    protected Environment _ProcessObject;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, true, "NamedSubentityRef", 1051639, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_ApprovalSheet")]
    protected Environment _ApprovalSheet;
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, true, "SubentityRef", 1051640, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_ApprovalSheetEntry")]
    protected Environment _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_ApprovalCycle")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051987, false, false, false, null)]
    protected Environment _ApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_TrackableObject")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1051446, false, false, false, null)]
    protected Environment _TrackableObject;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Environment_ApprovalCycleGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051988, false, false, false, null)]
    protected Environment _ApprovalCycleGMT;

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

    public Environment GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GeneralInstructions));
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

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public SignApprovalHistory_Environment SignApprovalHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignApprovalHistory), (object) value);
      }
      get
      {
        return (SignApprovalHistory_Environment) this.PropertyGet(nameof (SignApprovalHistory));
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
  }
}
