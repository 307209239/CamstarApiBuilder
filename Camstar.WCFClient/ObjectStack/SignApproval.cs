// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SignApproval
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
  public class SignApproval : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_ApprovingForRole")]
    protected NamedObjectRef _ApprovingForRole;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_ApprovalDecision")]
    protected NamedSubentityRef _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_ApprovalSheetEntry")]
    protected SubentityRef _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_ProcessObject")]
    protected NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_ProcessObjectDetails")]
    protected Camstar.WCF.ObjectStack.ProcessObject _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "SignApproval_ApprovingFor")]
    protected NamedObjectRef _ApprovingFor;

    public override bool Equals(object obj)
    {
      return obj is SignApproval && object.Equals((object) this._SpecialInstructions, (object) ((SignApproval) obj)._SpecialInstructions) && (object.Equals((object) this._ApprovingForRole, (object) ((SignApproval) obj)._ApprovingForRole) && object.Equals((object) this._Comments, (object) ((SignApproval) obj)._Comments)) && (object.Equals((object) this._ApprovalDecision, (object) ((SignApproval) obj)._ApprovalDecision) && object.Equals((object) this._ApprovalSheetEntry, (object) ((SignApproval) obj)._ApprovalSheetEntry) && (object.Equals((object) this._ApprovalSheet, (object) ((SignApproval) obj)._ApprovalSheet) && object.Equals((object) this._ProcessObject, (object) ((SignApproval) obj)._ProcessObject))) && (object.Equals((object) this._ProcessObjectDetails, (object) ((SignApproval) obj)._ProcessObjectDetails) && object.Equals((object) this._ApprovingFor, (object) ((SignApproval) obj)._ApprovingFor)) && base.Equals(obj);
    }

    public Primitive<string> SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public NamedObjectRef ApprovingForRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingForRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovingForRole));
      }
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedSubentityRef ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public SubentityRef ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ApprovalSheetEntry));
      }
    }

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Camstar.WCF.ObjectStack.ProcessObject ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ProcessObject) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public NamedObjectRef ApprovingFor
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingFor), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovingFor));
      }
    }
  }
}
