// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigReqChanges
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
  public class ModelingESigReqChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_UpdateRequirement")]
    protected NamedObjectRef _UpdateRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_ResolvedCreateReq")]
    protected NamedObjectRef _ResolvedCreateReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_CreateRequirement")]
    protected NamedObjectRef _CreateRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_ResolvedUpdateReq")]
    protected NamedObjectRef _ResolvedUpdateReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_ResolvedFreezeReq")]
    protected NamedObjectRef _ResolvedFreezeReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_DeleteRequirement")]
    protected NamedObjectRef _DeleteRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_ResolvedDeleteReq")]
    protected NamedObjectRef _ResolvedDeleteReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_FreezeRequirement")]
    protected NamedObjectRef _FreezeRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_FreezeResolvedAt")]
    protected Primitive<string> _FreezeResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_UpdateResolvedAt")]
    protected Primitive<string> _UpdateResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_CreateReqClearInherit")]
    protected Primitive<bool> _CreateReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_FreezeReqClearInherit")]
    protected Primitive<bool> _FreezeReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_DeleteReqClearInherit")]
    protected Primitive<bool> _DeleteReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_DeleteResolvedAt")]
    protected Primitive<string> _DeleteResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_CreateResolvedAt")]
    protected Primitive<string> _CreateResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_UpdateReqClearInherit")]
    protected Primitive<bool> _UpdateReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ModelingESigReqChanges && object.Equals((object) this._ObjectToChange, (object) ((ModelingESigReqChanges) obj)._ObjectToChange) && (object.Equals((object) this._UpdateRequirement, (object) ((ModelingESigReqChanges) obj)._UpdateRequirement) && object.Equals((object) this._ResolvedCreateReq, (object) ((ModelingESigReqChanges) obj)._ResolvedCreateReq)) && (object.Equals((object) this._CreateRequirement, (object) ((ModelingESigReqChanges) obj)._CreateRequirement) && object.Equals((object) this._ResolvedUpdateReq, (object) ((ModelingESigReqChanges) obj)._ResolvedUpdateReq) && (object.Equals((object) this._ResolvedFreezeReq, (object) ((ModelingESigReqChanges) obj)._ResolvedFreezeReq) && object.Equals((object) this._DeleteRequirement, (object) ((ModelingESigReqChanges) obj)._DeleteRequirement))) && (object.Equals((object) this._ResolvedDeleteReq, (object) ((ModelingESigReqChanges) obj)._ResolvedDeleteReq) && object.Equals((object) this._FreezeRequirement, (object) ((ModelingESigReqChanges) obj)._FreezeRequirement) && (object.Equals((object) this._FreezeResolvedAt, (object) ((ModelingESigReqChanges) obj)._FreezeResolvedAt) && object.Equals((object) this._UpdateResolvedAt, (object) ((ModelingESigReqChanges) obj)._UpdateResolvedAt)) && (object.Equals((object) this._CreateReqClearInherit, (object) ((ModelingESigReqChanges) obj)._CreateReqClearInherit) && object.Equals((object) this._FreezeReqClearInherit, (object) ((ModelingESigReqChanges) obj)._FreezeReqClearInherit) && (object.Equals((object) this._DeleteReqClearInherit, (object) ((ModelingESigReqChanges) obj)._DeleteReqClearInherit) && object.Equals((object) this._DeleteResolvedAt, (object) ((ModelingESigReqChanges) obj)._DeleteResolvedAt)))) && (object.Equals((object) this._CreateResolvedAt, (object) ((ModelingESigReqChanges) obj)._CreateResolvedAt) && object.Equals((object) this._UpdateReqClearInherit, (object) ((ModelingESigReqChanges) obj)._UpdateReqClearInherit) && object.Equals((object) this._Name, (object) ((ModelingESigReqChanges) obj)._Name)) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef UpdateRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UpdateRequirement));
      }
    }

    public NamedObjectRef ResolvedCreateReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedCreateReq), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResolvedCreateReq));
      }
    }

    public NamedObjectRef CreateRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CreateRequirement));
      }
    }

    public NamedObjectRef ResolvedUpdateReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedUpdateReq), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResolvedUpdateReq));
      }
    }

    public NamedObjectRef ResolvedFreezeReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedFreezeReq), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResolvedFreezeReq));
      }
    }

    public NamedObjectRef DeleteRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DeleteRequirement));
      }
    }

    public NamedObjectRef ResolvedDeleteReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedDeleteReq), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResolvedDeleteReq));
      }
    }

    public NamedObjectRef FreezeRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FreezeRequirement));
      }
    }

    public Primitive<string> FreezeResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeResolvedAt), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FreezeResolvedAt));
      }
    }

    public Primitive<string> UpdateResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateResolvedAt), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UpdateResolvedAt));
      }
    }

    public Primitive<bool> CreateReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateReqClearInherit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CreateReqClearInherit));
      }
    }

    public Primitive<bool> FreezeReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeReqClearInherit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (FreezeReqClearInherit));
      }
    }

    public Primitive<bool> DeleteReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteReqClearInherit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DeleteReqClearInherit));
      }
    }

    public Primitive<string> DeleteResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteResolvedAt), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DeleteResolvedAt));
      }
    }

    public Primitive<string> CreateResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateResolvedAt), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CreateResolvedAt));
      }
    }

    public Primitive<bool> UpdateReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateReqClearInherit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UpdateReqClearInherit));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
