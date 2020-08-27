// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (NCRCloseDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NCRUpdateDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_NCRFailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, false, "NamedObjectRef", 1050450, false, false, true, null)]
    protected Environment _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_NCRCauseCodeGroup")]
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, false, "NamedObjectRef", 1050493, false, false, true, null)]
    protected Environment _NCRCauseCodeGroup;
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, true, "SubentityRef", 1049663, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_IssueActualsHistory")]
    protected Environment _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_NCRFailureCodes")]
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, true, false, "NamedObjectRef", 1050449, false, true, true, null)]
    protected Environment _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_NCRResolutionCode")]
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, false, "NamedObjectRef", 1050494, false, false, true, null)]
    protected Environment _NCRResolutionCode;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1052259, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_EscalatedEvent")]
    protected Environment _EscalatedEvent;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, false, "NamedObjectRef", 1050492, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_NCRCauseCode")]
    protected Environment _NCRCauseCode;
    [Metadata("A User Code Object Group that represents a group of NCRFailureCodes.", "NCRFailureCodeGroup", false, false, false, "NamedObjectRef", 1050453, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_NCRFailureCodeGroup")]
    protected Environment _NCRFailureCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_PreHistoryDetail")]
    [Metadata("Detail history of the NCRUpdate service.", "NCRUpdateHistoryDetail", false, false, false, "SubentityRef", 1050289, false, false, false, null)]
    protected Environment _PreHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_RelatedNonconformance")]
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, false, "NamedObjectRef", 1050603, false, false, false, null)]
    protected Environment _RelatedNonconformance;
    [Metadata("The actions taken to research why a nonconformance occurred.", "NCRFailureInvestigationDetails", false, false, false, "NCRFailureInvestigationDetails", 1050434, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_FailureInvestigationComments")]
    protected NCRFailureInvestigationDetails_Environment _FailureInvestigationComments;
    [Metadata("The actions taken to ensure that a problem does not continue to occur.", "NCRPreventiveActionDetails", false, false, false, "NCRPreventiveActionDetails", 1050432, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_PreventiveActionComments")]
    protected NCRPreventiveActionDetails_Environment _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_CorrectiveActionComments")]
    [Metadata("The actions taken to address a particular instance of a problem.", "NCRCorrectiveActionDetails", false, false, false, "NCRCorrectiveActionDetails", 1050433, true, false, false, null)]
    protected NCRCorrectiveActionDetails_Environment _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_Task")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, true, "NamedSubentityRef", 1050503, false, false, true, null)]
    protected Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyFromFieldsPA")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050458, false, true, false, null)]
    protected Environment _DirtyFromFieldsPA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyToFieldsNCR")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050457, false, true, false, null)]
    protected Environment _DirtyToFieldsNCR;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050462, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyFromFieldsFI")]
    protected Environment _DirtyFromFieldsFI;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyToFieldsCA")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050461, false, true, false, null)]
    protected Environment _DirtyToFieldsCA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyToFieldsPA")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050459, false, true, false, null)]
    protected Environment _DirtyToFieldsPA;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052260, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_EscalationDate")]
    protected Environment _EscalationDate;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050460, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyFromFieldsCA")]
    protected Environment _DirtyFromFieldsCA;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_EscalationDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052261, false, false, false, null)]
    protected Environment _EscalationDateGMT;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050456, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyFromFieldsNCR")]
    protected Environment _DirtyFromFieldsNCR;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_DirtyToFieldsFI")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050463, false, true, false, null)]
    protected Environment _DirtyToFieldsFI;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1049480, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_NCRComment")]
    protected Environment _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateDetail_Environment_EscalatedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052262, false, false, false, null)]
    protected Environment _EscalatedBy;

    public Environment ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public Environment NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRFailureType));
      }
    }

    public Environment NCRCauseCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCodeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRCauseCodeGroup));
      }
    }

    public Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Environment NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public Environment NCRResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRResolutionCode));
      }
    }

    public Environment EscalatedEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedEvent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EscalatedEvent));
      }
    }

    public Environment NCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRCauseCode));
      }
    }

    public Environment NCRFailureCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRFailureCodeGroup));
      }
    }

    public Environment PreHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreHistoryDetail));
      }
    }

    public Environment RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RelatedNonconformance));
      }
    }

    public NCRFailureInvestigationDetails_Environment FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (NCRFailureInvestigationDetails_Environment) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public NCRPreventiveActionDetails_Environment PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (NCRPreventiveActionDetails_Environment) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public NCRCorrectiveActionDetails_Environment CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (NCRCorrectiveActionDetails_Environment) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Environment Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Task));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment DirtyFromFieldsPA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsPA), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyFromFieldsPA));
      }
    }

    public Environment DirtyToFieldsNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsNCR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyToFieldsNCR));
      }
    }

    public Environment DirtyFromFieldsFI
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsFI), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyFromFieldsFI));
      }
    }

    public Environment DirtyToFieldsCA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsCA), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyToFieldsCA));
      }
    }

    public Environment DirtyToFieldsPA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsPA), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyToFieldsPA));
      }
    }

    public Environment EscalationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EscalationDate));
      }
    }

    public Environment DirtyFromFieldsCA
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsCA), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyFromFieldsCA));
      }
    }

    public Environment EscalationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EscalationDateGMT));
      }
    }

    public Environment DirtyFromFieldsNCR
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyFromFieldsNCR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyFromFieldsNCR));
      }
    }

    public Environment DirtyToFieldsFI
    {
      [param: In] set
      {
        this.PropertySet(nameof (DirtyToFieldsFI), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DirtyToFieldsFI));
      }
    }

    public Environment NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRComment));
      }
    }

    public Environment EscalatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalatedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EscalatedBy));
      }
    }
  }
}
