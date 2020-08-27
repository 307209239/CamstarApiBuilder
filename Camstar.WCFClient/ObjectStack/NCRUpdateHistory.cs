// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (NCRCloseHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NCRUpdateHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreNCRCauseCode")]
    protected NamedObjectRef _PreNCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostNCRResolution")]
    protected NamedObjectRef _PostNCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_NCRUpdateHistoryDetails")]
    protected SubentityRef[] _NCRUpdateHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostChargeToStep")]
    protected NamedSubentityRef _PostChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreNCRFailureType")]
    protected NamedObjectRef _PreNCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreRelatedNonconformance")]
    protected NamedObjectRef _PreRelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostRelatedNonconformance")]
    protected NamedObjectRef _PostRelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostNCRFailureCodes")]
    protected NamedObjectRef[] _PostNCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreChargeToStep")]
    protected NamedSubentityRef _PreChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_HistoryDetails")]
    protected NCRDefectHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreNCRResolution")]
    protected NamedObjectRef _PreNCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreNCRFailureCodes")]
    protected NamedObjectRef[] _PreNCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostNCRFailureType")]
    protected NamedObjectRef _PostNCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostNCRCauseCode")]
    protected NamedObjectRef _PostNCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostPreventiveActionComments")]
    protected Primitive<string> _PostPreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostCorrectiveActionComments")]
    protected Primitive<string> _PostCorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostFailureInvestigationComments")]
    protected Primitive<string> _PostFailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PrePreventiveActionComments")]
    protected Primitive<string> _PrePreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreNCRComment")]
    protected Primitive<string> _PreNCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreFailureInvestigationComments")]
    protected Primitive<string> _PreFailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PreCorrectiveActionComments")]
    protected Primitive<string> _PreCorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_PostNCRComment")]
    protected Primitive<string> _PostNCRComment;

    public override bool Equals(object obj)
    {
      return obj is NCRUpdateHistory && object.Equals((object) this._PreNCRCauseCode, (object) ((NCRUpdateHistory) obj)._PreNCRCauseCode) && (object.Equals((object) this._PostNCRResolution, (object) ((NCRUpdateHistory) obj)._PostNCRResolution) && this.CompareArrays((Array) this._NCRUpdateHistoryDetails, (Array) ((NCRUpdateHistory) obj)._NCRUpdateHistoryDetails)) && (object.Equals((object) this._PostChargeToStep, (object) ((NCRUpdateHistory) obj)._PostChargeToStep) && object.Equals((object) this._PreNCRFailureType, (object) ((NCRUpdateHistory) obj)._PreNCRFailureType) && (object.Equals((object) this._PreRelatedNonconformance, (object) ((NCRUpdateHistory) obj)._PreRelatedNonconformance) && object.Equals((object) this._PostRelatedNonconformance, (object) ((NCRUpdateHistory) obj)._PostRelatedNonconformance))) && (this.CompareArrays((Array) this._PostNCRFailureCodes, (Array) ((NCRUpdateHistory) obj)._PostNCRFailureCodes) && object.Equals((object) this._ExportImportKey, (object) ((NCRUpdateHistory) obj)._ExportImportKey) && (object.Equals((object) this._PreChargeToStep, (object) ((NCRUpdateHistory) obj)._PreChargeToStep) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((NCRUpdateHistory) obj)._HistoryDetails)) && (object.Equals((object) this._PreNCRResolution, (object) ((NCRUpdateHistory) obj)._PreNCRResolution) && this.CompareArrays((Array) this._PreNCRFailureCodes, (Array) ((NCRUpdateHistory) obj)._PreNCRFailureCodes) && (object.Equals((object) this._PostNCRFailureType, (object) ((NCRUpdateHistory) obj)._PostNCRFailureType) && object.Equals((object) this._PostNCRCauseCode, (object) ((NCRUpdateHistory) obj)._PostNCRCauseCode)))) && (object.Equals((object) this._HistoryId, (object) ((NCRUpdateHistory) obj)._HistoryId) && object.Equals((object) this._PostPreventiveActionComments, (object) ((NCRUpdateHistory) obj)._PostPreventiveActionComments) && (object.Equals((object) this._PostCorrectiveActionComments, (object) ((NCRUpdateHistory) obj)._PostCorrectiveActionComments) && object.Equals((object) this._PostFailureInvestigationComments, (object) ((NCRUpdateHistory) obj)._PostFailureInvestigationComments)) && (object.Equals((object) this._PrePreventiveActionComments, (object) ((NCRUpdateHistory) obj)._PrePreventiveActionComments) && object.Equals((object) this._PreNCRComment, (object) ((NCRUpdateHistory) obj)._PreNCRComment) && (object.Equals((object) this._PreFailureInvestigationComments, (object) ((NCRUpdateHistory) obj)._PreFailureInvestigationComments) && object.Equals((object) this._PreCorrectiveActionComments, (object) ((NCRUpdateHistory) obj)._PreCorrectiveActionComments))) && object.Equals((object) this._PostNCRComment, (object) ((NCRUpdateHistory) obj)._PostNCRComment)) && base.Equals(obj);
    }

    public NamedObjectRef PreNCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRCauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PreNCRCauseCode));
      }
    }

    public NamedObjectRef PostNCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRResolution), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PostNCRResolution));
      }
    }

    public SubentityRef[] NCRUpdateHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRUpdateHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (NCRUpdateHistoryDetails));
      }
    }

    public NamedSubentityRef PostChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (PostChargeToStep));
      }
    }

    public NamedObjectRef PreNCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRFailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PreNCRFailureType));
      }
    }

    public NamedObjectRef PreRelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreRelatedNonconformance), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PreRelatedNonconformance));
      }
    }

    public NamedObjectRef PostRelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostRelatedNonconformance), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PostRelatedNonconformance));
      }
    }

    public NamedObjectRef[] PostNCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRFailureCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (PostNCRFailureCodes));
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

    public NamedSubentityRef PreChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (PreChargeToStep));
      }
    }

    public NCRDefectHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public NamedObjectRef PreNCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRResolution), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PreNCRResolution));
      }
    }

    public NamedObjectRef[] PreNCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRFailureCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (PreNCRFailureCodes));
      }
    }

    public NamedObjectRef PostNCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRFailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PostNCRFailureType));
      }
    }

    public NamedObjectRef PostNCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRCauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PostNCRCauseCode));
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

    public Primitive<string> PostPreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostPreventiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PostPreventiveActionComments));
      }
    }

    public Primitive<string> PostCorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostCorrectiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PostCorrectiveActionComments));
      }
    }

    public Primitive<string> PostFailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostFailureInvestigationComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PostFailureInvestigationComments));
      }
    }

    public Primitive<string> PrePreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrePreventiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PrePreventiveActionComments));
      }
    }

    public Primitive<string> PreNCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PreNCRComment));
      }
    }

    public Primitive<string> PreFailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreFailureInvestigationComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PreFailureInvestigationComments));
      }
    }

    public Primitive<string> PreCorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreCorrectiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PreCorrectiveActionComments));
      }
    }

    public Primitive<string> PostNCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRComment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PostNCRComment));
      }
    }
  }
}
