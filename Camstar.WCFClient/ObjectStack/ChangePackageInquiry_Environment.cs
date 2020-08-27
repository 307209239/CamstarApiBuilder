// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageInquiry_Environment
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
  public class ChangePackageInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_Environment_PackageDetails")]
    [Metadata("Details about  a change package.", "ChangePackageInquiryDetail", false, false, false, "ChangePackageInquiryDetail", 16777345, false, true, false, null)]
    protected ChangePackageInquiryDetail_Environment _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_Environment_PackageOwner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16777353, false, false, true, null)]
    protected Environment _PackageOwner;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777354, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageInquiry_Environment_PackageName")]
    protected Environment _PackageName;

    public ChangePackageInquiryDetail_Environment PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (ChangePackageInquiryDetail_Environment) this.PropertyGet(nameof (PackageDetails));
      }
    }

    public Environment PackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageOwner));
      }
    }

    public Environment PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageName));
      }
    }
  }
}
