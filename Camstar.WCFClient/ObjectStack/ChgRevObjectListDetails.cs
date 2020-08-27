// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgRevObjectListDetails
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
  public class ChgRevObjectListDetails : ChgObjectListDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgRevObjectListDetails_NewObjects")]
    protected RevisionedObjectRef[] _NewObjects;

    public override bool Equals(object obj)
    {
      return obj is ChgRevObjectListDetails && this.CompareArrays((Array) this._NewObjects, (Array) ((ChgRevObjectListDetails) obj)._NewObjects) && base.Equals(obj);
    }

    public RevisionedObjectRef[] NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (NewObjects));
      }
    }
  }
}
