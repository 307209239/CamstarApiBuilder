// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (NCRCloseDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NCRUpdateDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_NCRFailureType")]
    protected NamedObjectRef _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_NCRCauseCodeGroup")]
    protected NamedObjectRef _NCRCauseCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_IssueActualsHistory")]
    protected SubentityRef[] _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_NCRFailureCodes")]
    protected NamedObjectRef[] _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_NCRResolutionCode")]
    protected NamedObjectRef _NCRResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_EscalatedEvent")]
    protected NamedObjectRef _EscalatedEvent;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_NCRCauseCode")]
    protected NamedObjectRef _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_NCRFailureCodeGroup")]
    protected NamedObjectRef _NCRFailureCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_PreHistoryDetail")]
    protected SubentityRef _PreHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_RelatedNonconformance")]
    protected NamedObjectRef _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_FailureInvestigationComments")]
    protected NCRFailureInvestigationDetails _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_PreventiveActionComments")]
    protected NCRPreventiveActionDetails _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_CorrectiveActionComments")]
    protected NCRCorrectiveActionDetails _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyFromFieldsPA")]
    protected Primitive<int>[] _DirtyFromFieldsPA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyToFieldsNCR")]
    protected Primitive<int>[] _DirtyToFieldsNCR;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyFromFieldsFI")]
    protected Primitive<int>[] _DirtyFromFieldsFI;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyToFieldsCA")]
    protected Primitive<int>[] _DirtyToFieldsCA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyToFieldsPA")]
    protected Primitive<int>[] _DirtyToFieldsPA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_EscalationDate")]
    protected Primitive<DateTime> _EscalationDate;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyFromFieldsCA")]
    protected Primitive<int>[] _DirtyFromFieldsCA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_EscalationDateGMT")]
    protected Primitive<DateTime> _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyFromFieldsNCR")]
    protected Primitive<int>[] _DirtyFromFieldsNCR;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_DirtyToFieldsFI")]
    protected Primitive<int>[] _DirtyToFieldsFI;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_NCRComment")]
    protected Primitive<string> _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_EscalatedBy")]
    protected NamedObjectRef _EscalatedBy;

    public override bool Equals(object obj)
    {
      return obj is NCRUpdateDetail && object.Equals((object) this._ChargeToStep, (object) ((NCRUpdateDetail) obj)._ChargeToStep) && (object.Equals((object) this._NCRFailureType, (object) ((NCRUpdateDetail) obj)._NCRFailureType) && object.Equals((object) this._NCRCauseCodeGroup, (object) ((NCRUpdateDetail) obj)._NCRCauseCodeGroup)) && (this.CompareArrays((Array) this._IssueActualsHistory, (Array) ((NCRUpdateDetail) obj)._IssueActualsHistory) && this.CompareArrays((Array) this._NCRFailureCodes, (Array) ((NCRUpdateDetail) obj)._NCRFailureCodes) && (object.Equals((object) this._NCRResolutionCode, (object) ((NCRUpdateDetail) obj)._NCRResolutionCode) && object.Equals((object) this._EscalatedEvent, (object) ((NCRUpdateDetail) obj)._EscalatedEvent))) && (object.Equals((object) this._NCRCauseCode, (object) ((NCRUpdateDetail) obj)._NCRCauseCode) && object.Equals((object) this._NCRFailureCodeGroup, (object) ((NCRUpdateDetail) obj)._NCRFailureCodeGroup) && (object.Equals((object) this._PreHistoryDetail, (object) ((NCRUpdateDetail) obj)._PreHistoryDetail) && object.Equals((object) this._RelatedNonconformance, (object) ((NCRUpdateDetail) obj)._RelatedNonconformance)) && (object.Equals((object) this._FailureInvestigationComments, (object) ((NCRUpdateDetail) obj)._FailureInvestigationComments) && object.Equals((object) this._PreventiveActionComments, (object) ((NCRUpdateDetail) obj)._PreventiveActionComments) && (object.Equals((object) this._CorrectiveActionComments, (object) ((NCRUpdateDetail) obj)._CorrectiveActionComments) && object.Equals((object) this._Task, (object) ((NCRUpdateDetail) obj)._Task)))) && (object.Equals((object) this._Container, (object) ((NCRUpdateDetail) obj)._Container) && this.CompareArrays((Array) this._DirtyFromFieldsPA, (Array) ((NCRUpdateDetail) obj)._DirtyFromFieldsPA) && (this.CompareArrays((Array) this._DirtyToFieldsNCR, (Array) ((NCRUpdateDetail) obj)._DirtyToFieldsNCR) && this.CompareArrays((Array) this._DirtyFromFieldsFI, (Array) ((NCRUpdateDetail) obj)._DirtyFromFieldsFI)) && (this.CompareArrays((Array) this._DirtyToFieldsCA, (Array) ((NCRUpdateDetail) obj)._DirtyToFieldsCA) && this.CompareArrays((Array) this._DirtyToFieldsPA, (Array) ((NCRUpdateDetail) obj)._DirtyToFieldsPA) && (object.Equals((object) this._EscalationDate, (object) ((NCRUpdateDetail) obj)._EscalationDate) && this.CompareArrays((Array) this._DirtyFromFieldsCA, (Array) ((NCRUpdateDetail) obj)._DirtyFromFieldsCA))) && (object.Equals((object) this._EscalationDateGMT, (object) ((NCRUpdateDetail) obj)._EscalationDateGMT) && this.CompareArrays((Array) this._DirtyFromFieldsNCR, (Array) ((NCRUpdateDetail) obj)._DirtyFromFieldsNCR) && (this.CompareArrays((Array) this._DirtyToFieldsFI, (Array) ((NCRUpdateDetail) obj)._DirtyToFieldsFI) && object.Equals((object) this._NCRComment, (object) ((NCRUpdateDetail) obj)._NCRComment)) && object.Equals((object) this._EscalatedBy, (object) ((NCRUpdateDetail) obj)._EscalatedBy))) && base.Equals(obj);
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

    public SubentityRef[] IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (IssueActualsHistory));
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

    public NamedObjectRef NCRFailureCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRFailureCodeGroup));
      }
    }

    public SubentityRef PreHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (PreHistoryDetail));
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

    public NCRFailureInvestigationDetails FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (NCRFailureInvestigationDetails) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public NCRPreventiveActionDetails PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (NCRPreventiveActionDetails) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public NCRCorrectiveActionDetails CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (NCRCorrectiveActionDetails) this.PropertyGet(nameof (CorrectiveActionComments));
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

    public Primitive<int>[] DirtyFromFieldsPA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsPA), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyFromFieldsPA));
      }
    }

    public Primitive<int>[] DirtyToFieldsNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsNCR), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyToFieldsNCR));
      }
    }

    public Primitive<int>[] DirtyFromFieldsFI
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsFI), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyFromFieldsFI));
      }
    }

    public Primitive<int>[] DirtyToFieldsCA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsCA), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyToFieldsCA));
      }
    }

    public Primitive<int>[] DirtyToFieldsPA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsPA), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyToFieldsPA));
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

    public Primitive<int>[] DirtyFromFieldsCA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsCA), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyFromFieldsCA));
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

    public Primitive<int>[] DirtyFromFieldsNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsNCR), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyFromFieldsNCR));
      }
    }

    public Primitive<int>[] DirtyToFieldsFI
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsFI), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DirtyToFieldsFI));
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
  }
}
