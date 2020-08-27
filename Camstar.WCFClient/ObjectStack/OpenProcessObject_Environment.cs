// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OpenProcessObject_Environment
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
  public class OpenProcessObject_Environment : ProcessObjectTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObject_Environment_ChildOpenOption")]
    [Metadata("Enumeration for the Child Open Option:\r\n1 = NoChange\r\n2 = FromPending", "ChildOpenOptionEnum", false, false, false, "Integer", 1052159, false, false, true, null)]
    protected Environment _ChildOpenOption;

    public Environment ChildOpenOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildOpenOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildOpenOption));
      }
    }
  }
}
