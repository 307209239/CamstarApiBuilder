// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SwitchingRuleMaint_Request
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SwitchingRuleMaint_Request : Request
  {
    [DataMember(EmitDefaultValue = false, Name = "Info")]
    protected SwitchingRuleMaint_Info _Info;

    public SwitchingRuleMaint_Info Info
    {
      [param: In] set
      {
        this.PropertySet(nameof (Info), (object) value);
      }
      get
      {
        return (SwitchingRuleMaint_Info) this.PropertyGet(nameof (Info));
      }
    }
  }
}
