// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeOwner
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
  public class ChangeOwner : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_TriageComplete")]
    protected Primitive<bool> _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_CurrentRole")]
    protected Primitive<string> _CurrentRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_CurrentOwner")]
    protected Primitive<string> _CurrentOwner;

    public override bool Equals(object obj)
    {
      return obj is ChangeOwner && object.Equals((object) this._Role, (object) ((ChangeOwner) obj)._Role) && (object.Equals((object) this._TriageComplete, (object) ((ChangeOwner) obj)._TriageComplete) && object.Equals((object) this._CurrentRole, (object) ((ChangeOwner) obj)._CurrentRole)) && (object.Equals((object) this._Owner, (object) ((ChangeOwner) obj)._Owner) && object.Equals((object) this._CurrentOwner, (object) ((ChangeOwner) obj)._CurrentOwner)) && base.Equals(obj);
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Primitive<string> CurrentRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRole), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CurrentRole));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public Primitive<string> CurrentOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentOwner), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CurrentOwner));
      }
    }
  }
}
