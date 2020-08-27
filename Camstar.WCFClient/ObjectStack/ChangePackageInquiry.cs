// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageInquiry
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
  public class ChangePackageInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_PackageDetails")]
    protected ChangePackageInquiryDetail[] _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_PackageOwner")]
    protected NamedObjectRef _PackageOwner;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_PackageName")]
    protected Primitive<string> _PackageName;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageInquiry && this.CompareArrays((Array) this._PackageDetails, (Array) ((ChangePackageInquiry) obj)._PackageDetails) && (object.Equals((object) this._PackageOwner, (object) ((ChangePackageInquiry) obj)._PackageOwner) && object.Equals((object) this._PackageName, (object) ((ChangePackageInquiry) obj)._PackageName)) && base.Equals(obj);
    }

    public ChangePackageInquiryDetail[] PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ChangePackageInquiryDetail[]) this.PropertyGet(nameof (PackageDetails));
      }
    }

    public NamedObjectRef PackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PackageOwner));
      }
    }

    public Primitive<string> PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageName));
      }
    }
  }
}
