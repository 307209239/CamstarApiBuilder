// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintClassActivationDetails
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
  public class MaintClassActivationDetails : MaintReqActivationDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintClassActivationDetails_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is MaintClassActivationDetails && object.Equals((object) this._Resource, (object) ((MaintClassActivationDetails) obj)._Resource) && base.Equals(obj);
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
