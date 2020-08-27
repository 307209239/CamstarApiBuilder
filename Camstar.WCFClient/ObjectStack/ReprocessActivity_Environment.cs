// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprocessActivity_Environment
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
  public class ReprocessActivity_Environment : ProcessObjectTxn_Environment
  {
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, false, false, "NamedSubentityRef", 1051396, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReprocessActivity_Environment_ProcessObject")]
    protected new Environment _ProcessObject;

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }
  }
}
