// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSpecChanges
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
  public class ChangeMgtSpecChanges : BusinessProcessSpecChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_AllowableRoles")]
    protected NamedObjectRef[] _AllowableRoles;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_StepIcon")]
    protected Primitive<string> _StepIcon;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_MoveStdValidation")]
    protected NamedObjectRef _MoveStdValidation;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_PackageStatus")]
    protected Enumeration<PackageStatusEnum, int> _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_RequiresApproval")]
    protected Primitive<bool> _RequiresApproval;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_LockInstances")]
    protected Primitive<bool> _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_AssignApprovers")]
    protected Primitive<bool> _AssignApprovers;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_ResetApprovals")]
    protected Primitive<bool> _ResetApprovals;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtSpecChanges && this.CompareArrays((Array) this._AllowableRoles, (Array) ((ChangeMgtSpecChanges) obj)._AllowableRoles) && (object.Equals((object) this._StepIcon, (object) ((ChangeMgtSpecChanges) obj)._StepIcon) && object.Equals((object) this._Base, (object) ((ChangeMgtSpecChanges) obj)._Base)) && (object.Equals((object) this._ObjectToChange, (object) ((ChangeMgtSpecChanges) obj)._ObjectToChange) && object.Equals((object) this._MoveStdValidation, (object) ((ChangeMgtSpecChanges) obj)._MoveStdValidation) && (object.Equals((object) this._PackageStatus, (object) ((ChangeMgtSpecChanges) obj)._PackageStatus) && object.Equals((object) this._RequiresApproval, (object) ((ChangeMgtSpecChanges) obj)._RequiresApproval))) && (object.Equals((object) this._LockInstances, (object) ((ChangeMgtSpecChanges) obj)._LockInstances) && object.Equals((object) this._AssignApprovers, (object) ((ChangeMgtSpecChanges) obj)._AssignApprovers) && (object.Equals((object) this._ResetApprovals, (object) ((ChangeMgtSpecChanges) obj)._ResetApprovals) && object.Equals((object) this._Name, (object) ((ChangeMgtSpecChanges) obj)._Name))) && base.Equals(obj);
    }

    public NamedObjectRef[] AllowableRoles
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowableRoles), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (AllowableRoles));
      }
    }

    public Primitive<string> StepIcon
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepIcon), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StepIcon));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef MoveStdValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveStdValidation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MoveStdValidation));
      }
    }

    public Enumeration<PackageStatusEnum, int> PackageStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatus), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>) this.PropertyGet(nameof (PackageStatus));
      }
    }

    public Primitive<bool> RequiresApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiresApproval), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RequiresApproval));
      }
    }

    public Primitive<bool> LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Primitive<bool> AssignApprovers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignApprovers), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AssignApprovers));
      }
    }

    public Primitive<bool> ResetApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetApprovals), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ResetApprovals));
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
