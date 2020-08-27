// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TransferRework_Environment
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
  public class TransferRework_Environment : Rework_Environment
  {
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050386, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TransferRework_Environment_UseDispatch")]
    protected new Environment _UseDispatch;

    public new Environment UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseDispatch));
      }
    }
  }
}
