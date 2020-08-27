// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtTxn
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
  public class ChangeMgtTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_ChangePackageHeader")]
    protected ChangePackageHeader _ChangePackageHeader;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_ChangePackage")]
    protected NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_IsCollaborator")]
    protected Primitive<bool> _IsCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_IsRouteRequired")]
    protected Primitive<bool> _IsRouteRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_IsOwnerRole")]
    protected Primitive<bool> _IsOwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_IsApprovalRequired")]
    protected Primitive<bool> _IsApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_WorkflowStepName")]
    protected Primitive<string> _WorkflowStepName;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Revision")]
    protected Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_WorkflowName")]
    protected Primitive<string> _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtTxn_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtTxn && object.Equals((object) this._Comments, (object) ((ChangeMgtTxn) obj)._Comments) && (object.Equals((object) this._ChangePackageHeader, (object) ((ChangeMgtTxn) obj)._ChangePackageHeader) && object.Equals((object) this._ChangePackage, (object) ((ChangeMgtTxn) obj)._ChangePackage)) && (object.Equals((object) this._IsCollaborator, (object) ((ChangeMgtTxn) obj)._IsCollaborator) && object.Equals((object) this._IsRouteRequired, (object) ((ChangeMgtTxn) obj)._IsRouteRequired) && (object.Equals((object) this._IsOwnerRole, (object) ((ChangeMgtTxn) obj)._IsOwnerRole) && object.Equals((object) this._IsApprovalRequired, (object) ((ChangeMgtTxn) obj)._IsApprovalRequired))) && (object.Equals((object) this._WorkflowStepName, (object) ((ChangeMgtTxn) obj)._WorkflowStepName) && object.Equals((object) this._Revision, (object) ((ChangeMgtTxn) obj)._Revision) && (object.Equals((object) this._WorkflowName, (object) ((ChangeMgtTxn) obj)._WorkflowName) && object.Equals((object) this._Factory, (object) ((ChangeMgtTxn) obj)._Factory))) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public ChangePackageHeader ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
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

    public Primitive<bool> IsRouteRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRouteRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRouteRequired));
      }
    }

    public Primitive<bool> IsOwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOwnerRole), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsOwnerRole));
      }
    }

    public Primitive<bool> IsApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsApprovalRequired));
      }
    }

    public Primitive<string> WorkflowStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowStepName));
      }
    }

    public Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public Primitive<string> WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public new NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
