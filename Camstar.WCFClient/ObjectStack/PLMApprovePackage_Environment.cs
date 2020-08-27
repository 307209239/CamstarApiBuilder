// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PLMApprovePackage_Environment
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
  public class PLMApprovePackage_Environment : SignatureApproval_Environment
  {
    [Metadata("URL", "", false, false, false, "String", 16777612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Environment_PLMApprovalURL")]
    protected Environment _PLMApprovalURL;
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecision", false, true, false, "NamedSubentityRef", 16777610, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Environment_ApprovalDecision")]
    protected new Environment _ApprovalDecision;
    [Metadata("Brief Description", "", false, false, false, "String", 16777611, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Environment_PLMApprovalCode")]
    protected Environment _PLMApprovalCode;
    [Metadata("BaseObject", "BaseObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052267, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Environment_ApprovingFor")]
    protected new Environment _ApprovingFor;

    public Environment PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public new Environment ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public Environment PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public new Environment ApprovingFor
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingFor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovingFor));
      }
    }
  }
}
