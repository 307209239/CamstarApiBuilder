// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Holds
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
  public class Holds : HoldStatusTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "Holds_Services")]
    protected Hold[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "Holds_HoldReason")]
    protected NamedObjectRef _HoldReason;

    public override bool Equals(object obj)
    {
      return obj is Holds && this.CompareArrays((Array) this._Services, (Array) ((Holds) obj)._Services) && object.Equals((object) this._HoldReason, (object) ((Holds) obj)._HoldReason) && base.Equals(obj);
    }

    public Hold[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Hold[]) this.PropertyGet(nameof (Services));
      }
    }

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
      }
    }
  }
}
