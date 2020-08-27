// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetChangePackageDetails
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
  public class GetChangePackageDetails : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_SourceSystem")]
    protected TargetSystem _SourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_ApprovalCycleInquiryDetails")]
    protected Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails[] _ApprovalCycleInquiryDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_CollaboratorDetails")]
    protected CollaboratorDetails _CollaboratorDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_ChangePackage")]
    protected NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_PackageDetails")]
    protected ChangePackageDetails _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetChangePackageDetails_ChangePackageHeader")]
    protected ChangePackageHeader _ChangePackageHeader;

    public override bool Equals(object obj)
    {
      return obj is GetChangePackageDetails && object.Equals((object) this._GeneralInstructions, (object) ((GetChangePackageDetails) obj)._GeneralInstructions) && (object.Equals((object) this._SourceSystem, (object) ((GetChangePackageDetails) obj)._SourceSystem) && object.Equals((object) this._ApprovalSheet, (object) ((GetChangePackageDetails) obj)._ApprovalSheet)) && (this.CompareArrays((Array) this._ApprovalCycleInquiryDetails, (Array) ((GetChangePackageDetails) obj)._ApprovalCycleInquiryDetails) && object.Equals((object) this._CollaboratorDetails, (object) ((GetChangePackageDetails) obj)._CollaboratorDetails) && (object.Equals((object) this._ChangePackage, (object) ((GetChangePackageDetails) obj)._ChangePackage) && object.Equals((object) this._PackageDetails, (object) ((GetChangePackageDetails) obj)._PackageDetails))) && object.Equals((object) this._ChangePackageHeader, (object) ((GetChangePackageDetails) obj)._ChangePackageHeader) && base.Equals(obj);
    }

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public TargetSystem SourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceSystem), (object) value);
      }
      get
      {
        return (TargetSystem) this.PropertyGet(nameof (SourceSystem));
      }
    }

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails[] ApprovalCycleInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleInquiryDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails[]) this.PropertyGet(nameof (ApprovalCycleInquiryDetails));
      }
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

    public ChangePackageDetails PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ChangePackageDetails) this.PropertyGet(nameof (PackageDetails));
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
  }
}
