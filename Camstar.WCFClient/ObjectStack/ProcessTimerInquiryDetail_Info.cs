// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerInquiryDetail_Info
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
  public class ProcessTimerInquiryDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_TimerId")]
    protected Info _TimerId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_CompletionStatus")]
    protected Info _CompletionStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ProcessTimer")]
    protected Info _ProcessTimer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_Timer")]
    protected Info _Timer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MinWarningTime")]
    protected Info _MinWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MaxTimeColor")]
    protected Info _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MinTimeColor")]
    protected Info _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MaxWarningTimeColor")]
    protected Info _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_TimetoMax")]
    protected Info _TimetoMax;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_TimersCount")]
    protected Info _TimersCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MinWarningTimeColor")]
    protected Info _MinWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ActualElapse")]
    protected Info _ActualElapse;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MaxTime")]
    protected Info _MaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MinTime")]
    protected Info _MinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_TimetoMin")]
    protected Info _TimetoMin;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_EndTimeGMT")]
    protected Info _EndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MinEndTimeGMT")]
    protected Info _MinEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MaxEndTimeGMT")]
    protected Info _MaxEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MinEndWarningTimeGMT")]
    protected Info _MinEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MaxEndWarningTimeGMT")]
    protected Info _MaxEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_StartTimeGMT")]
    protected Info _StartTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_MaxWarningTime")]
    protected Info _MaxWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ParentContainer")]
    protected Info _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ProcessTimerName")]
    protected Info _ProcessTimerName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_CompletionStatusName")]
    protected Info _CompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ContainerName")]
    protected Info _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_TimerStartedonSpec")]
    protected Info _TimerStartedonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_SpecName")]
    protected Info _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_TimerEndsonSpec")]
    protected Info _TimerEndsonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ProcessTimerRev")]
    protected Info _ProcessTimerRev;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_SpecRev")]
    protected Info _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Info_ProductRev")]
    protected Info _ProductRev;

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public Info TimerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerId));
      }
    }

    public Info CompletionStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionStatus));
      }
    }

    public Info ProcessTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimer));
      }
    }

    public Info Timer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Timer));
      }
    }

    public Info MinWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinWarningTime));
      }
    }

    public Info MaxTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxTimeColor));
      }
    }

    public Info MinTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinTimeColor));
      }
    }

    public Info MaxWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxWarningTimeColor));
      }
    }

    public Info TimetoMax
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimetoMax), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimetoMax));
      }
    }

    public Info TimersCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimersCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimersCount));
      }
    }

    public Info MinWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinWarningTimeColor));
      }
    }

    public Info ActualElapse
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualElapse), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualElapse));
      }
    }

    public Info MaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxTime));
      }
    }

    public Info MinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinTime));
      }
    }

    public Info TimetoMin
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimetoMin), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimetoMin));
      }
    }

    public Info EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Info MinEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinEndTimeGMT));
      }
    }

    public Info MaxEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxEndTimeGMT));
      }
    }

    public Info MinEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinEndWarningTimeGMT));
      }
    }

    public Info MaxEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxEndWarningTimeGMT));
      }
    }

    public Info StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Info MaxWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxWarningTime));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Info ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerName));
      }
    }

    public Info CompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionStatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionStatusName));
      }
    }

    public Info ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Info TimerStartedonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerStartedonSpec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerStartedonSpec));
      }
    }

    public Info SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecName));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public Info TimerEndsonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerEndsonSpec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerEndsonSpec));
      }
    }

    public Info ProcessTimerRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerRev));
      }
    }

    public Info SpecRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecRev));
      }
    }

    public Info ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRev));
      }
    }
  }
}
