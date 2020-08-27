// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChangePkgContent
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
  public class AssignChangePkgContent : ChangeMgtTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_CollaboratorDetails")]
    protected CollaboratorDetails _CollaboratorDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_CollaboratorEntry")]
    protected CollaboratorEntryDetails _CollaboratorEntry;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_ServiceDetail")]
    protected AssignChangePkgContentDtl _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_ChangePackage")]
    protected new NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_IsPackageOwner")]
    protected Primitive<bool> _IsPackageOwner;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_MaxWhereUsedInstances")]
    protected Primitive<int> _MaxWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_IsCollaborator")]
    protected new Primitive<bool> _IsCollaborator;

    public override bool Equals(object obj)
    {
      return obj is AssignChangePkgContent && object.Equals((object) this._CollaboratorDetails, (object) ((AssignChangePkgContent) obj)._CollaboratorDetails) && (object.Equals((object) this._CollaboratorEntry, (object) ((AssignChangePkgContent) obj)._CollaboratorEntry) && object.Equals((object) this._ServiceDetail, (object) ((AssignChangePkgContent) obj)._ServiceDetail)) && (object.Equals((object) this._ChangePackage, (object) ((AssignChangePkgContent) obj)._ChangePackage) && object.Equals((object) this._IsPackageOwner, (object) ((AssignChangePkgContent) obj)._IsPackageOwner) && (object.Equals((object) this._MaxWhereUsedInstances, (object) ((AssignChangePkgContent) obj)._MaxWhereUsedInstances) && object.Equals((object) this._IsCollaborator, (object) ((AssignChangePkgContent) obj)._IsCollaborator))) && base.Equals(obj);
    }

    public CollaboratorDetails CollaboratorDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorDetails), (object) value);
      }
      get
      {
        return (CollaboratorDetails) this.PropertyGet(nameof (CollaboratorDetails));
      }
    }

    public CollaboratorEntryDetails CollaboratorEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntry), (object) value);
      }
      get
      {
        return (CollaboratorEntryDetails) this.PropertyGet(nameof (CollaboratorEntry));
      }
    }

    public AssignChangePkgContentDtl ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (AssignChangePkgContentDtl) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new NamedObjectRef ChangePackage
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

    public Primitive<bool> IsPackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPackageOwner), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsPackageOwner));
      }
    }

    public Primitive<int> MaxWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWhereUsedInstances), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaxWhereUsedInstances));
      }
    }

    public new Primitive<bool> IsCollaborator
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
  }
}
