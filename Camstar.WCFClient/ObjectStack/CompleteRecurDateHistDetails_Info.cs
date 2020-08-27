// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteRecurDateHistDetails_Info
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
  public class CompleteRecurDateHistDetails_Info : CompleteMaintHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Info_LastDateWarningGMT")]
    protected Info _LastDateWarningGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Info_LastDateLimitGMT")]
    protected Info _LastDateLimitGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Info_LastDateDueGMT")]
    protected Info _LastDateDueGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Info_LastDateLimit")]
    protected Info _LastDateLimit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Info_LastDateWarning")]
    protected Info _LastDateWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Info_LastDateDue")]
    protected Info _LastDateDue;

    public Info LastDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateWarningGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDateWarningGMT));
      }
    }

    public Info LastDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateLimitGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDateLimitGMT));
      }
    }

    public Info LastDateDueGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateDueGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDateDueGMT));
      }
    }

    public Info LastDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDateLimit));
      }
    }

    public Info LastDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateWarning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDateWarning));
      }
    }

    public Info LastDateDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDateDue));
      }
    }
  }
}
