// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateHistoryDetail_Info
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
  public class NCRUpdateHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_CorrectiveActionHistory")]
    protected Info _CorrectiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_NCRResolution")]
    protected Info _NCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_FailureInvestigationHistory")]
    protected Info _FailureInvestigationHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_PreventiveActionHistory")]
    protected Info _PreventiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_NCRFailureType")]
    protected Info _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_NCRCauseCode")]
    protected Info _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_RelatedNonconformance")]
    protected Info _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_NCRFailureCodes")]
    protected Info _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_IsPreHistory")]
    protected Info _IsPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_CorrectiveActionComments")]
    protected Info _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_PreventiveActionComments")]
    protected Info _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_NCRComment")]
    protected Info _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Info_FailureInvestigationComments")]
    protected Info _FailureInvestigationComments;

    public Info CorrectiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CorrectiveActionHistory));
      }
    }

    public Info NCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRResolution));
      }
    }

    public Info FailureInvestigationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureInvestigationHistory));
      }
    }

    public Info PreventiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreventiveActionHistory));
      }
    }

    public Info NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureType));
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

    public Info NCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRCauseCode));
      }
    }

    public Info RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RelatedNonconformance));
      }
    }

    public Info NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
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

    public Info IsPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPreHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsPreHistory));
      }
    }

    public Info CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Info PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Info NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRComment));
      }
    }

    public Info FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }
  }
}
