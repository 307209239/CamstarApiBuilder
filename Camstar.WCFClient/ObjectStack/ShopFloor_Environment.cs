// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShopFloor_Environment
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
  public class ShopFloor_Environment : Update_Environment
  {
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendar", false, false, false, "NamedObjectRef", 1049935, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_MfgCalendar")]
    protected Environment _MfgCalendar;
    [Metadata("When printing labels, the information needed to print as well as the values (details) are resolved and kept here for use later.", "LabelSummary", false, false, true, "LabelSummary", 1050622, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_LabelSummaries")]
    protected LabelSummary_Environment _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_WIPMsgMgr")]
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgr", false, false, false, "WIPMsgMgr", 1048865, true, false, false, null)]
    protected new WIPMsgMgr_Environment _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, false, null)]
    protected Environment _DataCollectionDef;
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1049965, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ParametricDataControl")]
    protected Environment _ParametricDataControl;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ESigRequirement")]
    protected Environment _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_TrainingRequirements")]
    [Metadata("Definition of the training required before a user is allowed to perform a specific task", "TrainingRequirement", false, false, true, "RevisionedObjectRef", 1050490, false, true, false, null)]
    protected Environment _TrainingRequirements;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_DispatchRule")]
    [Metadata("Definition of the prioritization rules for the order that material is processed on the shop floor.  A dispatch rule can contain separate details for different types of transactions.", "DispatchRule", false, false, true, "NamedObjectRef", 1050380, false, false, false, null)]
    protected Environment _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_CalledByTransactionTask")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, false, "NamedSubentityRef", 1052669, false, false, false, null)]
    protected Environment _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, true, "NamedObjectRef", 1050609, false, false, true, null)]
    protected Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_AdditionalESigReqs")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1051894, false, true, false, null)]
    protected Environment _AdditionalESigReqs;
    [Metadata("Parametric data", "ParametricData", false, false, false, "ParametricData", 1048871, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ParametricData")]
    protected ParametricData_Environment _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ComputationDetail")]
    [Metadata("Details of the Computation", "ComputationDetail", false, false, false, "ComputationDetail", 1051024, false, false, false, null)]
    protected ComputationDetail_Environment _ComputationDetail;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ESigDetails")]
    [Metadata("The ESigReqDetail used to fulfill all or part of an ESigRequirement.", "ESigServiceDetail", false, false, false, "ESigServiceDetail", 1050389, false, true, false, null)]
    protected ESigServiceDetail_Environment _ESigDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_MfgProcessOverrides")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, false, null)]
    protected new Environment _MfgProcessOverrides;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_SamplingPlan")]
    protected Environment _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ActionSource")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1052924, false, false, false, null)]
    protected Environment _ActionSource;
    [Metadata("The specific describes the details for a Sampling Plan's Sample Test..  For each  Sample Test, the AQL Level, Inspection Level, Switching Rule, Spec, Vendor and Resoruce can be configured.", "SamplingPlanDetails", false, false, false, "SubentityRef", 1053137, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_SamplingPlanDetails")]
    protected Environment _SamplingPlanDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_WebPart")]
    [Metadata("A web part is a piece of a web page that performs a specific function, but is not intended to run as a page on its own", "WebPart", false, false, true, "NamedObjectRef", 1052990, false, false, false, null)]
    protected Environment _WebPart;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ActionDetails")]
    [Metadata("List of actions. It's built based on the ActionType field.", "ActionDetails", false, false, true, "ActionDetails", 1052693, false, true, false, null)]
    protected ActionDetails_Environment _ActionDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049887, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_IsRemoteService")]
    protected new Environment _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ParametricDataDefType")]
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1049016, false, false, false, null)]
    protected Environment _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ProcessESignatures")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    protected Environment _ProcessESignatures;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050765, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ProcessMaintMgmt")]
    protected Environment _ProcessMaintMgmt;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_HasUserDataCollection")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050869, false, false, false, "0")]
    protected Environment _HasUserDataCollection;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050795, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ProcessTrainingReqs")]
    protected Environment _ProcessTrainingReqs;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050794, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ProcessNCRs")]
    protected Environment _ProcessNCRs;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_EnforceDispatch")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050379, false, false, false, "1")]
    protected Environment _EnforceDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ProcessEProcedures")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050796, false, false, false, "1")]
    protected Environment _ProcessEProcedures;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_HasDataCollection")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053043, false, false, false, "0")]
    protected Environment _HasDataCollection;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1052671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_TaskContainer")]
    protected Environment _TaskContainer;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050386, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_UseDispatch")]
    protected Environment _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_ProcessMasterRecipe")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051891, false, false, false, "1")]
    protected Environment _ProcessMasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_PrintLabels")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050625, false, false, false, "1")]
    protected Environment _PrintLabels;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052961, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_HasDPCollection")]
    protected Environment _HasDPCollection;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_Factory")]
    protected new Environment _Factory;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1053145, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_SampleQty")]
    protected Environment _SampleQty;
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Environment_MfgOrder")]
    protected Environment _MfgOrder;

    public Environment MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public LabelSummary_Environment LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (LabelSummary_Environment) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public new WIPMsgMgr_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Environment ParametricDataControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataControl));
      }
    }

    public Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment TrainingRequirements
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirements), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingRequirements));
      }
    }

    public Environment DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public Environment CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public Environment PrintQueue
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

    public Environment AdditionalESigReqs
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdditionalESigReqs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdditionalESigReqs));
      }
    }

    public ParametricData_Environment ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData_Environment) this.PropertyGet(nameof (ParametricData));
      }
    }

    public ComputationDetail_Environment ComputationDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationDetail), (object) value);
      }
      get
      {
        return (ComputationDetail_Environment) this.PropertyGet(nameof (ComputationDetail));
      }
    }

    public ESigServiceDetail_Environment ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigServiceDetail_Environment) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public new Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public Environment SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Environment ActionSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionSource));
      }
    }

    public Environment SamplingPlanDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlanDetails));
      }
    }

    public Environment WebPart
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebPart), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WebPart));
      }
    }

    public ActionDetails_Environment ActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionDetails), (object) value);
      }
      get
      {
        return (ActionDetails_Environment) this.PropertyGet(nameof (ActionDetails));
      }
    }

    public new Environment IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Environment ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Environment ProcessMaintMgmt
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessMaintMgmt), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessMaintMgmt));
      }
    }

    public Environment HasUserDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasUserDataCollection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasUserDataCollection));
      }
    }

    public Environment ProcessTrainingReqs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTrainingReqs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTrainingReqs));
      }
    }

    public Environment ProcessNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessNCRs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessNCRs));
      }
    }

    public Environment EnforceDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforceDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EnforceDispatch));
      }
    }

    public Environment ProcessEProcedures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessEProcedures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessEProcedures));
      }
    }

    public Environment HasDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasDataCollection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasDataCollection));
      }
    }

    public Environment TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public Environment UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Environment ProcessMasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessMasterRecipe), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessMasterRecipe));
      }
    }

    public Environment PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public Environment HasDPCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasDPCollection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HasDPCollection));
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

    public Environment SampleQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleQty));
      }
    }

    public Environment MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
