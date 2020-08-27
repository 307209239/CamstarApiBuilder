// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerInquiryDetail
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
  public class ProcessTimerInquiryDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_TimerId")]
    protected Primitive<string> _TimerId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_CompletionStatus")]
    protected Enumeration<TimerCompletionStatusEnum, int> _CompletionStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ProcessTimer")]
    protected RevisionedObjectRef _ProcessTimer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Timer")]
    protected SubentityRef _Timer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MinWarningTime")]
    protected Primitive<string> _MinWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MaxTimeColor")]
    protected Primitive<string> _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MinTimeColor")]
    protected Primitive<string> _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MaxWarningTimeColor")]
    protected Primitive<string> _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_TimetoMax")]
    protected Primitive<string> _TimetoMax;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_TimersCount")]
    protected Primitive<int> _TimersCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MinWarningTimeColor")]
    protected Primitive<string> _MinWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ActualElapse")]
    protected Primitive<string> _ActualElapse;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MaxTime")]
    protected Primitive<string> _MaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MinTime")]
    protected Primitive<string> _MinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_TimetoMin")]
    protected Primitive<string> _TimetoMin;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_EndTimeGMT")]
    protected Primitive<DateTime> _EndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MinEndTimeGMT")]
    protected Primitive<DateTime> _MinEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MaxEndTimeGMT")]
    protected Primitive<DateTime> _MaxEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MinEndWarningTimeGMT")]
    protected Primitive<DateTime> _MinEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MaxEndWarningTimeGMT")]
    protected Primitive<DateTime> _MaxEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_StartTimeGMT")]
    protected Primitive<DateTime> _StartTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_MaxWarningTime")]
    protected Primitive<string> _MaxWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ParentContainer")]
    protected ContainerRef _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ProcessTimerName")]
    protected Primitive<string> _ProcessTimerName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_CompletionStatusName")]
    protected Primitive<string> _CompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ContainerName")]
    protected Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_TimerStartedonSpec")]
    protected Primitive<string> _TimerStartedonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_SpecName")]
    protected Primitive<string> _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_TimerEndsonSpec")]
    protected Primitive<string> _TimerEndsonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ProcessTimerRev")]
    protected Primitive<string> _ProcessTimerRev;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_SpecRev")]
    protected Primitive<string> _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiryDetail_ProductRev")]
    protected Primitive<string> _ProductRev;

    public override bool Equals(object obj)
    {
      return obj is ProcessTimerInquiryDetail && object.Equals((object) this._Spec, (object) ((ProcessTimerInquiryDetail) obj)._Spec) && (object.Equals((object) this._TimerId, (object) ((ProcessTimerInquiryDetail) obj)._TimerId) && object.Equals((object) this._CompletionStatus, (object) ((ProcessTimerInquiryDetail) obj)._CompletionStatus)) && (object.Equals((object) this._ProcessTimer, (object) ((ProcessTimerInquiryDetail) obj)._ProcessTimer) && object.Equals((object) this._Timer, (object) ((ProcessTimerInquiryDetail) obj)._Timer) && (object.Equals((object) this._MinWarningTime, (object) ((ProcessTimerInquiryDetail) obj)._MinWarningTime) && object.Equals((object) this._MaxTimeColor, (object) ((ProcessTimerInquiryDetail) obj)._MaxTimeColor))) && (object.Equals((object) this._MinTimeColor, (object) ((ProcessTimerInquiryDetail) obj)._MinTimeColor) && object.Equals((object) this._MaxWarningTimeColor, (object) ((ProcessTimerInquiryDetail) obj)._MaxWarningTimeColor) && (object.Equals((object) this._TimetoMax, (object) ((ProcessTimerInquiryDetail) obj)._TimetoMax) && object.Equals((object) this._TimersCount, (object) ((ProcessTimerInquiryDetail) obj)._TimersCount)) && (object.Equals((object) this._MinWarningTimeColor, (object) ((ProcessTimerInquiryDetail) obj)._MinWarningTimeColor) && object.Equals((object) this._ActualElapse, (object) ((ProcessTimerInquiryDetail) obj)._ActualElapse) && (object.Equals((object) this._MaxTime, (object) ((ProcessTimerInquiryDetail) obj)._MaxTime) && object.Equals((object) this._MinTime, (object) ((ProcessTimerInquiryDetail) obj)._MinTime)))) && (object.Equals((object) this._TimetoMin, (object) ((ProcessTimerInquiryDetail) obj)._TimetoMin) && object.Equals((object) this._EndTimeGMT, (object) ((ProcessTimerInquiryDetail) obj)._EndTimeGMT) && (object.Equals((object) this._MinEndTimeGMT, (object) ((ProcessTimerInquiryDetail) obj)._MinEndTimeGMT) && object.Equals((object) this._MaxEndTimeGMT, (object) ((ProcessTimerInquiryDetail) obj)._MaxEndTimeGMT)) && (object.Equals((object) this._MinEndWarningTimeGMT, (object) ((ProcessTimerInquiryDetail) obj)._MinEndWarningTimeGMT) && object.Equals((object) this._MaxEndWarningTimeGMT, (object) ((ProcessTimerInquiryDetail) obj)._MaxEndWarningTimeGMT) && (object.Equals((object) this._StartTimeGMT, (object) ((ProcessTimerInquiryDetail) obj)._StartTimeGMT) && object.Equals((object) this._MaxWarningTime, (object) ((ProcessTimerInquiryDetail) obj)._MaxWarningTime))) && (object.Equals((object) this._Container, (object) ((ProcessTimerInquiryDetail) obj)._Container) && object.Equals((object) this._ParentContainer, (object) ((ProcessTimerInquiryDetail) obj)._ParentContainer) && (object.Equals((object) this._ProcessTimerName, (object) ((ProcessTimerInquiryDetail) obj)._ProcessTimerName) && object.Equals((object) this._CompletionStatusName, (object) ((ProcessTimerInquiryDetail) obj)._CompletionStatusName)) && (object.Equals((object) this._ContainerName, (object) ((ProcessTimerInquiryDetail) obj)._ContainerName) && object.Equals((object) this._TimerStartedonSpec, (object) ((ProcessTimerInquiryDetail) obj)._TimerStartedonSpec) && (object.Equals((object) this._SpecName, (object) ((ProcessTimerInquiryDetail) obj)._SpecName) && object.Equals((object) this._Product, (object) ((ProcessTimerInquiryDetail) obj)._Product))))) && (object.Equals((object) this._ProductName, (object) ((ProcessTimerInquiryDetail) obj)._ProductName) && object.Equals((object) this._TimerEndsonSpec, (object) ((ProcessTimerInquiryDetail) obj)._TimerEndsonSpec) && (object.Equals((object) this._ProcessTimerRev, (object) ((ProcessTimerInquiryDetail) obj)._ProcessTimerRev) && object.Equals((object) this._SpecRev, (object) ((ProcessTimerInquiryDetail) obj)._SpecRev)) && object.Equals((object) this._ProductRev, (object) ((ProcessTimerInquiryDetail) obj)._ProductRev)) && base.Equals(obj);
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public Primitive<string> TimerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimerId));
      }
    }

    public Enumeration<TimerCompletionStatusEnum, int> CompletionStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionStatus), (object) value);
      }
      get
      {
        return (Enumeration<TimerCompletionStatusEnum, int>) this.PropertyGet(nameof (CompletionStatus));
      }
    }

    public RevisionedObjectRef ProcessTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimer), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessTimer));
      }
    }

    public SubentityRef Timer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timer), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (Timer));
      }
    }

    public Primitive<string> MinWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTime), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MinWarningTime));
      }
    }

    public Primitive<string> MaxTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaxTimeColor));
      }
    }

    public Primitive<string> MinTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MinTimeColor));
      }
    }

    public Primitive<string> MaxWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaxWarningTimeColor));
      }
    }

    public Primitive<string> TimetoMax
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimetoMax), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimetoMax));
      }
    }

    public Primitive<int> TimersCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimersCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TimersCount));
      }
    }

    public Primitive<string> MinWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MinWarningTimeColor));
      }
    }

    public Primitive<string> ActualElapse
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualElapse), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ActualElapse));
      }
    }

    public Primitive<string> MaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTime), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaxTime));
      }
    }

    public Primitive<string> MinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTime), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MinTime));
      }
    }

    public Primitive<string> TimetoMin
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimetoMin), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimetoMin));
      }
    }

    public Primitive<DateTime> EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Primitive<DateTime> MinEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MinEndTimeGMT));
      }
    }

    public Primitive<DateTime> MaxEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MaxEndTimeGMT));
      }
    }

    public Primitive<DateTime> MinEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MinEndWarningTimeGMT));
      }
    }

    public Primitive<DateTime> MaxEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MaxEndWarningTimeGMT));
      }
    }

    public Primitive<DateTime> StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Primitive<string> MaxWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTime), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaxWarningTime));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public ContainerRef ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Primitive<string> ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessTimerName));
      }
    }

    public Primitive<string> CompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionStatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CompletionStatusName));
      }
    }

    public Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Primitive<string> TimerStartedonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerStartedonSpec), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimerStartedonSpec));
      }
    }

    public Primitive<string> SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecName));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public Primitive<string> TimerEndsonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerEndsonSpec), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimerEndsonSpec));
      }
    }

    public Primitive<string> ProcessTimerRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessTimerRev));
      }
    }

    public Primitive<string> SpecRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecRev));
      }
    }

    public Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
      }
    }
  }
}
