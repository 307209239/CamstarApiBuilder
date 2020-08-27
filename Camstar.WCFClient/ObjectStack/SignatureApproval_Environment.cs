// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SignatureApproval_Environment
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
  public class SignatureApproval_Environment : ApprovalTxn_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_ApprovingForRole")]
    protected Environment _ApprovingForRole;
    [Metadata("Comments", "", false, false, false, "String", 1051979, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_GeneralInstructions")]
    protected Environment _GeneralInstructions;
    [Metadata("Instruction", "", false, false, false, "String", 1051983, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_SpecialInstructions")]
    protected Environment _SpecialInstructions;
    [Metadata("Comments", "", false, false, false, "String", 1051641, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_Comments")]
    protected new Environment _Comments;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, false, "NamedSubentityRef", 1051639, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_ApprovalSheet")]
    protected new Environment _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_ApprovalDecision")]
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecision", false, true, false, "NamedSubentityRef", 1051620, false, false, true, null)]
    protected Environment _ApprovalDecision;
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, false, "SubentityRef", 1051640, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_ApprovalSheetEntry")]
    protected Environment _ApprovalSheetEntry;
    [Metadata("BaseObject", "BaseObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052267, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Environment_ApprovingFor")]
    protected Environment _ApprovingFor;

    public Environment ApprovingForRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingForRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovingForRole));
      }
    }

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

    public Environment SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public new Environment Comments
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

    public new Environment ApprovalSheet
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

    public Environment ApprovalDecision
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

    public Environment ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetEntry));
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

    public Environment ApprovingFor
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
