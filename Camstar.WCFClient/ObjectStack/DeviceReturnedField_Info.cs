// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceReturnedField_Info
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
  public class DeviceReturnedField_Info : UserResponseYesNoField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceReturnedField_Info_ReturnedDateGMT")]
    protected Info _ReturnedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DeviceReturnedField_Info_ReturnedDate")]
    protected Info _ReturnedDate;

    public Info ReturnedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReturnedDateGMT));
      }
    }

    public Info ReturnedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReturnedDate));
      }
    }
  }
}
