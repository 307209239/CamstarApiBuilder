// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxn_ProcessStopTimer_Parameters
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
  public class ContainerTxn_ProcessStopTimer_Parameters : ContainerTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Timer")]
    protected string _Timer;

    public string Timer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timer), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Timer));
      }
    }
  }
}
