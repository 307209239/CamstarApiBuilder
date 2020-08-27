// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSpecChanges_Environment
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
  public class ChangeMgtSpecChanges_Environment : BusinessProcessSpecChanges_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051554, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_AllowableRoles")]
    protected Environment _AllowableRoles;
    [Metadata("URL", "", false, false, false, "String", 16777285, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_StepIcon")]
    protected Environment _StepIcon;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_Base")]
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpecBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpec", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 16777371, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_MoveStdValidation")]
    protected Environment _MoveStdValidation;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_PackageStatus")]
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, false, "Integer", 16778128, false, false, false, null)]
    protected Environment _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_RequiresApproval")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778040, false, false, false, "0")]
    protected Environment _RequiresApproval;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777682, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_LockInstances")]
    protected Environment _LockInstances;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777605, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_AssignApprovers")]
    protected Environment _AssignApprovers;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777606, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_ResetApprovals")]
    protected Environment _ResetApprovals;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16777284, false, false, false, null)]
    protected new Environment _Name;

    public Environment AllowableRoles
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowableRoles), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowableRoles));
      }
    }

    public Environment StepIcon
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepIcon), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StepIcon));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

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

    public Environment MoveStdValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveStdValidation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MoveStdValidation));
      }
    }

    public Environment PackageStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageStatus));
      }
    }

    public Environment RequiresApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiresApproval), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequiresApproval));
      }
    }

    public Environment LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Environment AssignApprovers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignApprovers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignApprovers));
      }
    }

    public Environment ResetApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetApprovals), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResetApprovals));
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
