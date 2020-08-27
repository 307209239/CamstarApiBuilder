// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GenericTxns
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
  public class GenericTxns : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "GenericTxns_Services")]
    protected GenericTxn[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxns_TrackableObjects")]
    protected BaseObjectRef[] _TrackableObjects;

    public override bool Equals(object obj)
    {
      return obj is GenericTxns && this.CompareArrays((Array) this._Services, (Array) ((GenericTxns) obj)._Services) && this.CompareArrays((Array) this._TrackableObjects, (Array) ((GenericTxns) obj)._TrackableObjects) && base.Equals(obj);
    }

    public GenericTxn[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (GenericTxn[]) this.PropertyGet(nameof (Services));
      }
    }

    public BaseObjectRef[] TrackableObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObjects), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (TrackableObjects));
      }
    }
  }
}
