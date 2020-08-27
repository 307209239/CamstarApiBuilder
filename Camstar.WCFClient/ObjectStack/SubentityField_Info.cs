// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityField_Info
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
  public class SubentityField_Info : ObjectField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityField_Info_Instances")]
    protected SubentityInstance_Info _Instances;

    public SubentityInstance_Info Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (SubentityInstance_Info) this.PropertyGet(nameof (Instances));
      }
    }
  }
}
