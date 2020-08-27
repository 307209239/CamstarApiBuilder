// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtTxn_Environment
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
  public class ChangeMgtTxn_Environment : ShopFloor_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 16777408, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_Comments")]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_ChangePackageHeader")]
    [Metadata("Detail information about a change package.", "ChangePackageHeader", false, false, true, "ChangePackageHeader", 1053248, false, false, false, null)]
    protected ChangePackageHeader_Environment _ChangePackageHeader;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 1053240, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_ChangePackage")]
    protected Environment _ChangePackage;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052056, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_IsCollaborator")]
    protected Environment _IsCollaborator;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777761, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_IsRouteRequired")]
    protected Environment _IsRouteRequired;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777635, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_IsOwnerRole")]
    protected Environment _IsOwnerRole;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052934, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_IsApprovalRequired")]
    protected Environment _IsApprovalRequired;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050233, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_WorkflowStepName")]
    protected Environment _WorkflowStepName;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_Revision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    protected Environment _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_WorkflowName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050233, false, false, false, null)]
    protected Environment _WorkflowName;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Environment_Factory")]
    protected new Environment _Factory;

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public ChangePackageHeader_Environment ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Environment) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Environment IsCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsCollaborator));
      }
    }

    public Environment IsRouteRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRouteRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRouteRequired));
      }
    }

    public Environment IsOwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOwnerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsOwnerRole));
      }
    }

    public Environment IsApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsApprovalRequired));
      }
    }

    public Environment WorkflowStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStepName));
      }
    }

    public Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public Environment WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
