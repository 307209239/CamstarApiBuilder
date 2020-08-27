// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageInquiry
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
  public class PackageInquiry : ChangePackageInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_OwnerRole")]
    protected NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_PackageStatuses")]
    protected Enumeration<PackageStatusEnum, int>[] _PackageStatuses;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_PackageWorkflow")]
    protected RevisionedObjectRef _PackageWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_PackageSteps")]
    protected NamedSubentityRef[] _PackageSteps;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_TargetSystem")]
    protected NamedObjectRef _TargetSystem;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_PackageDetails")]
    protected PackageInquiryDetail[] _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_PackageType")]
    protected NamedObjectRef _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_PackagePriorityCode")]
    protected NamedObjectRef _PackagePriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_IsApprover")]
    protected Primitive<bool> _IsApprover;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_IsCollaborator")]
    protected Primitive<bool> _IsCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_IsOwner")]
    protected Primitive<bool> _IsOwner;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_HasApproverRole")]
    protected Primitive<bool> _HasApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_HasOwnerRole")]
    protected Primitive<bool> _HasOwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_SelectedObjectType")]
    protected Primitive<int> _SelectedObjectType;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_IsApprovalCompleted")]
    protected Primitive<bool> _IsApprovalCompleted;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_IsCollaborationCompleted")]
    protected Primitive<bool> _IsCollaborationCompleted;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_SelectedInstance")]
    protected Primitive<string> _SelectedInstance;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_HasCollaboratorRole")]
    protected Primitive<bool> _HasCollaboratorRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_PackageOwner")]
    protected new NamedObjectRef _PackageOwner;

    public override bool Equals(object obj)
    {
      return obj is PackageInquiry && object.Equals((object) this._OwnerRole, (object) ((PackageInquiry) obj)._OwnerRole) && (this.CompareArrays((Array) this._PackageStatuses, (Array) ((PackageInquiry) obj)._PackageStatuses) && object.Equals((object) this._PackageWorkflow, (object) ((PackageInquiry) obj)._PackageWorkflow)) && (this.CompareArrays((Array) this._PackageSteps, (Array) ((PackageInquiry) obj)._PackageSteps) && object.Equals((object) this._TargetSystem, (object) ((PackageInquiry) obj)._TargetSystem) && (this.CompareArrays((Array) this._PackageDetails, (Array) ((PackageInquiry) obj)._PackageDetails) && object.Equals((object) this._PackageType, (object) ((PackageInquiry) obj)._PackageType))) && (object.Equals((object) this._PackagePriorityCode, (object) ((PackageInquiry) obj)._PackagePriorityCode) && object.Equals((object) this._IsApprover, (object) ((PackageInquiry) obj)._IsApprover) && (object.Equals((object) this._IsCollaborator, (object) ((PackageInquiry) obj)._IsCollaborator) && object.Equals((object) this._IsOwner, (object) ((PackageInquiry) obj)._IsOwner)) && (object.Equals((object) this._HasApproverRole, (object) ((PackageInquiry) obj)._HasApproverRole) && object.Equals((object) this._HasOwnerRole, (object) ((PackageInquiry) obj)._HasOwnerRole) && (object.Equals((object) this._SelectedObjectType, (object) ((PackageInquiry) obj)._SelectedObjectType) && object.Equals((object) this._IsApprovalCompleted, (object) ((PackageInquiry) obj)._IsApprovalCompleted)))) && (object.Equals((object) this._IsCollaborationCompleted, (object) ((PackageInquiry) obj)._IsCollaborationCompleted) && object.Equals((object) this._SelectedInstance, (object) ((PackageInquiry) obj)._SelectedInstance) && (object.Equals((object) this._HasCollaboratorRole, (object) ((PackageInquiry) obj)._HasCollaboratorRole) && object.Equals((object) this._PackageOwner, (object) ((PackageInquiry) obj)._PackageOwner))) && base.Equals(obj);
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

    public Enumeration<PackageStatusEnum, int>[] PackageStatuses
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatuses), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>[]) this.PropertyGet(nameof (PackageStatuses));
      }
    }

    public RevisionedObjectRef PackageWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PackageWorkflow));
      }
    }

    public NamedSubentityRef[] PackageSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageSteps), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (PackageSteps));
      }
    }

    public NamedObjectRef TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetSystem));
      }
    }

    public PackageInquiryDetail[] PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (PackageInquiryDetail[]) this.PropertyGet(nameof (PackageDetails));
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

    public Primitive<bool> IsApprover
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprover), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsApprover));
      }
    }

    public Primitive<bool> IsCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborator), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsCollaborator));
      }
    }

    public Primitive<bool> IsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOwner), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsOwner));
      }
    }

    public Primitive<bool> HasApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasApproverRole), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasApproverRole));
      }
    }

    public Primitive<bool> HasOwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasOwnerRole), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasOwnerRole));
      }
    }

    public Primitive<int> SelectedObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObjectType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SelectedObjectType));
      }
    }

    public Primitive<bool> IsApprovalCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalCompleted), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsApprovalCompleted));
      }
    }

    public Primitive<bool> IsCollaborationCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborationCompleted), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsCollaborationCompleted));
      }
    }

    public Primitive<string> SelectedInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstance), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SelectedInstance));
      }
    }

    public Primitive<bool> HasCollaboratorRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasCollaboratorRole), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasCollaboratorRole));
      }
    }

    public new NamedObjectRef PackageOwner
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
  }
}
