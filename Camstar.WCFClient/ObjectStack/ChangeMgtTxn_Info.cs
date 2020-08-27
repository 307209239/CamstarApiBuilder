// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtTxn_Info
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
  public class ChangeMgtTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_ChangePackageHeader")]
    protected ChangePackageHeader_Info _ChangePackageHeader;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_ChangePackage")]
    protected Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_IsCollaborator")]
    protected Info _IsCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_IsRouteRequired")]
    protected Info _IsRouteRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_IsOwnerRole")]
    protected Info _IsOwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_IsApprovalRequired")]
    protected Info _IsApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_WorkflowStepName")]
    protected Info _WorkflowStepName;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_Revision")]
    protected Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_WorkflowName")]
    protected Info _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Info_Factory")]
    protected new Info _Factory;

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public ChangePackageHeader_Info ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Info) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public Info ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Info IsCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsCollaborator));
      }
    }

    public Info IsRouteRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRouteRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRouteRequired));
      }
    }

    public Info IsOwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOwnerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsOwnerRole));
      }
    }

    public Info IsApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsApprovalRequired));
      }
    }

    public Info WorkflowStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStepName));
      }
    }

    public Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }

    public Info WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
