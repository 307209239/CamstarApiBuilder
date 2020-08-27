// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCViolationDetail_Environment
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
  public class SPCViolationDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("The history of the DataPoints collected for a DataPointCollectionDef.", "DataPointHistoryDetail", false, false, false, "SubentityRef", 1050537, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_DataPoint")]
    protected Environment _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_RuleViolated")]
    [Metadata("Comments", "", false, false, false, "String", 1052636, false, false, false, null)]
    protected Environment _RuleViolated;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_CustomSPCDataId")]
    [Metadata("Comments", "", false, false, false, "String", 1053051, false, false, false, null)]
    protected Environment _CustomSPCDataId;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_ViolationName")]
    [Metadata("DisplayName", "", false, false, false, "String", 1053031, false, false, false, null)]
    protected Environment _ViolationName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_HoldReason")]
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048800, false, false, false, null)]
    protected Environment _HoldReason;
    [Metadata("Generic String", "", false, false, false, "String", 1052632, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_CollectedDataValue")]
    protected Environment _CollectedDataValue;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("Generic String", "", false, false, false, "String", 1052633, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_DerivedChartDataValue")]
    protected Environment _DerivedChartDataValue;
    [Metadata("Generic Float", "", false, false, false, "Float", 1052634, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_LCL")]
    protected Environment _LCL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_UCL")]
    [Metadata("Generic Float", "", false, false, false, "Float", 1052638, false, false, false, null)]
    protected Environment _UCL;
    [Metadata("Generic String", "", false, false, false, "String", 1052630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_ChartVariable")]
    protected Environment _ChartVariable;
    [Metadata("Generic String", "", false, false, false, "String", 1052635, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_ParametricDataID")]
    protected Environment _ParametricDataID;
    [Metadata("Generic Float", "", false, false, false, "Float", 1052631, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_CL")]
    protected Environment _CL;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_Resource")]
    protected Environment _Resource;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050528, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_DataPointName")]
    protected Environment _DataPointName;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052998, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_FailureAction")]
    protected Environment _FailureAction;
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1049247, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Environment_ResourceStatusCode")]
    protected Environment _ResourceStatusCode;

    public Environment DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Environment RuleViolated
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleViolated), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RuleViolated));
      }
    }

    public Environment CustomSPCDataId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomSPCDataId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomSPCDataId));
      }
    }

    public Environment ViolationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ViolationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ViolationName));
      }
    }

    public Environment HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Environment CollectedDataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectedDataValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollectedDataValue));
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

    public Environment DerivedChartDataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DerivedChartDataValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DerivedChartDataValue));
      }
    }

    public Environment LCL
    {
      [param: In] set
      {
        this.PropertySet(nameof (LCL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LCL));
      }
    }

    public Environment UCL
    {
      [param: In] set
      {
        this.PropertySet(nameof (UCL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UCL));
      }
    }

    public Environment ChartVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartVariable), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChartVariable));
      }
    }

    public Environment ParametricDataID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataID));
      }
    }

    public Environment CL
    {
      [param: In] set
      {
        this.PropertySet(nameof (CL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CL));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public Environment DataPointName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointName));
      }
    }

    public Environment FailureAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureAction));
      }
    }

    public Environment ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }
  }
}
