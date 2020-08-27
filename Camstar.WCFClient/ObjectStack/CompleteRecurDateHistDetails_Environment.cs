// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteRecurDateHistDetails_Environment
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
  public class CompleteRecurDateHistDetails_Environment : CompleteMaintHistoryDetails_Environment
  {
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052550, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Environment_LastDateWarningGMT")]
    protected Environment _LastDateWarningGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052549, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Environment_LastDateLimitGMT")]
    protected Environment _LastDateLimitGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Environment_LastDateDueGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052545, false, false, false, null)]
    protected Environment _LastDateDueGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Environment_LastDateLimit")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050754, false, false, false, null)]
    protected Environment _LastDateLimit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Environment_LastDateWarning")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050755, false, false, false, null)]
    protected Environment _LastDateWarning;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050740, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_Environment_LastDateDue")]
    protected Environment _LastDateDue;

    public Environment LastDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateWarningGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDateWarningGMT));
      }
    }

    public Environment LastDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateLimitGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDateLimitGMT));
      }
    }

    public Environment LastDateDueGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateDueGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDateDueGMT));
      }
    }

    public Environment LastDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDateLimit));
      }
    }

    public Environment LastDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateWarning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDateWarning));
      }
    }

    public Environment LastDateDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDateDue));
      }
    }
  }
}
