// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Transfer
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
  public class Transfer : MoveNonStd
  {
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Close")]
    protected new Primitive<bool> _Close;
    [DataMember(EmitDefaultValue = false, Name = "Transfer_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "Transfer_ToLocation")]
    protected new NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "Transfer_ToFactory")]
    protected new NamedObjectRef _ToFactory;

    public override bool Equals(object obj)
    {
      return obj is Transfer && object.Equals((object) this._Close, (object) ((Transfer) obj)._Close) && (object.Equals((object) this._UseDispatch, (object) ((Transfer) obj)._UseDispatch) && object.Equals((object) this._ToLocation, (object) ((Transfer) obj)._ToLocation)) && object.Equals((object) this._ToFactory, (object) ((Transfer) obj)._ToFactory) && base.Equals(obj);
    }

    public new Primitive<bool> Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Close));
      }
    }

    public new Primitive<bool> UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseDispatch));
      }
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
