// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Releases_Environment
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
  public class Releases_Environment : HoldStatusTxns_Environment
  {
    [Metadata("Reason codes for releasing Containers", "ReleaseReason", false, false, false, "NamedObjectRef", 1050369, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Releases_Environment_ReleaseReason")]
    protected Environment _ReleaseReason;
    [Metadata("Is a service used to release a container and its ancestors that were held.", "Release", false, false, false, "Release", 1052702, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Releases_Environment_Services")]
    protected Release_Environment _Services;

    public Environment ReleaseReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReleaseReason));
      }
    }

    public Release_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Release_Environment) this.PropertyGet(nameof (Services));
      }
    }
  }
}
