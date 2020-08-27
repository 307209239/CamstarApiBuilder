// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChangePkgContent_Environment
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
  public class AssignChangePkgContent_Environment : ChangeMgtTxn_Environment
  {
    [Metadata("Service Details to load and save Collaborator Data", "CollaboratorDetails", false, false, false, "CollaboratorDetails", 16778089, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Environment_CollaboratorDetails")]
    protected CollaboratorDetails_Environment _CollaboratorDetails;
    [Metadata("An entry in an collaborator sheet specifies the service details for a single collaborator.", "CollaboratorEntryDetails", false, false, false, "CollaboratorEntryDetails", 16778088, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Environment_CollaboratorEntry")]
    protected CollaboratorEntryDetails_Environment _CollaboratorEntry;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Environment_ServiceDetail")]
    [Metadata("Details for package content for a change package.", "AssignChangePkgContentDtl", false, false, false, "AssignChangePkgContentDtl", 1051158, false, false, false, null)]
    protected AssignChangePkgContentDtl_Environment _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Environment_ChangePackage")]
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1053240, false, false, true, null)]
    protected new Environment _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Environment_IsPackageOwner")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777353, false, false, false, "0")]
    protected Environment _IsPackageOwner;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Environment_MaxWhereUsedInstances")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16778190, false, false, false, null)]
    protected Environment _MaxWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Environment_IsCollaborator")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052056, false, false, false, "0")]
    protected new Environment _IsCollaborator;

    public CollaboratorDetails_Environment CollaboratorDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorDetails), (object) value);
      }
      get
      {
        return (CollaboratorDetails_Environment) this.PropertyGet(nameof (CollaboratorDetails));
      }
    }

    public CollaboratorEntryDetails_Environment CollaboratorEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntry), (object) value);
      }
      get
      {
        return (CollaboratorEntryDetails_Environment) this.PropertyGet(nameof (CollaboratorEntry));
      }
    }

    public AssignChangePkgContentDtl_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (AssignChangePkgContentDtl_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Environment ChangePackage
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

    public Environment IsPackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPackageOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsPackageOwner));
      }
    }

    public Environment MaxWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWhereUsedInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxWhereUsedInstances));
      }
    }

    public new Environment IsCollaborator
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
  }
}
