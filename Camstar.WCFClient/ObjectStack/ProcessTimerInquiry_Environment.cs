// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerInquiry_Environment
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
  public class ProcessTimerInquiry_Environment : Inquiry_Environment
  {
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 16778767, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_TimerStartedonSpec")]
    protected Environment _TimerStartedonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_SpecFilter")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    protected Environment _SpecFilter;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 16778768, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_TimerEndsonSpec")]
    protected Environment _TimerEndsonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_EndsonSpecTimerDetails")]
    [Metadata("Process Timer Inquiry Details", "ProcessTimerInquiryDetail", false, false, false, "ProcessTimerInquiryDetail", 16778808, false, true, false, null)]
    protected ProcessTimerInquiryDetail_Environment _EndsonSpecTimerDetails;
    [Metadata("TimerCompletionStatus", "TimerCompletionStatusEnum", false, false, false, "Integer", 16778676, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_CompletionStatus")]
    protected Environment _CompletionStatus;
    [Metadata("Process Timer Inquiry Details", "ProcessTimerInquiryDetail", false, false, false, "ProcessTimerInquiryDetail", 16778684, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_ProcessTimerDetails")]
    protected ProcessTimerInquiryDetail_Environment _ProcessTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_CurrentStatus")]
    [Metadata("TimerCurrentStatus", "TimerCurrentStatusEnum", false, false, false, "Integer", 1048786, false, false, true, null)]
    protected Environment _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_StartedTimerDetails")]
    [Metadata("Process Timer Inquiry Details", "ProcessTimerInquiryDetail", false, false, false, "ProcessTimerInquiryDetail", 16778809, false, true, false, null)]
    protected ProcessTimerInquiryDetail_Environment _StartedTimerDetails;
    [Metadata("Process Timer Type", "ProcessTimerType", false, false, false, "NamedObjectRef", 16778349, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_ProcessTimerTypeFilter")]
    protected Environment _ProcessTimerTypeFilter;
    [Metadata("Process Timer Inquiry Details", "ProcessTimerInquiryDetail", false, false, false, "ProcessTimerInquiryDetail", 16778807, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_EndedTimerDetails")]
    protected ProcessTimerInquiryDetail_Environment _EndedTimerDetails;
    [Metadata("Process Timer", "ProcessTimer", false, false, false, "RevisionedObjectRef", 16778353, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_ProcessTimerFilter")]
    protected Environment _ProcessTimerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_EndTimerBeginGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778682, false, false, false, null)]
    protected Environment _EndTimerBeginGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778683, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_EndTimerEndGMT")]
    protected Environment _EndTimerEndGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778686, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_StartTimerBeginGMT")]
    protected Environment _StartTimerBeginGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_StartTimerEndGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778687, false, false, false, null)]
    protected Environment _StartTimerEndGMT;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778685, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_ShowTimers")]
    protected Environment _ShowTimers;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_ProductFilter")]
    protected Environment _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_ContainerFilter")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049043, false, false, false, null)]
    protected Environment _ContainerFilter;
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Environment_MfgOrderFilter")]
    protected Environment _MfgOrderFilter;

    public Environment TimerStartedonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerStartedonSpec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimerStartedonSpec));
      }
    }

    public Environment SpecFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecFilter));
      }
    }

    public Environment TimerEndsonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerEndsonSpec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimerEndsonSpec));
      }
    }

    public ProcessTimerInquiryDetail_Environment EndsonSpecTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndsonSpecTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Environment) this.PropertyGet(nameof (EndsonSpecTimerDetails));
      }
    }

    public Environment CompletionStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionStatus));
      }
    }

    public ProcessTimerInquiryDetail_Environment ProcessTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Environment) this.PropertyGet(nameof (ProcessTimerDetails));
      }
    }

    public Environment CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public ProcessTimerInquiryDetail_Environment StartedTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartedTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Environment) this.PropertyGet(nameof (StartedTimerDetails));
      }
    }

    public Environment ProcessTimerTypeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerTypeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerTypeFilter));
      }
    }

    public ProcessTimerInquiryDetail_Environment EndedTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndedTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Environment) this.PropertyGet(nameof (EndedTimerDetails));
      }
    }

    public Environment ProcessTimerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerFilter));
      }
    }

    public Environment EndTimerBeginGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerBeginGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimerBeginGMT));
      }
    }

    public Environment EndTimerEndGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerEndGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimerEndGMT));
      }
    }

    public Environment StartTimerBeginGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerBeginGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartTimerBeginGMT));
      }
    }

    public Environment StartTimerEndGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerEndGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartTimerEndGMT));
      }
    }

    public Environment ShowTimers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTimers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowTimers));
      }
    }

    public Environment ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public Environment ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public Environment MfgOrderFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrderFilter));
      }
    }
  }
}
