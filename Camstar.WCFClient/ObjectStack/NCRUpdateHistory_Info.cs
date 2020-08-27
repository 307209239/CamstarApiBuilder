// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (NCRCloseHistory_Info))]
  [Serializable]
  public class NCRUpdateHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreNCRCauseCode")]
    protected Info _PreNCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostNCRResolution")]
    protected Info _PostNCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_NCRUpdateHistoryDetails")]
    protected Info _NCRUpdateHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostChargeToStep")]
    protected Info _PostChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreNCRFailureType")]
    protected Info _PreNCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreRelatedNonconformance")]
    protected Info _PreRelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostRelatedNonconformance")]
    protected Info _PostRelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostNCRFailureCodes")]
    protected Info _PostNCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreChargeToStep")]
    protected Info _PreChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_HistoryDetails")]
    protected NCRDefectHistoryDetails_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreNCRResolution")]
    protected Info _PreNCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreNCRFailureCodes")]
    protected Info _PreNCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostNCRFailureType")]
    protected Info _PostNCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostNCRCauseCode")]
    protected Info _PostNCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostPreventiveActionComments")]
    protected Info _PostPreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostCorrectiveActionComments")]
    protected Info _PostCorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostFailureInvestigationComments")]
    protected Info _PostFailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PrePreventiveActionComments")]
    protected Info _PrePreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreNCRComment")]
    protected Info _PreNCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreFailureInvestigationComments")]
    protected Info _PreFailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PreCorrectiveActionComments")]
    protected Info _PreCorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Info_PostNCRComment")]
    protected Info _PostNCRComment;

    public Info PreNCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRCauseCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreNCRCauseCode));
      }
    }

    public Info PostNCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRResolution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostNCRResolution));
      }
    }

    public Info NCRUpdateHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRUpdateHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRUpdateHistoryDetails));
      }
    }

    public Info PostChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostChargeToStep));
      }
    }

    public Info PreNCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRFailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreNCRFailureType));
      }
    }

    public Info PreRelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreRelatedNonconformance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreRelatedNonconformance));
      }
    }

    public Info PostRelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostRelatedNonconformance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostRelatedNonconformance));
      }
    }

    public Info PostNCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRFailureCodes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostNCRFailureCodes));
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

    public Info PreChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreChargeToStep));
      }
    }

    public NCRDefectHistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info PreNCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRResolution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreNCRResolution));
      }
    }

    public Info PreNCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRFailureCodes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreNCRFailureCodes));
      }
    }

    public Info PostNCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRFailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostNCRFailureType));
      }
    }

    public Info PostNCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRCauseCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostNCRCauseCode));
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

    public Info PostPreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostPreventiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostPreventiveActionComments));
      }
    }

    public Info PostCorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostCorrectiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostCorrectiveActionComments));
      }
    }

    public Info PostFailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostFailureInvestigationComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostFailureInvestigationComments));
      }
    }

    public Info PrePreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrePreventiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrePreventiveActionComments));
      }
    }

    public Info PreNCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreNCRComment));
      }
    }

    public Info PreFailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreFailureInvestigationComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreFailureInvestigationComments));
      }
    }

    public Info PreCorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreCorrectiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreCorrectiveActionComments));
      }
    }

    public Info PostNCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PostNCRComment));
      }
    }
  }
}
