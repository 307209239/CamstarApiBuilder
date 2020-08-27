// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMfgData_Environment
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
  public class GetMfgData_Environment : Inquiry_Environment
  {
    [Metadata("MfgDataDetail", "MfgDataDetail", false, false, false, "MfgDataDetail", 1052003, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMfgData_Environment_MfgDataDetails")]
    protected MfgDataDetail_Environment _MfgDataDetails;

    public MfgDataDetail_Environment MfgDataDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDataDetails), (object) value);
      }
      get
      {
        return (MfgDataDetail_Environment) this.PropertyGet(nameof (MfgDataDetails));
      }
    }
  }
}
