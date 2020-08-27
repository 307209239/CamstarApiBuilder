// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMfgData_Info
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
  public class GetMfgData_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMfgData_Info_MfgDataDetails")]
    protected MfgDataDetail_Info _MfgDataDetails;

    public MfgDataDetail_Info MfgDataDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDataDetails), (object) value);
      }
      get
      {
        return (MfgDataDetail_Info) this.PropertyGet(nameof (MfgDataDetails));
      }
    }
  }
}
