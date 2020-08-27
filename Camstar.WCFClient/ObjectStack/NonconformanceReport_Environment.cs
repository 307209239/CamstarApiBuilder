// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NonconformanceReport_Environment
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
  public class NonconformanceReport_Environment : BaseObject_Environment
  {
    [Metadata("A User Code Object Group that represents a group of NCRCauseCodes.", "NCRCauseCodeGroup", false, false, true, "NamedObjectRef", 1050426, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_NCRCauseCodeGroup")]
    protected Environment _NCRCauseCodeGroup;
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, true, "NamedObjectRef", 1050425, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_NCRFailureCodes")]
    protected Environment _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_RelatedNonconformance")]
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050603, false, false, false, null)]
    protected Environment _RelatedNonconformance;
    [Metadata("Failure investigation comments.", "NCRFailureInvestigation", false, false, true, "NCRFailureInvestigation", 1050434, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_FailureInvestigationComments")]
    protected NCRFailureInvestigation_Environment _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_ChildNonconformances")]
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050421, false, true, false, null)]
    protected Environment _ChildNonconformances;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_CurrentCrossRefs")]
    [Metadata("The HistoryCrossRef is the means of correlating a single history mainline record (representing a single transaction) to the container(s) to which it applies.  A single transaction applies to multiple containers when it is executed against a container that has child containers ", "HistoryCrossRef", false, false, true, "BaseObjectRef", 1050565, false, true, false, null)]
    protected Environment _CurrentCrossRefs;
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, true, "NamedSubentityRef", 1050503, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_Task")]
    protected Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_ChargeToStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1049822, false, false, false, null)]
    protected Environment _ChargeToStep;
    [Metadata("Corrective action comments.", "NCRCorrectiveAction", false, false, true, "NCRCorrectiveAction", 1050433, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_CorrectiveActionComments")]
    protected NCRCorrectiveAction_Environment _CorrectiveActionComments;
    [Metadata("Current status of the Nonconformance. This value is used to distinguish between Nonconformance that are open and closed.\r\n\r\nValid values and their meanings are:\r\n1= Open\r\n2 = Closed\r\n", "NCRStatusEnum", false, false, true, "Integer", 1050431, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_NCRStatus")]
    protected Environment _NCRStatus;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_Attachments")]
    [Metadata("Document Attachments", "DocAttachments", false, false, true, "SubentityRef", 1051144, true, false, false, null)]
    protected Environment _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_EscalatedEvent")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1052259, false, false, false, null)]
    protected Environment _EscalatedEvent;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1050427, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_NCRCauseCode")]
    protected Environment _NCRCauseCode;
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, true, "NamedObjectRef", 1050429, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_NCRResolutionCode")]
    protected Environment _NCRResolutionCode;
    [Metadata("Preventive action comments.", "NCRPreventiveAction", false, false, true, "NCRPreventiveAction", 1050432, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_PreventiveActionComments")]
    protected NCRPreventiveAction_Environment _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_CrossRefs")]
    [Metadata("The HistoryCrossRef is the means of correlating a single history mainline record (representing a single transaction) to the container(s) to which it applies.  A single transaction applies to multiple containers when it is executed against a container that has child containers ", "HistoryCrossRef", false, false, true, "BaseObjectRef", 1050423, false, true, false, null)]
    protected Environment _CrossRefs;
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050424, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_NCRFailureType")]
    protected Environment _NCRFailureType;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052261, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_EscalationDateGMT")]
    protected Environment _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_CloseDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051455, false, false, false, null)]
    protected Environment _CloseDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050428, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_CloseDate")]
    protected Environment _CloseDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_CreationDateGMT")]
    protected Environment _CreationDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049059, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_CreationDate")]
    protected Environment _CreationDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052260, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_EscalationDate")]
    protected Environment _EscalationDate;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_Container")]
    protected Environment _Container;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_NCRComment")]
    protected Environment _NCRComment;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052262, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_EscalatedBy")]
    protected Environment _EscalatedBy;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050601, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NonconformanceReport_Environment_Name")]
    protected Environment _Name;

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

    public NCRFailureInvestigation_Environment FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (NCRFailureInvestigation_Environment) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public Environment ChildNonconformances
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildNonconformances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildNonconformances));
      }
    }

    public Environment CurrentCrossRefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCrossRefs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentCrossRefs));
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

    public NCRCorrectiveAction_Environment CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (NCRCorrectiveAction_Environment) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Environment NCRStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRStatus));
      }
    }

    public Environment Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Attachments));
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

    public NCRPreventiveAction_Environment PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (NCRPreventiveAction_Environment) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Environment CrossRefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossRefs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CrossRefs));
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

    public Environment CloseDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDateGMT));
      }
    }

    public Environment CloseDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDate));
      }
    }

    public Environment CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Environment CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDate));
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

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
