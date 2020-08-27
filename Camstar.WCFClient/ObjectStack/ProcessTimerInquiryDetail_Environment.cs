// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerInquiryDetail_Environment
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
  public class ProcessTimerInquiryDetail_Environment : ServiceData_Environment
  {
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_Spec")]
    protected Environment _Spec;
    [Metadata("ProgID", "", false, false, false, "String", 16778709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_TimerId")]
    protected Environment _TimerId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_CompletionStatus")]
    [Metadata("TimerCompletionStatus", "TimerCompletionStatusEnum", false, false, false, "Integer", 16778676, false, false, false, null)]
    protected Environment _CompletionStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ProcessTimer")]
    [Metadata("Process Timer", "ProcessTimer", false, false, false, "RevisionedObjectRef", 16778353, false, false, false, null)]
    protected Environment _ProcessTimer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_Timer")]
    [Metadata("Timer", "Timer", false, false, false, "SubentityRef", 16778381, false, false, false, null)]
    protected Environment _Timer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MinWarningTime")]
    [Metadata("Generic String", "", false, false, false, "String", 16778359, false, false, false, null)]
    protected Environment _MinWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MaxTimeColor")]
    [Metadata("Generic String", "", false, false, false, "String", 16778366, false, false, false, null)]
    protected Environment _MaxTimeColor;
    [Metadata("Generic String", "", false, false, false, "String", 16778364, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MinTimeColor")]
    protected Environment _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MaxWarningTimeColor")]
    [Metadata("Generic String", "", false, false, false, "String", 16778365, false, false, false, null)]
    protected Environment _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_TimetoMax")]
    [Metadata("Generic String", "", false, false, true, "String", 16778679, false, false, false, null)]
    protected Environment _TimetoMax;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778740, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_TimersCount")]
    protected Environment _TimersCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MinWarningTimeColor")]
    [Metadata("Generic String", "", false, false, false, "String", 16778363, false, false, false, null)]
    protected Environment _MinWarningTimeColor;
    [Metadata("Generic String", "", false, false, true, "String", 16778675, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ActualElapse")]
    protected Environment _ActualElapse;
    [Metadata("Generic String", "", false, false, true, "String", 16778362, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MaxTime")]
    protected Environment _MaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MinTime")]
    [Metadata("Generic String", "", false, false, true, "String", 16778360, false, false, false, null)]
    protected Environment _MinTime;
    [Metadata("Generic String", "", false, false, true, "String", 16778680, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_TimetoMin")]
    protected Environment _TimetoMin;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778677, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_EndTimeGMT")]
    protected Environment _EndTimeGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778738, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MinEndTimeGMT")]
    protected Environment _MinEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MaxEndTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778739, false, false, false, null)]
    protected Environment _MaxEndTimeGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778626, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MinEndWarningTimeGMT")]
    protected Environment _MinEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MaxEndWarningTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778624, false, false, false, null)]
    protected Environment _MaxEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_StartTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778678, false, false, false, null)]
    protected Environment _StartTimeGMT;
    [Metadata("Generic String", "", false, false, false, "String", 16778361, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_MaxWarningTime")]
    protected Environment _MaxWarningTime;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_Container")]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ParentContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049070, false, false, false, null)]
    protected Environment _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ProcessTimerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778357, false, false, false, null)]
    protected Environment _ProcessTimerName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778676, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_CompletionStatusName")]
    protected Environment _CompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ContainerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049088, false, false, false, null)]
    protected Environment _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_TimerStartedonSpec")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778767, false, false, false, null)]
    protected Environment _TimerStartedonSpec;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050232, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_SpecName")]
    protected Environment _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048709, false, false, false, null)]
    protected Environment _ProductName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778768, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_TimerEndsonSpec")]
    protected Environment _TimerEndsonSpec;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 16778710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ProcessTimerRev")]
    protected Environment _ProcessTimerRev;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_SpecRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1049578, false, false, false, null)]
    protected Environment _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Environment_ProductRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1049573, false, false, false, null)]
    protected Environment _ProductRev;

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public Environment TimerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimerId));
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

    public Environment ProcessTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimer));
      }
    }

    public Environment Timer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Timer));
      }
    }

    public Environment MinWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinWarningTime));
      }
    }

    public Environment MaxTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxTimeColor));
      }
    }

    public Environment MinTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinTimeColor));
      }
    }

    public Environment MaxWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxWarningTimeColor));
      }
    }

    public Environment TimetoMax
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimetoMax), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimetoMax));
      }
    }

    public Environment TimersCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimersCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimersCount));
      }
    }

    public Environment MinWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinWarningTimeColor));
      }
    }

    public Environment ActualElapse
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualElapse), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualElapse));
      }
    }

    public Environment MaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxTime));
      }
    }

    public Environment MinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinTime));
      }
    }

    public Environment TimetoMin
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimetoMin), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimetoMin));
      }
    }

    public Environment EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Environment MinEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinEndTimeGMT));
      }
    }

    public Environment MaxEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxEndTimeGMT));
      }
    }

    public Environment MinEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinEndWarningTimeGMT));
      }
    }

    public Environment MaxEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxEndWarningTimeGMT));
      }
    }

    public Environment StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Environment MaxWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxWarningTime));
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

    public Environment ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Environment ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerName));
      }
    }

    public Environment CompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionStatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionStatusName));
      }
    }

    public Environment ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerName));
      }
    }

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

    public Environment SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecName));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }

    public Environment ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductName));
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

    public Environment ProcessTimerRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerRev));
      }
    }

    public Environment SpecRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecRev));
      }
    }

    public Environment ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductRev));
      }
    }
  }
}
