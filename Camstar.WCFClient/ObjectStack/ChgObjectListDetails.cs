// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectListDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgRevObjectListDetails))]
  [KnownType(typeof (ChgNamedObjectListDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgContainerObjectListDetails))]
  [Serializable]
  public class ChgObjectListDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListDetails_NewObjects")]
    protected BaseObjectRef[] _NewObjects;

    public override bool Equals(object obj)
    {
      return obj is ChgObjectListDetails && this.CompareArrays((Array) this._NewObjects, (Array) ((ChgObjectListDetails) obj)._NewObjects) && base.Equals(obj);
    }

    public BaseObjectRef[] NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (NewObjects));
      }
    }
  }
}
