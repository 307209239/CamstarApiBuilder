// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Release_Info
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
  public class Release_Info : HoldStatusTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Release_Info_ReleaseReason")]
    protected Info _ReleaseReason;
    [DataMember(EmitDefaultValue = false, Name = "Release_Info_HoldReason")]
    protected new Info _HoldReason;

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

    public new Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
      }
    }
  }
}
