// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigReqChanges_Info
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
  public class ModelingESigReqChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_UpdateRequirement")]
    protected Info _UpdateRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_ResolvedCreateReq")]
    protected Info _ResolvedCreateReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_CreateRequirement")]
    protected Info _CreateRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_ResolvedUpdateReq")]
    protected Info _ResolvedUpdateReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_ResolvedFreezeReq")]
    protected Info _ResolvedFreezeReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_DeleteRequirement")]
    protected Info _DeleteRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_ResolvedDeleteReq")]
    protected Info _ResolvedDeleteReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_FreezeRequirement")]
    protected Info _FreezeRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_FreezeResolvedAt")]
    protected Info _FreezeResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_UpdateResolvedAt")]
    protected Info _UpdateResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_CreateReqClearInherit")]
    protected Info _CreateReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_FreezeReqClearInherit")]
    protected Info _FreezeReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_DeleteReqClearInherit")]
    protected Info _DeleteReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_DeleteResolvedAt")]
    protected Info _DeleteResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_CreateResolvedAt")]
    protected Info _CreateResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_UpdateReqClearInherit")]
    protected Info _UpdateReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info UpdateRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpdateRequirement));
      }
    }

    public Info ResolvedCreateReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedCreateReq), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolvedCreateReq));
      }
    }

    public Info CreateRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreateRequirement));
      }
    }

    public Info ResolvedUpdateReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedUpdateReq), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolvedUpdateReq));
      }
    }

    public Info ResolvedFreezeReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedFreezeReq), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolvedFreezeReq));
      }
    }

    public Info DeleteRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeleteRequirement));
      }
    }

    public Info ResolvedDeleteReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedDeleteReq), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolvedDeleteReq));
      }
    }

    public Info FreezeRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FreezeRequirement));
      }
    }

    public Info FreezeResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeResolvedAt), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FreezeResolvedAt));
      }
    }

    public Info UpdateResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateResolvedAt), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpdateResolvedAt));
      }
    }

    public Info CreateReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateReqClearInherit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreateReqClearInherit));
      }
    }

    public Info FreezeReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeReqClearInherit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FreezeReqClearInherit));
      }
    }

    public Info DeleteReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteReqClearInherit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeleteReqClearInherit));
      }
    }

    public Info DeleteResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteResolvedAt), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeleteResolvedAt));
      }
    }

    public Info CreateResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateResolvedAt), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreateResolvedAt));
      }
    }

    public Info UpdateReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateReqClearInherit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpdateReqClearInherit));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
