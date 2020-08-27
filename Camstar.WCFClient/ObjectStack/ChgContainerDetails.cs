// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerDetails
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
  public class ChgContainerDetails : ChgObjectDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerDetails_NewObject")]
    protected ContainerRef _NewObject;

    public override bool Equals(object obj)
    {
      return obj is ChgContainerDetails && object.Equals((object) this._NewObject, (object) ((ChgContainerDetails) obj)._NewObject) && base.Equals(obj);
    }

    public ContainerRef NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
