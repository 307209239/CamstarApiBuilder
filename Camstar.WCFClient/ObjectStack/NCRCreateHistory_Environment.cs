// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCreateHistory_Environment
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
  public class NCRCreateHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_RelatedNonconformance")]
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050603, false, false, false, null)]
    protected Environment _RelatedNonconformance;
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, true, "NamedSubentityRef", 1050503, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_Task")]
    protected Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_HistoryDetails")]
    [Metadata("NCR defect history details.", "NCRDefectHistoryDetails", false, false, false, "NCRDefectHistoryDetails", 1049096, false, true, false, null)]
    protected NCRDefectHistoryDetails_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, true, "NamedObjectRef", 1050439, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_NCRFailureCodes")]
    protected Environment _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_NCRFailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050424, false, false, false, null)]
    protected Environment _NCRFailureType;
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1049822, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreateHistory_Environment_NCRComment")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050444, false, false, false, null)]
    protected Environment _NCRComment;

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

    public NCRDefectHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
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
  }
}
