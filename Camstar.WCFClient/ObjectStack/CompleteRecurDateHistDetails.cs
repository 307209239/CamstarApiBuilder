// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteRecurDateHistDetails
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
  public class CompleteRecurDateHistDetails : CompleteMaintHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_LastDateWarningGMT")]
    protected Primitive<DateTime> _LastDateWarningGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_LastDateLimitGMT")]
    protected Primitive<DateTime> _LastDateLimitGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_LastDateDueGMT")]
    protected Primitive<DateTime> _LastDateDueGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_LastDateLimit")]
    protected Primitive<DateTime> _LastDateLimit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_LastDateWarning")]
    protected Primitive<DateTime> _LastDateWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRecurDateHistDetails_LastDateDue")]
    protected Primitive<DateTime> _LastDateDue;

    public override bool Equals(object obj)
    {
      return obj is CompleteRecurDateHistDetails && object.Equals((object) this._LastDateWarningGMT, (object) ((CompleteRecurDateHistDetails) obj)._LastDateWarningGMT) && (object.Equals((object) this._LastDateLimitGMT, (object) ((CompleteRecurDateHistDetails) obj)._LastDateLimitGMT) && object.Equals((object) this._LastDateDueGMT, (object) ((CompleteRecurDateHistDetails) obj)._LastDateDueGMT)) && (object.Equals((object) this._LastDateLimit, (object) ((CompleteRecurDateHistDetails) obj)._LastDateLimit) && object.Equals((object) this._LastDateWarning, (object) ((CompleteRecurDateHistDetails) obj)._LastDateWarning) && object.Equals((object) this._LastDateDue, (object) ((CompleteRecurDateHistDetails) obj)._LastDateDue)) && base.Equals(obj);
    }

    public Primitive<DateTime> LastDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateWarningGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDateWarningGMT));
      }
    }

    public Primitive<DateTime> LastDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateLimitGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDateLimitGMT));
      }
    }

    public Primitive<DateTime> LastDateDueGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateDueGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDateDueGMT));
      }
    }

    public Primitive<DateTime> LastDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateLimit), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDateLimit));
      }
    }

    public Primitive<DateTime> LastDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateWarning), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDateWarning));
      }
    }

    public Primitive<DateTime> LastDateDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDateDue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDateDue));
      }
    }
  }
}
