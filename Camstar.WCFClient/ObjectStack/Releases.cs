// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Releases
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
  public class Releases : HoldStatusTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "Releases_ReleaseReason")]
    protected NamedObjectRef _ReleaseReason;
    [DataMember(EmitDefaultValue = false, Name = "Releases_Services")]
    protected Release[] _Services;

    public override bool Equals(object obj)
    {
      return obj is Releases && object.Equals((object) this._ReleaseReason, (object) ((Releases) obj)._ReleaseReason) && this.CompareArrays((Array) this._Services, (Array) ((Releases) obj)._Services) && base.Equals(obj);
    }

    public NamedObjectRef ReleaseReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReleaseReason));
      }
    }

    public Release[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Release[]) this.PropertyGet(nameof (Services));
      }
    }
  }
}
