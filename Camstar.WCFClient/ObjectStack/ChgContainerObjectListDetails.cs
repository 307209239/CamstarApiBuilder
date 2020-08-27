// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerObjectListDetails
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
  public class ChgContainerObjectListDetails : ChgObjectListDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerObjectListDetails_NewObjects")]
    protected ContainerRef[] _NewObjects;

    public override bool Equals(object obj)
    {
      return obj is ChgContainerObjectListDetails && this.CompareArrays((Array) this._NewObjects, (Array) ((ChgContainerObjectListDetails) obj)._NewObjects) && base.Equals(obj);
    }

    public ContainerRef[] NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (NewObjects));
      }
    }
  }
}
