// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgNamedObjectListDetails
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
  public class ChgNamedObjectListDetails : ChgObjectListDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgNamedObjectListDetails_NewObjects")]
    protected NamedObjectRef[] _NewObjects;

    public override bool Equals(object obj)
    {
      return obj is ChgNamedObjectListDetails && this.CompareArrays((Array) this._NewObjects, (Array) ((ChgNamedObjectListDetails) obj)._NewObjects) && base.Equals(obj);
    }

    public NamedObjectRef[] NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NewObjects));
      }
    }
  }
}
