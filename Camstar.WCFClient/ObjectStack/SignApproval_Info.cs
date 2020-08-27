// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SignApproval_Info
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
  public class SignApproval_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_SpecialInstructions")]
    protected Info _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_ApprovingForRole")]
    protected Info _ApprovingForRole;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_ApprovalDecision")]
    protected Info _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_ApprovalSheetEntry")]
    protected Info _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_ProcessObject")]
    protected Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_ProcessObjectDetails")]
    protected ProcessObject_Info _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Info_ApprovingFor")]
    protected Info _ApprovingFor;

    public Info SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public Info ApprovingForRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingForRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovingForRole));
      }
    }

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public Info ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetEntry));
      }
    }

    public Info ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public ProcessObject_Info ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Info) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public Info ApprovingFor
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingFor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovingFor));
      }
    }
  }
}
