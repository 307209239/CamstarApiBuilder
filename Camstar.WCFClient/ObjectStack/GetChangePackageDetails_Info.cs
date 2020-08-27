// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetChangePackageDetails_Info
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
  public class GetChangePackageDetails_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_GeneralInstructions")]
    protected Info _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_SourceSystem")]
    protected TargetSystem_Info _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_ApprovalCycleInquiryDetails")]
    protected ApprovalCycleInquiryDetails_Info _ApprovalCycleInquiryDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_CollaboratorDetails")]
    protected CollaboratorDetails_Info _CollaboratorDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_ChangePackage")]
    protected Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_PackageDetails")]
    protected ChangePackageDetails_Info _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Info_ChangePackageHeader")]
    protected ChangePackageHeader_Info _ChangePackageHeader;

    public Info GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public TargetSystem_Info SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Info) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public Info ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public ApprovalCycleInquiryDetails_Info ApprovalCycleInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleInquiryDetails), (object) value);
      }
      get
      {
        return (ApprovalCycleInquiryDetails_Info) this.PropertyGet(nameof (ApprovalCycleInquiryDetails));
      }
    }

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

    public ChangePackageDetails_Info PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ChangePackageDetails_Info) this.PropertyGet(nameof (PackageDetails));
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
  }
}
