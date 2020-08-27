// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerInquiry_Info
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
  public class ProcessTimerInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_TimerStartedonSpec")]
    protected Info _TimerStartedonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_SpecFilter")]
    protected Info _SpecFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_TimerEndsonSpec")]
    protected Info _TimerEndsonSpec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_EndsonSpecTimerDetails")]
    protected ProcessTimerInquiryDetail_Info _EndsonSpecTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_CompletionStatus")]
    protected Info _CompletionStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_ProcessTimerDetails")]
    protected ProcessTimerInquiryDetail_Info _ProcessTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_CurrentStatus")]
    protected Info _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_StartedTimerDetails")]
    protected ProcessTimerInquiryDetail_Info _StartedTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_ProcessTimerTypeFilter")]
    protected Info _ProcessTimerTypeFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_EndedTimerDetails")]
    protected ProcessTimerInquiryDetail_Info _EndedTimerDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_ProcessTimerFilter")]
    protected Info _ProcessTimerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_EndTimerBeginGMT")]
    protected Info _EndTimerBeginGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_EndTimerEndGMT")]
    protected Info _EndTimerEndGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_StartTimerBeginGMT")]
    protected Info _StartTimerBeginGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_StartTimerEndGMT")]
    protected Info _StartTimerEndGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_ShowTimers")]
    protected Info _ShowTimers;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_ProductFilter")]
    protected Info _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_ContainerFilter")]
    protected Info _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerInquiry_Info_MfgOrderFilter")]
    protected Info _MfgOrderFilter;

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

    public Info SpecFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecFilter));
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

    public ProcessTimerInquiryDetail_Info EndsonSpecTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndsonSpecTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Info) this.PropertyGet(nameof (EndsonSpecTimerDetails));
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

    public ProcessTimerInquiryDetail_Info ProcessTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Info) this.PropertyGet(nameof (ProcessTimerDetails));
      }
    }

    public Info CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public ProcessTimerInquiryDetail_Info StartedTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartedTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Info) this.PropertyGet(nameof (StartedTimerDetails));
      }
    }

    public Info ProcessTimerTypeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerTypeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerTypeFilter));
      }
    }

    public ProcessTimerInquiryDetail_Info EndedTimerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndedTimerDetails), (object) value);
      }
      get
      {
        return (ProcessTimerInquiryDetail_Info) this.PropertyGet(nameof (EndedTimerDetails));
      }
    }

    public Info ProcessTimerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerFilter));
      }
    }

    public Info EndTimerBeginGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerBeginGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndTimerBeginGMT));
      }
    }

    public Info EndTimerEndGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerEndGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndTimerEndGMT));
      }
    }

    public Info StartTimerBeginGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerBeginGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartTimerBeginGMT));
      }
    }

    public Info StartTimerEndGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerEndGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartTimerEndGMT));
      }
    }

    public Info ShowTimers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTimers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowTimers));
      }
    }

    public Info ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public Info ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public Info MfgOrderFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrderFilter));
      }
    }
  }
}
