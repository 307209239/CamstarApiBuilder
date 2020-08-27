// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigReqChanges_Environment
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
  public class ModelingESigReqChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_ObjectToChange")]
    [Metadata("Manage electronic signature requirements", "ModelingESigReq", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_UpdateRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050901, false, false, false, null)]
    protected Environment _UpdateRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_ResolvedCreateReq")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050908, false, false, false, null)]
    protected Environment _ResolvedCreateReq;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_CreateRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050900, false, false, false, null)]
    protected Environment _CreateRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_ResolvedUpdateReq")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050910, false, false, false, null)]
    protected Environment _ResolvedUpdateReq;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050911, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_ResolvedFreezeReq")]
    protected Environment _ResolvedFreezeReq;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050902, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_DeleteRequirement")]
    protected Environment _DeleteRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_ResolvedDeleteReq")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050909, false, false, false, null)]
    protected Environment _ResolvedDeleteReq;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050903, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_FreezeRequirement")]
    protected Environment _FreezeRequirement;
    [Metadata("Generic String", "", false, false, true, "String", 1050924, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_FreezeResolvedAt")]
    protected Environment _FreezeResolvedAt;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_UpdateResolvedAt")]
    [Metadata("Generic String", "", false, false, true, "String", 1050914, false, false, false, null)]
    protected Environment _UpdateResolvedAt;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050904, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_CreateReqClearInherit")]
    protected Environment _CreateReqClearInherit;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050907, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_FreezeReqClearInherit")]
    protected Environment _FreezeReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_DeleteReqClearInherit")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050905, false, false, false, "0")]
    protected Environment _DeleteReqClearInherit;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_DeleteResolvedAt")]
    [Metadata("Generic String", "", false, false, true, "String", 1050913, false, false, false, null)]
    protected Environment _DeleteResolvedAt;
    [Metadata("Generic String", "", false, false, true, "String", 1050912, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_CreateResolvedAt")]
    protected Environment _CreateResolvedAt;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050906, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_UpdateReqClearInherit")]
    protected Environment _UpdateReqClearInherit;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050927, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment UpdateRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpdateRequirement));
      }
    }

    public Environment ResolvedCreateReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedCreateReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedCreateReq));
      }
    }

    public Environment CreateRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreateRequirement));
      }
    }

    public Environment ResolvedUpdateReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedUpdateReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedUpdateReq));
      }
    }

    public Environment ResolvedFreezeReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedFreezeReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedFreezeReq));
      }
    }

    public Environment DeleteRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeleteRequirement));
      }
    }

    public Environment ResolvedDeleteReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedDeleteReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedDeleteReq));
      }
    }

    public Environment FreezeRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FreezeRequirement));
      }
    }

    public Environment FreezeResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeResolvedAt), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FreezeResolvedAt));
      }
    }

    public Environment UpdateResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateResolvedAt), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpdateResolvedAt));
      }
    }

    public Environment CreateReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateReqClearInherit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreateReqClearInherit));
      }
    }

    public Environment FreezeReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (FreezeReqClearInherit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FreezeReqClearInherit));
      }
    }

    public Environment DeleteReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteReqClearInherit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeleteReqClearInherit));
      }
    }

    public Environment DeleteResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeleteResolvedAt), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeleteResolvedAt));
      }
    }

    public Environment CreateResolvedAt
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateResolvedAt), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreateResolvedAt));
      }
    }

    public Environment UpdateReqClearInherit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateReqClearInherit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpdateReqClearInherit));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
