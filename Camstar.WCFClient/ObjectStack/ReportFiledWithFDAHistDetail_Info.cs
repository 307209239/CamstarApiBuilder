// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportFiledWithFDAHistDetail_Info
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
  public class ReportFiledWithFDAHistDetail_Info : UserResponseYesNoFieldHistDet_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportFiledWithFDAHistDetail_Info_Unknown")]
    protected Info _Unknown;

    public Info Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Unknown));
      }
    }
  }
}
