// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateHistoryDetail
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
  public class NCRUpdateHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_CorrectiveActionHistory")]
    protected SubentityRef _CorrectiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_NCRResolution")]
    protected NamedObjectRef _NCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_FailureInvestigationHistory")]
    protected SubentityRef _FailureInvestigationHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_PreventiveActionHistory")]
    protected SubentityRef _PreventiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_NCRFailureType")]
    protected NamedObjectRef _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_NCRCauseCode")]
    protected NamedObjectRef _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_RelatedNonconformance")]
    protected NamedObjectRef _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_NCRFailureCodes")]
    protected NamedObjectRef[] _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_IsPreHistory")]
    protected Primitive<bool> _IsPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_CorrectiveActionComments")]
    protected Primitive<string> _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_PreventiveActionComments")]
    protected Primitive<string> _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_NCRComment")]
    protected Primitive<string> _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_FailureInvestigationComments")]
    protected Primitive<string> _FailureInvestigationComments;

    public override bool Equals(object obj)
    {
      return obj is NCRUpdateHistoryDetail && object.Equals((object) this._CorrectiveActionHistory, (object) ((NCRUpdateHistoryDetail) obj)._CorrectiveActionHistory) && (object.Equals((object) this._NCRResolution, (object) ((NCRUpdateHistoryDetail) obj)._NCRResolution) && object.Equals((object) this._FailureInvestigationHistory, (object) ((NCRUpdateHistoryDetail) obj)._FailureInvestigationHistory)) && (object.Equals((object) this._PreventiveActionHistory, (object) ((NCRUpdateHistoryDetail) obj)._PreventiveActionHistory) && object.Equals((object) this._NCRFailureType, (object) ((NCRUpdateHistoryDetail) obj)._NCRFailureType) && (object.Equals((object) this._ExportImportKey, (object) ((NCRUpdateHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._NCRCauseCode, (object) ((NCRUpdateHistoryDetail) obj)._NCRCauseCode))) && (object.Equals((object) this._RelatedNonconformance, (object) ((NCRUpdateHistoryDetail) obj)._RelatedNonconformance) && this.CompareArrays((Array) this._NCRFailureCodes, (Array) ((NCRUpdateHistoryDetail) obj)._NCRFailureCodes) && (object.Equals((object) this._ChargeToStep, (object) ((NCRUpdateHistoryDetail) obj)._ChargeToStep) && object.Equals((object) this._HistoryId, (object) ((NCRUpdateHistoryDetail) obj)._HistoryId)) && (object.Equals((object) this._IsPreHistory, (object) ((NCRUpdateHistoryDetail) obj)._IsPreHistory) && object.Equals((object) this._CorrectiveActionComments, (object) ((NCRUpdateHistoryDetail) obj)._CorrectiveActionComments) && (object.Equals((object) this._PreventiveActionComments, (object) ((NCRUpdateHistoryDetail) obj)._PreventiveActionComments) && object.Equals((object) this._NCRComment, (object) ((NCRUpdateHistoryDetail) obj)._NCRComment)))) && object.Equals((object) this._FailureInvestigationComments, (object) ((NCRUpdateHistoryDetail) obj)._FailureInvestigationComments) && base.Equals(obj);
    }

    public SubentityRef CorrectiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (CorrectiveActionHistory));
      }
    }

    public NamedObjectRef NCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolution), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRResolution));
      }
    }

    public SubentityRef FailureInvestigationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (FailureInvestigationHistory));
      }
    }

    public SubentityRef PreventiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (PreventiveActionHistory));
      }
    }

    public NamedObjectRef NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRFailureType));
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

    public NamedObjectRef NCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRCauseCode));
      }
    }

    public NamedObjectRef RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RelatedNonconformance));
      }
    }

    public NamedObjectRef[] NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public NamedSubentityRef ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChargeToStep));
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

    public Primitive<bool> IsPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPreHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsPreHistory));
      }
    }

    public Primitive<string> CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Primitive<string> PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Primitive<string> NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NCRComment));
      }
    }

    public Primitive<string> FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }
  }
}
