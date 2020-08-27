// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceReturnedHistoryDetail
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
  public class DeviceReturnedHistoryDetail : UserResponseYesNoFieldHistDet
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceReturnedHistoryDetail_ReturnedDateGMT")]
    protected Primitive<DateTime> _ReturnedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DeviceReturnedHistoryDetail_ReturnedDate")]
    protected Primitive<DateTime> _ReturnedDate;

    public override bool Equals(object obj)
    {
      return obj is DeviceReturnedHistoryDetail && object.Equals((object) this._ReturnedDateGMT, (object) ((DeviceReturnedHistoryDetail) obj)._ReturnedDateGMT) && object.Equals((object) this._ReturnedDate, (object) ((DeviceReturnedHistoryDetail) obj)._ReturnedDate) && base.Equals(obj);
    }

    public Primitive<DateTime> ReturnedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReturnedDateGMT));
      }
    }

    public Primitive<DateTime> ReturnedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReturnedDate));
      }
    }
  }
}
