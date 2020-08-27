// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtTxns_Environment
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
  public class ChangeMgtTxns_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxns_Environment_Services")]
    [Metadata("Services that manages change packages.", "ChangeMgtTxn", false, false, false, "ChangeMgtTxn", 16778887, false, true, false, null)]
    protected ChangeMgtTxn_Environment _Services;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1050027, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxns_Environment_ChangePackages")]
    protected Environment _ChangePackages;

    public ChangeMgtTxn_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ChangeMgtTxn_Environment) this.PropertyGet(nameof (Services));
      }
    }

    public Environment ChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackages));
      }
    }
  }
}
