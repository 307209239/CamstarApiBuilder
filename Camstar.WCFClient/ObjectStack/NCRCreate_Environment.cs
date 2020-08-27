// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCreate_Environment
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
  public class NCRCreate_Environment : NCRTxn_Environment
  {
    [Metadata("This ServiceDetails object records failure defect data for a Nonconformance.  This information is recorded historically.  If an ActualComponentIssue value is assigned, then the Container, Lot, Product and ReferenceDesignator all default to the values in that history.  These values can be overridden by the client.", "NCRDefectDetails", false, false, false, "NCRDefectDetails", 1050451, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_ServiceDetails")]
    protected NCRDefectDetails_Environment _ServiceDetails;
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_NCRFailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, false, "NamedObjectRef", 1050450, false, false, true, null)]
    protected Environment _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_NCRFailureCodeGroup")]
    [Metadata("A User Code Object Group that represents a group of NCRFailureCodes.", "NCRFailureCodeGroup", false, false, false, "NamedObjectRef", 1050446, false, false, true, null)]
    protected Environment _NCRFailureCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_Task")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, false, "NamedSubentityRef", 1050503, false, false, true, null)]
    protected Environment _Task;
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, false, "NamedObjectRef", 1050601, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_NonconformanceReport")]
    protected new Environment _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_NCRFailureCodes")]
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, true, false, "NamedObjectRef", 1050449, false, true, true, null)]
    protected Environment _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_RelatedNonconformance")]
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, false, "NamedObjectRef", 1050603, false, false, false, null)]
    protected Environment _RelatedNonconformance;
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_PrintQueue")]
    protected new Environment _PrintQueue;
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, true, "IssueActualsHistory", 1049663, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_IssueActualsHistory")]
    protected IssueActualsHistory_Environment _IssueActualsHistory;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_Container")]
    protected Environment _Container;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_Factory")]
    protected new Environment _Factory;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1049480, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_NCRComment")]
    protected Environment _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Environment_NonconformanceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050601, false, false, false, null)]
    protected Environment _NonconformanceName;

    public NCRDefectDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (NCRDefectDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
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

    public new Environment NonconformanceReport
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

    public new Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public IssueActualsHistory_Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (IssueActualsHistory));
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

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
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

    public Environment NonconformanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NonconformanceName));
      }
    }
  }
}
