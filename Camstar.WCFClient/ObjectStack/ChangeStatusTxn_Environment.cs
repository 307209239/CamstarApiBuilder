// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeStatusTxn_Environment
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
  public class ChangeStatusTxn_Environment : ChangeMgtTxn_Environment
  {
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1053240, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_Environment_ChangePackage")]
    protected new Environment _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_Environment_LockInstances")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 0, false, false, false, "0")]
    protected Environment _LockInstances;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778128, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_Environment_Status")]
    protected Environment _Status;

    public new Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Environment LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }
  }
}
