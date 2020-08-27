// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RouteProcessObject
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
  public class RouteProcessObject : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "RouteProcessObject_ChildRoutingOption")]
    protected Enumeration<ChildRoutingOptionEnum, int> _ChildRoutingOption;
    [DataMember(EmitDefaultValue = false, Name = "RouteProcessObject_Assignee")]
    protected NamedObjectRef _Assignee;

    public override bool Equals(object obj)
    {
      return obj is RouteProcessObject && object.Equals((object) this._ChildRoutingOption, (object) ((RouteProcessObject) obj)._ChildRoutingOption) && object.Equals((object) this._Assignee, (object) ((RouteProcessObject) obj)._Assignee) && base.Equals(obj);
    }

    public Enumeration<ChildRoutingOptionEnum, int> ChildRoutingOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildRoutingOption), (object) value);
      }
      get
      {
        return (Enumeration<ChildRoutingOptionEnum, int>) this.PropertyGet(nameof (ChildRoutingOption));
      }
    }

    public NamedObjectRef Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Assignee));
      }
    }
  }
}
