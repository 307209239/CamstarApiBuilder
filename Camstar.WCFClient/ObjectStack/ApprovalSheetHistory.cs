// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetHistory
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
  public class ApprovalSheetHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_Status")]
    protected Enumeration<ApprovalStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_SignApprovalHistory")]
    protected Camstar.WCF.ObjectStack.SignApprovalHistory[] _SignApprovalHistory;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_ProcessObject")]
    protected NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_ApprovalSheetEntry")]
    protected SubentityRef _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_ApprovalCycle")]
    protected Primitive<DateTime> _ApprovalCycle;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_TrackableObject")]
    protected BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetHistory_ApprovalCycleGMT")]
    protected Primitive<DateTime> _ApprovalCycleGMT;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheetHistory && object.Equals((object) this._QualityObject, (object) ((ApprovalSheetHistory) obj)._QualityObject) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((ApprovalSheetHistory) obj)._HistoryDetails) && object.Equals((object) this._GeneralInstructions, (object) ((ApprovalSheetHistory) obj)._GeneralInstructions)) && (object.Equals((object) this._ExportImportKey, (object) ((ApprovalSheetHistory) obj)._ExportImportKey) && object.Equals((object) this._Comments, (object) ((ApprovalSheetHistory) obj)._Comments) && (object.Equals((object) this._Status, (object) ((ApprovalSheetHistory) obj)._Status) && this.CompareArrays((Array) this._SignApprovalHistory, (Array) ((ApprovalSheetHistory) obj)._SignApprovalHistory))) && (object.Equals((object) this._ProcessObject, (object) ((ApprovalSheetHistory) obj)._ProcessObject) && object.Equals((object) this._ApprovalSheet, (object) ((ApprovalSheetHistory) obj)._ApprovalSheet) && (object.Equals((object) this._ApprovalSheetEntry, (object) ((ApprovalSheetHistory) obj)._ApprovalSheetEntry) && object.Equals((object) this._ApprovalCycle, (object) ((ApprovalSheetHistory) obj)._ApprovalCycle)) && (object.Equals((object) this._TrackableObject, (object) ((ApprovalSheetHistory) obj)._TrackableObject) && object.Equals((object) this._HistoryId, (object) ((ApprovalSheetHistory) obj)._HistoryId) && object.Equals((object) this._ApprovalCycleGMT, (object) ((ApprovalSheetHistory) obj)._ApprovalCycleGMT))) && base.Equals(obj);
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Enumeration<ApprovalStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public Camstar.WCF.ObjectStack.SignApprovalHistory[] SignApprovalHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignApprovalHistory), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.SignApprovalHistory[]) this.PropertyGet(nameof (SignApprovalHistory));
      }
    }

    public NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public SubentityRef ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalSheetEntry));
      }
    }

    public Primitive<DateTime> ApprovalCycle
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycle), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ApprovalCycle));
      }
    }

    public BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<DateTime> ApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ApprovalCycleGMT));
      }
    }
  }
}
