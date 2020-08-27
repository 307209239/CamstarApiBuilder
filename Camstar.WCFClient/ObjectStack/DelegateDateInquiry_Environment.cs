// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateDateInquiry_Environment
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
  public class DelegateDateInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_ApplicationFilter")]
    [Metadata("Enumeration for Application Type", "ApplicationTypeEnum", false, false, false, "Integer", 1048875, false, false, true, null)]
    protected Environment _ApplicationFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_DelegationTasks")]
    [Metadata("Delegation Task Inquiry Detail", "DelegationTaskInquiryDetail", false, false, false, "DelegationTaskInquiryDetail", 16778759, false, true, false, null)]
    protected DelegationTaskInquiryDetail_Environment _DelegationTasks;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_DelegationReasonFilter")]
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, false, false, "NamedObjectRef", 16778612, false, false, true, null)]
    protected Environment _DelegationReasonFilter;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778758, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_IsFuture")]
    protected Environment _IsFuture;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_IsActive")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049952, false, false, false, "0")]
    protected Environment _IsActive;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_IsExpired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051470, false, false, false, "0")]
    protected Environment _IsExpired;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_DelegatedByFilter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778754, false, false, true, null)]
    protected Environment _DelegatedByFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_TargetEmployeeFilter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778654, false, false, true, null)]
    protected Environment _TargetEmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Environment_AssignedEmployeeFilter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778646, false, false, true, null)]
    protected Environment _AssignedEmployeeFilter;

    public Environment ApplicationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApplicationFilter));
      }
    }

    public DelegationTaskInquiryDetail_Environment DelegationTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTasks), (object) value);
      }
      get
      {
        return (DelegationTaskInquiryDetail_Environment) this.PropertyGet(nameof (DelegationTasks));
      }
    }

    public Environment DelegationReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationReasonFilter));
      }
    }

    public Environment IsFuture
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFuture), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFuture));
      }
    }

    public Environment IsActive
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsActive), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsActive));
      }
    }

    public Environment IsExpired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsExpired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsExpired));
      }
    }

    public Environment DelegatedByFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedByFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegatedByFilter));
      }
    }

    public Environment TargetEmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployeeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetEmployeeFilter));
      }
    }

    public Environment AssignedEmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployeeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedEmployeeFilter));
      }
    }
  }
}
