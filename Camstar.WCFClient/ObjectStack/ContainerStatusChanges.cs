// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerStatusChanges
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
  public class ContainerStatusChanges : ContainersTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_Services")]
    protected ContainerStatusChange[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_ChangeStatusReason")]
    protected NamedObjectRef _ChangeStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerStatusChanges_IncludeChildren")]
    protected Primitive<bool> _IncludeChildren;

    public override bool Equals(object obj)
    {
      return obj is ContainerStatusChanges && this.CompareArrays((Array) this._Services, (Array) ((ContainerStatusChanges) obj)._Services) && (object.Equals((object) this._ChangeStatusReason, (object) ((ContainerStatusChanges) obj)._ChangeStatusReason) && object.Equals((object) this._IncludeChildren, (object) ((ContainerStatusChanges) obj)._IncludeChildren)) && base.Equals(obj);
    }

    public ContainerStatusChange[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (ContainerStatusChange[]) this.PropertyGet(nameof (Services));
      }
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
