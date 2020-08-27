// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NonconformanceReport_Info
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
  public class NonconformanceReport_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_NCRCauseCodeGroup")]
    protected Info _NCRCauseCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_NCRFailureCodes")]
    protected Info _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_RelatedNonconformance")]
    protected Info _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_FailureInvestigationComments")]
    protected NCRFailureInvestigation_Info _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_ChildNonconformances")]
    protected Info _ChildNonconformances;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_CurrentCrossRefs")]
    protected Info _CurrentCrossRefs;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_CorrectiveActionComments")]
    protected NCRCorrectiveAction_Info _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_NCRStatus")]
    protected Info _NCRStatus;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_Attachments")]
    protected Info _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_EscalatedEvent")]
    protected Info _EscalatedEvent;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_NCRCauseCode")]
    protected Info _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_NCRResolutionCode")]
    protected Info _NCRResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_PreventiveActionComments")]
    protected NCRPreventiveAction_Info _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_CrossRefs")]
    protected Info _CrossRefs;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_NCRFailureType")]
    protected Info _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_EscalationDateGMT")]
    protected Info _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_CloseDateGMT")]
    protected Info _CloseDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_CloseDate")]
    protected Info _CloseDate;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_CreationDateGMT")]
    protected Info _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_EscalationDate")]
    protected Info _EscalationDate;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_NCRComment")]
    protected Info _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_EscalatedBy")]
    protected Info _EscalatedBy;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Info_Name")]
    protected Info _Name;

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

    public NCRFailureInvestigation_Info FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (NCRFailureInvestigation_Info) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public Info ChildNonconformances
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildNonconformances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildNonconformances));
      }
    }

    public Info CurrentCrossRefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCrossRefs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentCrossRefs));
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

    public NCRCorrectiveAction_Info CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (NCRCorrectiveAction_Info) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Info NCRStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRStatus));
      }
    }

    public Info Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Attachments));
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

    public NCRPreventiveAction_Info PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (NCRPreventiveAction_Info) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Info CrossRefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossRefs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CrossRefs));
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

    public Info CloseDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseDateGMT));
      }
    }

    public Info CloseDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseDate));
      }
    }

    public Info CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Info CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDate));
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

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
