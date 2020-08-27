// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxn_SetESigProcessTimerDetails_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerTxn_SetESigProcessTimerDetails_Parameters : ContainerTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerDtl")]
    protected string _ProcessTimerDtl;

    public string ProcessTimerDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerDtl), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ProcessTimerDtl));
      }
    }
  }
}
