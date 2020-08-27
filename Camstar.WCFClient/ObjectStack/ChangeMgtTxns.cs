// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtTxns
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
  public class ChangeMgtTxns : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxns_Services")]
    protected ChangeMgtTxn[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxns_ChangePackages")]
    protected NamedObjectRef[] _ChangePackages;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtTxns && this.CompareArrays((Array) this._Services, (Array) ((ChangeMgtTxns) obj)._Services) && this.CompareArrays((Array) this._ChangePackages, (Array) ((ChangeMgtTxns) obj)._ChangePackages) && base.Equals(obj);
    }

    public ChangeMgtTxn[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ChangeMgtTxn[]) this.PropertyGet(nameof (Services));
      }
    }

    public NamedObjectRef[] ChangePackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackages), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChangePackages));
      }
    }
  }
}
