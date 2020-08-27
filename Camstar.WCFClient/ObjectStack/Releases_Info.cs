// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Releases_Info
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
  public class Releases_Info : HoldStatusTxns_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Releases_Info_ReleaseReason")]
    protected Info _ReleaseReason;
    [DataMember(EmitDefaultValue = false, Name = "Releases_Info_Services")]
    protected Release_Info _Services;

    public Info ReleaseReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReleaseReason));
      }
    }

    public Release_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Release_Info) this.PropertyGet(nameof (Services));
      }
    }
  }
}
