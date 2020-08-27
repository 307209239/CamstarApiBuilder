// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTaskHistory_Environment
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
  public class DelegateTaskHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16778690, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, false, true, "NamedObjectRef", 16778612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_DelegationReasonCode")]
    protected Environment _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_DelegationTarget")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 16778652, false, false, false, null)]
    protected Environment _DelegationTarget;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_SourceEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778732, false, false, false, null)]
    protected Environment _SourceEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Environment_TargetEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778654, false, false, false, null)]
    protected Environment _TargetEmployee;

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment DelegationReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationReasonCode));
      }
    }

    public Environment DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationTarget));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment SourceEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceEmployee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceEmployee));
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
