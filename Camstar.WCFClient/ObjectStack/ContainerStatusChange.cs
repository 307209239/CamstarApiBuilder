// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusChange
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
  public class ContainerStatusChange : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_ChangeStatusReason")]
    protected NamedObjectRef _ChangeStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChange_IncludeChildren")]
    protected Primitive<bool> _IncludeChildren;

    public override bool Equals(object obj)
    {
      return obj is ContainerStatusChange && object.Equals((object) this._ChangeStatusReason, (object) ((ContainerStatusChange) obj)._ChangeStatusReason) && (object.Equals((object) this._Container, (object) ((ContainerStatusChange) obj)._Container) && object.Equals((object) this._IncludeChildren, (object) ((ContainerStatusChange) obj)._IncludeChildren)) && base.Equals(obj);
    }

    public NamedObjectRef ChangeStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeStatusReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangeStatusReason));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<bool> IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
