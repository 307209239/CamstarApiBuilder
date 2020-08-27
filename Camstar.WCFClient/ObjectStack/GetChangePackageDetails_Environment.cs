// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetChangePackageDetails_Environment
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
  public class GetChangePackageDetails_Environment : Inquiry_Environment
  {
    [Metadata("Instruction", "", false, false, true, "String", 1051979, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_GeneralInstructions")]
    protected Environment _GeneralInstructions;
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "TargetSystem", 16777320, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_SourceSystem")]
    protected TargetSystem_Environment _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_ApprovalSheet")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, false, "NamedSubentityRef", 1051639, false, false, false, null)]
    protected Environment _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_ApprovalCycleInquiryDetails")]
    [Metadata("The detail information for the ApprovalCycleInquiry.", "ApprovalCycleInquiryDetails", false, false, false, "ApprovalCycleInquiryDetails", 1051691, false, true, false, null)]
    protected ApprovalCycleInquiryDetails_Environment _ApprovalCycleInquiryDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_CollaboratorDetails")]
    [Metadata("Service Details to load and save Collaborator Data", "CollaboratorDetails", false, false, false, "CollaboratorDetails", 16778089, false, false, false, null)]
    protected CollaboratorDetails_Environment _CollaboratorDetails;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 1053240, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_ChangePackage")]
    protected Environment _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_PackageDetails")]
    [Metadata("Details of GetChangePackageDetails service", "ChangePackageDetails", false, false, false, "ChangePackageDetails", 16777345, true, false, false, null)]
    protected ChangePackageDetails_Environment _PackageDetails;
    [Metadata("Detail information about a change package.", "ChangePackageHeader", false, false, false, "ChangePackageHeader", 1053248, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_Environment_ChangePackageHeader")]
    protected ChangePackageHeader_Environment _ChangePackageHeader;

    public Environment GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public TargetSystem_Environment SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Environment) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public Environment ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public ApprovalCycleInquiryDetails_Environment ApprovalCycleInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleInquiryDetails), (object) value);
      }
      get
      {
        return (ApprovalCycleInquiryDetails_Environment) this.PropertyGet(nameof (ApprovalCycleInquiryDetails));
      }
    }

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

    public ChangePackageDetails_Environment PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ChangePackageDetails_Environment) this.PropertyGet(nameof (PackageDetails));
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
  }
}
