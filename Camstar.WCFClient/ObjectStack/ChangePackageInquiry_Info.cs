// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageInquiry_Info
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
  public class ChangePackageInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_Info_PackageDetails")]
    protected ChangePackageInquiryDetail_Info _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_Info_PackageOwner")]
    protected Info _PackageOwner;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_Info_PackageName")]
    protected Info _PackageName;

    public ChangePackageInquiryDetail_Info PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ChangePackageInquiryDetail_Info) this.PropertyGet(nameof (PackageDetails));
      }
    }

    public Info PackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageOwner));
      }
    }

    public Info PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageName));
      }
    }
  }
}
