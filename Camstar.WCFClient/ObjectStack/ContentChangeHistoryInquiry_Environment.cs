// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContentChangeHistoryInquiry_Environment
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
  public class ContentChangeHistoryInquiry_Environment : ChangePackageInquiry_Environment
  {
    [Metadata("DisplayName", "", false, false, false, "String", 1053067, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_InstanceName")]
    protected Environment _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_Headers")]
    [Metadata("Modeling Audit Trail Header encapsulates the header information captured during every modeling data object maintenance", "ModelingAuditTrailHeader", false, false, false, "ModelingAuditTrailHeader", 1050782, false, true, false, null)]
    protected ModelingAuditTrailHeader_Environment _Headers;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_ChangePackageHeader")]
    [Metadata("Detail information about a change package.", "ChangePackageHeader", false, false, true, "ChangePackageHeader", 1053248, false, false, false, null)]
    protected ChangePackageHeader_Environment _ChangePackageHeader;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 1053240, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_ChangePackage")]
    protected Environment _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_Instances")]
    [Metadata("Change Package Modeling Instance Detail", "CPModelingInstanceDtl", false, false, false, "CPModelingInstanceDtl", 1053260, false, true, false, null)]
    protected CPModelingInstanceDtl_Environment _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_ShowAllPackageHistory")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 0, false, false, false, "1")]
    protected Environment _ShowAllPackageHistory;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778256, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_StartTimestamp")]
    protected Environment _StartTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_ObjectType")]
    [Metadata("Generic String", "", false, false, false, "String", 1050572, false, false, true, null)]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_EndTimestamp")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778254, false, false, false, null)]
    protected Environment _EndTimestamp;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778255, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Environment_LastChangeUser")]
    protected Environment _LastChangeUser;

    public Environment InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceName));
      }
    }

    public ModelingAuditTrailHeader_Environment Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Environment) this.PropertyGet(nameof (Headers));
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

    public CPModelingInstanceDtl_Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Environment) this.PropertyGet(nameof (Instances));
      }
    }

    public Environment ShowAllPackageHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllPackageHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowAllPackageHistory));
      }
    }

    public Environment StartTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartTimestamp));
      }
    }

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Environment EndTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimestamp));
      }
    }

    public Environment LastChangeUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeUser), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastChangeUser));
      }
    }
  }
}
