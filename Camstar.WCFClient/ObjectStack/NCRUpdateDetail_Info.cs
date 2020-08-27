// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (NCRCloseDetail_Info))]
  [Serializable]
  public class NCRUpdateDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_NCRFailureType")]
    protected Info _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_NCRCauseCodeGroup")]
    protected Info _NCRCauseCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_IssueActualsHistory")]
    protected Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_NCRFailureCodes")]
    protected Info _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_NCRResolutionCode")]
    protected Info _NCRResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_EscalatedEvent")]
    protected Info _EscalatedEvent;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_NCRCauseCode")]
    protected Info _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_NCRFailureCodeGroup")]
    protected Info _NCRFailureCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_PreHistoryDetail")]
    protected Info _PreHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_RelatedNonconformance")]
    protected Info _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_FailureInvestigationComments")]
    protected NCRFailureInvestigationDetails_Info _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_PreventiveActionComments")]
    protected NCRPreventiveActionDetails_Info _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_CorrectiveActionComments")]
    protected NCRCorrectiveActionDetails_Info _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyFromFieldsPA")]
    protected Info _DirtyFromFieldsPA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyToFieldsNCR")]
    protected Info _DirtyToFieldsNCR;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyFromFieldsFI")]
    protected Info _DirtyFromFieldsFI;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyToFieldsCA")]
    protected Info _DirtyToFieldsCA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyToFieldsPA")]
    protected Info _DirtyToFieldsPA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_EscalationDate")]
    protected Info _EscalationDate;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyFromFieldsCA")]
    protected Info _DirtyFromFieldsCA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_EscalationDateGMT")]
    protected Info _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyFromFieldsNCR")]
    protected Info _DirtyFromFieldsNCR;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_DirtyToFieldsFI")]
    protected Info _DirtyToFieldsFI;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_NCRComment")]
    protected Info _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Info_EscalatedBy")]
    protected Info _EscalatedBy;

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

    public Info NCRCauseCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCodeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRCauseCodeGroup));
      }
    }

    public Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueActualsHistory));
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

    public Info NCRFailureCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureCodeGroup));
      }
    }

    public Info PreHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreHistoryDetail));
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

    public NCRFailureInvestigationDetails_Info FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (NCRFailureInvestigationDetails_Info) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public NCRPreventiveActionDetails_Info PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (NCRPreventiveActionDetails_Info) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public NCRCorrectiveActionDetails_Info CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (NCRCorrectiveActionDetails_Info) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Info Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Task));
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

    public Info DirtyFromFieldsPA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsPA), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyFromFieldsPA));
      }
    }

    public Info DirtyToFieldsNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsNCR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyToFieldsNCR));
      }
    }

    public Info DirtyFromFieldsFI
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsFI), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyFromFieldsFI));
      }
    }

    public Info DirtyToFieldsCA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsCA), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyToFieldsCA));
      }
    }

    public Info DirtyToFieldsPA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsPA), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyToFieldsPA));
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

    public Info DirtyFromFieldsCA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsCA), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyFromFieldsCA));
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

    public Info DirtyFromFieldsNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsNCR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyFromFieldsNCR));
      }
    }

    public Info DirtyToFieldsFI
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsFI), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DirtyToFieldsFI));
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
