// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityField
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
  public class SubentityField : ObjectField
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityField_Instances")]
    protected SubentityInstance[] _Instances;

    public override bool Equals(object obj)
    {
      return obj is SubentityField && this.CompareArrays((Array) this._Instances, (Array) ((SubentityField) obj)._Instances) && base.Equals(obj);
    }

    public SubentityInstance[] Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (SubentityInstance[]) this.PropertyGet(nameof (Instances));
      }
    }
  }
}
