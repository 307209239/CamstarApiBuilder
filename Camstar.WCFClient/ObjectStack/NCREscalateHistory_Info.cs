// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCREscalateHistory_Info
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
  public class NCREscalateHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_NCRFailureCodes")]
    protected Info _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_EscalatedEvent")]
    protected Info _EscalatedEvent;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_NCRResolutionCode")]
    protected Info _NCRResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_NCRComment")]
    protected Info _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_NonconformanceReport")]
    protected Info _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_NCRCauseCode")]
    protected Info _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_EscalationDateGMT")]
    protected Info _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_EscalationDate")]
    protected Info _EscalationDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Info_EscalatedBy")]
    protected Info _EscalatedBy;

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

    public Info EscalatedEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedEvent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EscalatedEvent));
      }
    }

    public Info NCRResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRResolutionCode));
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

    public Info NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceReport));
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

    public Info PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
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

    public Info EscalationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EscalationDateGMT));
      }
    }

    public Info EscalationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EscalationDate));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info EscalatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EscalatedBy));
      }
    }
  }
}
