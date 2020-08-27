// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NonconformanceReport
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
  public class NonconformanceReport : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_NCRCauseCodeGroup")]
    protected NamedObjectRef _NCRCauseCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_NCRFailureCodes")]
    protected NamedObjectRef[] _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_RelatedNonconformance")]
    protected NamedObjectRef _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_FailureInvestigationComments")]
    protected NCRFailureInvestigation _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_ChildNonconformances")]
    protected NamedObjectRef[] _ChildNonconformances;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_CurrentCrossRefs")]
    protected BaseObjectRef[] _CurrentCrossRefs;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_CorrectiveActionComments")]
    protected NCRCorrectiveAction _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_NCRStatus")]
    protected Enumeration<NCRStatusEnum, int> _NCRStatus;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Attachments")]
    protected SubentityRef _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_EscalatedEvent")]
    protected NamedObjectRef _EscalatedEvent;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_NCRCauseCode")]
    protected NamedObjectRef _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_NCRResolutionCode")]
    protected NamedObjectRef _NCRResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_PreventiveActionComments")]
    protected NCRPreventiveAction _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_CrossRefs")]
    protected BaseObjectRef[] _CrossRefs;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_NCRFailureType")]
    protected NamedObjectRef _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_EscalationDateGMT")]
    protected Primitive<DateTime> _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_CloseDateGMT")]
    protected Primitive<DateTime> _CloseDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_CloseDate")]
    protected Primitive<DateTime> _CloseDate;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_CreationDateGMT")]
    protected Primitive<DateTime> _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_EscalationDate")]
    protected Primitive<DateTime> _EscalationDate;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_NCRComment")]
    protected Primitive<string> _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_EscalatedBy")]
    protected NamedObjectRef _EscalatedBy;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is NonconformanceReport && object.Equals((object) this._NCRCauseCodeGroup, (object) ((NonconformanceReport) obj)._NCRCauseCodeGroup) && (this.CompareArrays((Array) this._NCRFailureCodes, (Array) ((NonconformanceReport) obj)._NCRFailureCodes) && object.Equals((object) this._RelatedNonconformance, (object) ((NonconformanceReport) obj)._RelatedNonconformance)) && (object.Equals((object) this._FailureInvestigationComments, (object) ((NonconformanceReport) obj)._FailureInvestigationComments) && this.CompareArrays((Array) this._ChildNonconformances, (Array) ((NonconformanceReport) obj)._ChildNonconformances) && (this.CompareArrays((Array) this._CurrentCrossRefs, (Array) ((NonconformanceReport) obj)._CurrentCrossRefs) && object.Equals((object) this._Task, (object) ((NonconformanceReport) obj)._Task))) && (object.Equals((object) this._ChargeToStep, (object) ((NonconformanceReport) obj)._ChargeToStep) && object.Equals((object) this._CorrectiveActionComments, (object) ((NonconformanceReport) obj)._CorrectiveActionComments) && (object.Equals((object) this._NCRStatus, (object) ((NonconformanceReport) obj)._NCRStatus) && object.Equals((object) this._Attachments, (object) ((NonconformanceReport) obj)._Attachments)) && (object.Equals((object) this._EscalatedEvent, (object) ((NonconformanceReport) obj)._EscalatedEvent) && object.Equals((object) this._NCRCauseCode, (object) ((NonconformanceReport) obj)._NCRCauseCode) && (object.Equals((object) this._NCRResolutionCode, (object) ((NonconformanceReport) obj)._NCRResolutionCode) && object.Equals((object) this._PreventiveActionComments, (object) ((NonconformanceReport) obj)._PreventiveActionComments)))) && (this.CompareArrays((Array) this._CrossRefs, (Array) ((NonconformanceReport) obj)._CrossRefs) && object.Equals((object) this._NCRFailureType, (object) ((NonconformanceReport) obj)._NCRFailureType) && (object.Equals((object) this._EscalationDateGMT, (object) ((NonconformanceReport) obj)._EscalationDateGMT) && object.Equals((object) this._CloseDateGMT, (object) ((NonconformanceReport) obj)._CloseDateGMT)) && (object.Equals((object) this._CloseDate, (object) ((NonconformanceReport) obj)._CloseDate) && object.Equals((object) this._CreationDateGMT, (object) ((NonconformanceReport) obj)._CreationDateGMT) && (object.Equals((object) this._CreationDate, (object) ((NonconformanceReport) obj)._CreationDate) && object.Equals((object) this._EscalationDate, (object) ((NonconformanceReport) obj)._EscalationDate))) && (object.Equals((object) this._Container, (object) ((NonconformanceReport) obj)._Container) && object.Equals((object) this._NCRComment, (object) ((NonconformanceReport) obj)._NCRComment) && (object.Equals((object) this._EscalatedBy, (object) ((NonconformanceReport) obj)._EscalatedBy) && object.Equals((object) this._Name, (object) ((NonconformanceReport) obj)._Name)))) && base.Equals(obj);
    }

    public NamedObjectRef NCRCauseCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCodeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRCauseCodeGroup));
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

    public NCRFailureInvestigation FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (NCRFailureInvestigation) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public NamedObjectRef[] ChildNonconformances
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildNonconformances), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChildNonconformances));
      }
    }

    public BaseObjectRef[] CurrentCrossRefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCrossRefs), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (CurrentCrossRefs));
      }
    }

    public NamedSubentityRef Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Task));
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

    public NCRCorrectiveAction CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (NCRCorrectiveAction) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Enumeration<NCRStatusEnum, int> NCRStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRStatus), (object) value);
      }
      get
      {
        return (Enumeration<NCRStatusEnum, int>) this.PropertyGet(nameof (NCRStatus));
      }
    }

    public SubentityRef Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (Attachments));
      }
    }

    public NamedObjectRef EscalatedEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedEvent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EscalatedEvent));
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

    public NamedObjectRef NCRResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRResolutionCode));
      }
    }

    public NCRPreventiveAction PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (NCRPreventiveAction) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public BaseObjectRef[] CrossRefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossRefs), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (CrossRefs));
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

    public Primitive<DateTime> EscalationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EscalationDateGMT));
      }
    }

    public Primitive<DateTime> CloseDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CloseDateGMT));
      }
    }

    public Primitive<DateTime> CloseDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CloseDate));
      }
    }

    public Primitive<DateTime> CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Primitive<DateTime> EscalationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EscalationDate));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public NamedObjectRef EscalatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EscalatedBy));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
