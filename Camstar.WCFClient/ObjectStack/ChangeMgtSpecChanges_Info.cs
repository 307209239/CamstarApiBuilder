// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSpecChanges_Info
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
  public class ChangeMgtSpecChanges_Info : BusinessProcessSpecChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_AllowableRoles")]
    protected Info _AllowableRoles;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_StepIcon")]
    protected Info _StepIcon;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_MoveStdValidation")]
    protected Info _MoveStdValidation;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_PackageStatus")]
    protected Info _PackageStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_RequiresApproval")]
    protected Info _RequiresApproval;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_LockInstances")]
    protected Info _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_AssignApprovers")]
    protected Info _AssignApprovers;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_ResetApprovals")]
    protected Info _ResetApprovals;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSpecChanges_Info_Name")]
    protected new Info _Name;

    public Info AllowableRoles
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowableRoles), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowableRoles));
      }
    }

    public Info StepIcon
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepIcon), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepIcon));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
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

    public Info MoveStdValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveStdValidation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MoveStdValidation));
      }
    }

    public Info PackageStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageStatus));
      }
    }

    public Info RequiresApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiresApproval), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequiresApproval));
      }
    }

    public Info LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Info AssignApprovers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignApprovers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignApprovers));
      }
    }

    public Info ResetApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetApprovals), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResetApprovals));
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
