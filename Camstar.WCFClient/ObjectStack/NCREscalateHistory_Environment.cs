// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCREscalateHistory_Environment
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
  public class NCREscalateHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, true, "NamedObjectRef", 1052264, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_NCRFailureCodes")]
    protected Environment _NCRFailureCodes;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_EscalatedEvent")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1052259, false, false, false, null)]
    protected Environment _EscalatedEvent;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_NCRResolutionCode")]
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, true, "NamedObjectRef", 1052263, false, false, false, null)]
    protected Environment _NCRResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_NCRComment")]
    [Metadata("Comments", "", false, false, true, "String", 1050444, false, false, false, null)]
    protected Environment _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051298, false, false, false, null)]
    protected Environment _QualityObject;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050939, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_NonconformanceReport")]
    protected Environment _NonconformanceReport;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1052091, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_NCRCauseCode")]
    protected Environment _NCRCauseCode;
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1049822, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, true, "NamedObjectRef", 1051051, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_PriorityLevel")]
    protected Environment _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, false, false, null)]
    protected Environment _Organization;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, true, "NamedObjectRef", 1052104, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_SubClassification")]
    protected Environment _SubClassification;
    [Metadata("Used to classify QualityObjects", "Classification", false, false, true, "NamedObjectRef", 1051055, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_Classification")]
    protected Environment _Classification;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052261, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_EscalationDateGMT")]
    protected Environment _EscalationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_EscalationDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052260, false, false, false, null)]
    protected Environment _EscalationDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052262, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalateHistory_Environment_EscalatedBy")]
    protected Environment _EscalatedBy;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NonconformanceReport));
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

    public Environment PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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
