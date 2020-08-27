// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetHistory_Info
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
  public class ApprovalSheetHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_GeneralInstructions")]
    protected Info _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_SignApprovalHistory")]
    protected SignApprovalHistory_Info _SignApprovalHistory;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_ProcessObject")]
    protected Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_ApprovalSheetEntry")]
    protected Info _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_ApprovalCycle")]
    protected Info _ApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_TrackableObject")]
    protected Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Info_ApprovalCycleGMT")]
    protected Info _ApprovalCycleGMT;

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

    public Info GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralInstructions));
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

    public SignApprovalHistory_Info SignApprovalHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignApprovalHistory), (object) value);
      }
      get
      {
        return (SignApprovalHistory_Info) this.PropertyGet(nameof (SignApprovalHistory));
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
  }
}
