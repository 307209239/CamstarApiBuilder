// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityField_Environment
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
  public class SubentityField_Environment : ObjectField_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityField_Environment_Instances")]
    [Metadata("Represents a subentity instance", "SubentityInstance", false, false, true, "SubentityInstance", 1050849, false, true, false, null)]
    protected SubentityInstance_Environment _Instances;

    public SubentityInstance_Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (SubentityInstance_Environment) this.PropertyGet(nameof (Instances));
      }
    }
  }
}
