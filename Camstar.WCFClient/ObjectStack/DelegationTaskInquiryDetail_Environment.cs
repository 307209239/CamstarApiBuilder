// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationTaskInquiryDetail_Environment
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
  public class DelegationTaskInquiryDetail_Environment : ServiceData_Environment
  {
    [Metadata("Enumeration for Application Type", "ApplicationTypeEnum", false, false, true, "Integer", 1048875, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_ApplicationType")]
    protected Environment _ApplicationType;
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, false, true, "NamedObjectRef", 16778612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_DelegationReason")]
    protected Environment _DelegationReason;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_DelegationTask")]
    [Metadata("Delegation Task is used to configure a delegation task from an assignee to a target employee by date period\r\n", "DelegationTask", false, false, true, "SubentityRef", 16778752, false, false, false, null)]
    protected Environment _DelegationTask;
    [Metadata("Enumeration for DelegationStatus", "DelegationStatusEnum", false, false, false, "Integer", 16778789, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_DelegationStatus")]
    protected Environment _DelegationStatus;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_StartDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049313, false, false, false, null)]
    protected Environment _StartDateGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16778798, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_DelegationForwarding")]
    protected Environment _DelegationForwarding;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_EndDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049310, false, false, false, null)]
    protected Environment _EndDateGMT;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778790, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_TasksDelegated")]
    protected Environment _TasksDelegated;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778754, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_DelegatedBy")]
    protected Environment _DelegatedBy;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_AssignedEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778646, false, false, false, null)]
    protected Environment _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Environment_TargetEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778654, false, false, true, null)]
    protected Environment _TargetEmployee;

    public Environment ApplicationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApplicationType));
      }
    }

    public Environment DelegationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationReason));
      }
    }

    public Environment DelegationTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationTask));
      }
    }

    public Environment DelegationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationStatus));
      }
    }

    public Environment StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Environment DelegationForwarding
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationForwarding), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationForwarding));
      }
    }

    public Environment EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Environment TasksDelegated
    {
      [param: In] set
      {
        this.PropertySet(nameof (TasksDelegated), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TasksDelegated));
      }
    }

    public Environment DelegatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegatedBy));
      }
    }

    public Environment AssignedEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedEmployee));
      }
    }

    public Environment TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
