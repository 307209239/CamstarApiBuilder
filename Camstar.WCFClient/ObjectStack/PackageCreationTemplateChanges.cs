// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageCreationTemplateChanges
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
  public class PackageCreationTemplateChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_PackageDescription")]
    protected Primitive<string> _PackageDescription;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_PackageType1")]
    protected BaseObjectRef _PackageType1;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_OwnerRole")]
    protected NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_SourceSystem")]
    protected NamedObjectRef _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_PackageType")]
    protected NamedObjectRef _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_TargetSystems")]
    protected NamedObjectRef[] _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_PackageCreationReason")]
    protected NamedObjectRef _PackageCreationReason;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_CollaboratorTemplate")]
    protected NamedObjectRef _CollaboratorTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_PackagePriorityCode")]
    protected NamedObjectRef _PackagePriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_ApprovalTemplate")]
    protected NamedObjectRef _ApprovalTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_ECOECN")]
    protected Primitive<string> _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_UseContentCollaborators")]
    protected Primitive<bool> _UseContentCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_WorkflowAssignApprovers")]
    protected Primitive<bool> _WorkflowAssignApprovers;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_PackageOwner")]
    protected NamedObjectRef _PackageOwner;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_WorkflowDescription")]
    protected Primitive<string> _WorkflowDescription;

    public override bool Equals(object obj)
    {
      return obj is PackageCreationTemplateChanges && object.Equals((object) this._PackageDescription, (object) ((PackageCreationTemplateChanges) obj)._PackageDescription) && (object.Equals((object) this._PackageType1, (object) ((PackageCreationTemplateChanges) obj)._PackageType1) && object.Equals((object) this._OwnerRole, (object) ((PackageCreationTemplateChanges) obj)._OwnerRole)) && (object.Equals((object) this._SourceSystem, (object) ((PackageCreationTemplateChanges) obj)._SourceSystem) && object.Equals((object) this._PackageType, (object) ((PackageCreationTemplateChanges) obj)._PackageType) && (this.CompareArrays((Array) this._TargetSystems, (Array) ((PackageCreationTemplateChanges) obj)._TargetSystems) && object.Equals((object) this._PackageCreationReason, (object) ((PackageCreationTemplateChanges) obj)._PackageCreationReason))) && (object.Equals((object) this._CollaboratorTemplate, (object) ((PackageCreationTemplateChanges) obj)._CollaboratorTemplate) && object.Equals((object) this._ObjectToChange, (object) ((PackageCreationTemplateChanges) obj)._ObjectToChange) && (object.Equals((object) this._PackagePriorityCode, (object) ((PackageCreationTemplateChanges) obj)._PackagePriorityCode) && object.Equals((object) this._ApprovalTemplate, (object) ((PackageCreationTemplateChanges) obj)._ApprovalTemplate)) && (object.Equals((object) this._Workflow, (object) ((PackageCreationTemplateChanges) obj)._Workflow) && object.Equals((object) this._ECOECN, (object) ((PackageCreationTemplateChanges) obj)._ECOECN) && (object.Equals((object) this._UseContentCollaborators, (object) ((PackageCreationTemplateChanges) obj)._UseContentCollaborators) && object.Equals((object) this._WorkflowAssignApprovers, (object) ((PackageCreationTemplateChanges) obj)._WorkflowAssignApprovers)))) && (object.Equals((object) this._PackageOwner, (object) ((PackageCreationTemplateChanges) obj)._PackageOwner) && object.Equals((object) this._Name, (object) ((PackageCreationTemplateChanges) obj)._Name) && object.Equals((object) this._WorkflowDescription, (object) ((PackageCreationTemplateChanges) obj)._WorkflowDescription)) && base.Equals(obj);
    }

    public Primitive<string> PackageDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageDescription));
      }
    }

    public BaseObjectRef PackageType1
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType1), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (PackageType1));
      }
    }

    public NamedObjectRef OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public NamedObjectRef SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public NamedObjectRef PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PackageType));
      }
    }

    public NamedObjectRef[] TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public NamedObjectRef PackageCreationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageCreationReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PackageCreationReason));
      }
    }

    public NamedObjectRef CollaboratorTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CollaboratorTemplate));
      }
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

    public NamedObjectRef PackagePriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackagePriorityCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PackagePriorityCode));
      }
    }

    public NamedObjectRef ApprovalTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalTemplate));
      }
    }

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public Primitive<string> ECOECN
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECOECN), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ECOECN));
      }
    }

    public Primitive<bool> UseContentCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseContentCollaborators), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseContentCollaborators));
      }
    }

    public Primitive<bool> WorkflowAssignApprovers
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowAssignApprovers), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (WorkflowAssignApprovers));
      }
    }

    public NamedObjectRef PackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PackageOwner));
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

    public Primitive<string> WorkflowDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowDescription));
      }
    }
  }
}
