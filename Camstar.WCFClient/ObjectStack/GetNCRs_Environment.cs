// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetNCRs_Environment
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
  public class GetNCRs_Environment : Inquiry_Environment
  {
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, false, "NonconformanceReport", 1050602, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_NonconformanceReports")]
    protected NonconformanceReport_Environment _NonconformanceReports;
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, false, "NamedObjectRef", 1050497, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_NCRFailureCode")]
    protected Environment _NCRFailureCode;
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, false, "NamedObjectRef", 1050939, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_NonconformanceReport")]
    protected Environment _NonconformanceReport;
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050468, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_CreateDateEnd")]
    protected Environment _CreateDateEnd;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_IncludeClosedNCRs")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050469, false, false, false, "0")]
    protected Environment _IncludeClosedNCRs;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_CreateDateBegin")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050467, false, false, false, null)]
    protected Environment _CreateDateBegin;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_Container")]
    protected Environment _Container;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_Operation")]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_Workcenter")]
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, true, null)]
    protected Environment _Workcenter;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1050500, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Environment_ChargeToWorkflow")]
    protected Environment _ChargeToWorkflow;

    public NonconformanceReport_Environment NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (NonconformanceReport_Environment) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public Environment NCRFailureCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRFailureCode));
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

    public Environment CreateDateEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateEnd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreateDateEnd));
      }
    }

    public Environment IncludeClosedNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeClosedNCRs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeClosedNCRs));
      }
    }

    public Environment CreateDateBegin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateBegin), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreateDateBegin));
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

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment Workcenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workcenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workcenter));
      }
    }

    public Environment ChargeToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChargeToWorkflow));
      }
    }
  }
}
