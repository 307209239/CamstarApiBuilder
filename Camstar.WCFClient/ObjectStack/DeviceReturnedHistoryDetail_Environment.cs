// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceReturnedHistoryDetail_Environment
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
  public class DeviceReturnedHistoryDetail_Environment : UserResponseYesNoFieldHistDet_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceReturnedHistoryDetail_Environment_ReturnedDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051266, false, false, false, null)]
    protected Environment _ReturnedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DeviceReturnedHistoryDetail_Environment_ReturnedDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051265, false, false, false, null)]
    protected Environment _ReturnedDate;

    public Environment ReturnedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReturnedDateGMT));
      }
    }

    public Environment ReturnedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReturnedDate));
      }
    }
  }
}
