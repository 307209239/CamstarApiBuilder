// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageCreationTemplateChanges_Info
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
  public class PackageCreationTemplateChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_PackageDescription")]
    protected Info _PackageDescription;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_PackageType1")]
    protected Info _PackageType1;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_OwnerRole")]
    protected Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_SourceSystem")]
    protected Info _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_PackageType")]
    protected Info _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_TargetSystems")]
    protected Info _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_PackageCreationReason")]
    protected Info _PackageCreationReason;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_CollaboratorTemplate")]
    protected Info _CollaboratorTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_PackagePriorityCode")]
    protected Info _PackagePriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_ApprovalTemplate")]
    protected Info _ApprovalTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_ECOECN")]
    protected Info _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_UseContentCollaborators")]
    protected Info _UseContentCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_WorkflowAssignApprovers")]
    protected Info _WorkflowAssignApprovers;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_PackageOwner")]
    protected Info _PackageOwner;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "PackageCreationTemplateChanges_Info_WorkflowDescription")]
    protected Info _WorkflowDescription;

    public Info PackageDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageDescription));
      }
    }

    public Info PackageType1
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType1), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageType1));
      }
    }

    public Info OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Info SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public Info PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageType));
      }
    }

    public Info TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public Info PackageCreationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageCreationReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageCreationReason));
      }
    }

    public Info CollaboratorTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaboratorTemplate));
      }
    }

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

    public Info PackagePriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackagePriorityCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackagePriorityCode));
      }
    }

    public Info ApprovalTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalTemplate));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info ECOECN
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECOECN), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ECOECN));
      }
    }

    public Info UseContentCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseContentCollaborators), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseContentCollaborators));
      }
    }

    public Info WorkflowAssignApprovers
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowAssignApprovers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowAssignApprovers));
      }
    }

    public Info PackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageOwner));
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

    public Info WorkflowDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowDescription));
      }
    }
  }
}
