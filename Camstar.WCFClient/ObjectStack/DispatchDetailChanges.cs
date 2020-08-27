// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispatchDetailChanges
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
  public class DispatchDetailChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Parent")]
    protected NamedObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_QueryName")]
    protected Primitive<string> _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_DispatchType")]
    protected Enumeration<DispatchTypeEnum, int> _DispatchType;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_EnforceDispatch")]
    protected Primitive<bool> _EnforceDispatch;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is DispatchDetailChanges && object.Equals((object) this._ObjectToChange, (object) ((DispatchDetailChanges) obj)._ObjectToChange) && (object.Equals((object) this._Parent, (object) ((DispatchDetailChanges) obj)._Parent) && object.Equals((object) this._QueryName, (object) ((DispatchDetailChanges) obj)._QueryName)) && (object.Equals((object) this._DispatchType, (object) ((DispatchDetailChanges) obj)._DispatchType) && object.Equals((object) this._EnforceDispatch, (object) ((DispatchDetailChanges) obj)._EnforceDispatch) && object.Equals((object) this._IsFrozen, (object) ((DispatchDetailChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Parent));
      }
    }

    public Primitive<string> QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QueryName));
      }
    }

    public Enumeration<DispatchTypeEnum, int> DispatchType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchType), (object) value);
      }
      get
      {
        return (Enumeration<DispatchTypeEnum, int>) this.PropertyGet(nameof (DispatchType));
      }
    }

    public Primitive<bool> EnforceDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforceDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (EnforceDispatch));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
