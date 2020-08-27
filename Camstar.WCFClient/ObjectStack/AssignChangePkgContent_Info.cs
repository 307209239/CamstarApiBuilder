// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChangePkgContent_Info
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
  public class AssignChangePkgContent_Info : ChangeMgtTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Info_CollaboratorDetails")]
    protected CollaboratorDetails_Info _CollaboratorDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Info_CollaboratorEntry")]
    protected CollaboratorEntryDetails_Info _CollaboratorEntry;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Info_ServiceDetail")]
    protected AssignChangePkgContentDtl_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Info_ChangePackage")]
    protected new Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Info_IsPackageOwner")]
    protected Info _IsPackageOwner;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Info_MaxWhereUsedInstances")]
    protected Info _MaxWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContent_Info_IsCollaborator")]
    protected new Info _IsCollaborator;

    public CollaboratorDetails_Info CollaboratorDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorDetails), (object) value);
      }
      get
      {
        return (CollaboratorDetails_Info) this.PropertyGet(nameof (CollaboratorDetails));
      }
    }

    public CollaboratorEntryDetails_Info CollaboratorEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorEntry), (object) value);
      }
      get
      {
        return (CollaboratorEntryDetails_Info) this.PropertyGet(nameof (CollaboratorEntry));
      }
    }

    public AssignChangePkgContentDtl_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (AssignChangePkgContentDtl_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Info ChangePackage
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

    public Info IsPackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPackageOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsPackageOwner));
      }
    }

    public Info MaxWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWhereUsedInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxWhereUsedInstances));
      }
    }

    public new Info IsCollaborator
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
  }
}
