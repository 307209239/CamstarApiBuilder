// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerInquiry
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
  public class ProcessTimerInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_TimerStartedonSpec")]
    protected RevisionedObjectRef _TimerStartedonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_SpecFilter")]
    protected RevisionedObjectRef _SpecFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_TimerEndsonSpec")]
    protected RevisionedObjectRef _TimerEndsonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_EndsonSpecTimerDetails")]
    protected ProcessTimerInquiryDetail[] _EndsonSpecTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_CompletionStatus")]
    protected Enumeration<TimerCompletionStatusEnum, int> _CompletionStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_ProcessTimerDetails")]
    protected ProcessTimerInquiryDetail[] _ProcessTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_CurrentStatus")]
    protected Enumeration<TimerCurrentStatusEnum, int> _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_StartedTimerDetails")]
    protected ProcessTimerInquiryDetail[] _StartedTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_ProcessTimerTypeFilter")]
    protected NamedObjectRef _ProcessTimerTypeFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_EndedTimerDetails")]
    protected ProcessTimerInquiryDetail[] _EndedTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_ProcessTimerFilter")]
    protected RevisionedObjectRef _ProcessTimerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_EndTimerBeginGMT")]
    protected Primitive<DateTime> _EndTimerBeginGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_EndTimerEndGMT")]
    protected Primitive<DateTime> _EndTimerEndGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_StartTimerBeginGMT")]
    protected Primitive<DateTime> _StartTimerBeginGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_StartTimerEndGMT")]
    protected Primitive<DateTime> _StartTimerEndGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_ShowTimers")]
    protected Primitive<int> _ShowTimers;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_ProductFilter")]
    protected RevisionedObjectRef _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_ContainerFilter")]
    protected Primitive<string> _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_MfgOrderFilter")]
    protected NamedObjectRef _MfgOrderFilter;

    public override bool Equals(object obj)
    {
      return obj is ProcessTimerInquiry && object.Equals((object) this._TimerStartedonSpec, (object) ((ProcessTimerInquiry) obj)._TimerStartedonSpec) && (object.Equals((object) this._SpecFilter, (object) ((ProcessTimerInquiry) obj)._SpecFilter) && object.Equals((object) this._TimerEndsonSpec, (object) ((ProcessTimerInquiry) obj)._TimerEndsonSpec)) && (this.CompareArrays((Array) this._EndsonSpecTimerDetails, (Array) ((ProcessTimerInquiry) obj)._EndsonSpecTimerDetails) && object.Equals((object) this._CompletionStatus, (object) ((ProcessTimerInquiry) obj)._CompletionStatus) && (this.CompareArrays((Array) this._ProcessTimerDetails, (Array) ((ProcessTimerInquiry) obj)._ProcessTimerDetails) && object.Equals((object) this._CurrentStatus, (object) ((ProcessTimerInquiry) obj)._CurrentStatus))) && (this.CompareArrays((Array) this._StartedTimerDetails, (Array) ((ProcessTimerInquiry) obj)._StartedTimerDetails) && object.Equals((object) this._ProcessTimerTypeFilter, (object) ((ProcessTimerInquiry) obj)._ProcessTimerTypeFilter) && (this.CompareArrays((Array) this._EndedTimerDetails, (Array) ((ProcessTimerInquiry) obj)._EndedTimerDetails) && object.Equals((object) this._ProcessTimerFilter, (object) ((ProcessTimerInquiry) obj)._ProcessTimerFilter)) && (object.Equals((object) this._EndTimerBeginGMT, (object) ((ProcessTimerInquiry) obj)._EndTimerBeginGMT) && object.Equals((object) this._EndTimerEndGMT, (object) ((ProcessTimerInquiry) obj)._EndTimerEndGMT) && (object.Equals((object) this._StartTimerBeginGMT, (object) ((ProcessTimerInquiry) obj)._StartTimerBeginGMT) && object.Equals((object) this._StartTimerEndGMT, (object) ((ProcessTimerInquiry) obj)._StartTimerEndGMT)))) && (object.Equals((object) this._ShowTimers, (object) ((ProcessTimerInquiry) obj)._ShowTimers) && object.Equals((object) this._ProductFilter, (object) ((ProcessTimerInquiry) obj)._ProductFilter) && (object.Equals((object) this._ContainerFilter, (object) ((ProcessTimerInquiry) obj)._ContainerFilter) && object.Equals((object) this._MfgOrderFilter, (object) ((ProcessTimerInquiry) obj)._MfgOrderFilter))) && base.Equals(obj);
    }

    public RevisionedObjectRef TimerStartedonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerStartedonSpec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TimerStartedonSpec));
      }
    }

    public RevisionedObjectRef SpecFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecFilter), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SpecFilter));
      }
    }

    public RevisionedObjectRef TimerEndsonSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerEndsonSpec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TimerEndsonSpec));
      }
    }

    public ProcessTimerInquiryDetail[] EndsonSpecTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndsonSpecTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail[]) this.PropertyGet(nameof (EndsonSpecTimerDetails));
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

    public ProcessTimerInquiryDetail[] ProcessTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail[]) this.PropertyGet(nameof (ProcessTimerDetails));
      }
    }

    public Enumeration<TimerCurrentStatusEnum, int> CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Enumeration<TimerCurrentStatusEnum, int>) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public ProcessTimerInquiryDetail[] StartedTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartedTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail[]) this.PropertyGet(nameof (StartedTimerDetails));
      }
    }

    public NamedObjectRef ProcessTimerTypeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerTypeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ProcessTimerTypeFilter));
      }
    }

    public ProcessTimerInquiryDetail[] EndedTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndedTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail[]) this.PropertyGet(nameof (EndedTimerDetails));
      }
    }

    public RevisionedObjectRef ProcessTimerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerFilter), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessTimerFilter));
      }
    }

    public Primitive<DateTime> EndTimerBeginGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerBeginGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndTimerBeginGMT));
      }
    }

    public Primitive<DateTime> EndTimerEndGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerEndGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndTimerEndGMT));
      }
    }

    public Primitive<DateTime> StartTimerBeginGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerBeginGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartTimerBeginGMT));
      }
    }

    public Primitive<DateTime> StartTimerEndGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerEndGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartTimerEndGMT));
      }
    }

    public Primitive<int> ShowTimers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTimers), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ShowTimers));
      }
    }

    public RevisionedObjectRef ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public Primitive<string> ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public NamedObjectRef MfgOrderFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrderFilter));
      }
    }
  }
}
