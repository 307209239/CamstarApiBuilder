// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.InventoryTransfer
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
  public class InventoryTransfer : Transfer
  {
    [DataMember(EmitDefaultValue = false, Name = "InventoryTransfer_ToLocation")]
    protected new NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "InventoryTransfer_ToFactory")]
    protected new NamedObjectRef _ToFactory;

    public override bool Equals(object obj)
    {
      return obj is InventoryTransfer && object.Equals((object) this._ToLocation, (object) ((InventoryTransfer) obj)._ToLocation) && object.Equals((object) this._ToFactory, (object) ((InventoryTransfer) obj)._ToFactory) && base.Equals(obj);
    }

    public new NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
      }
    }

    public new NamedObjectRef ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToFactory));
      }
    }
  }
}
