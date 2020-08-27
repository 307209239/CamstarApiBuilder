// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SignatureApproval
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
  public class SignatureApproval : ApprovalTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_ApprovingForRole")]
    protected NamedObjectRef _ApprovingForRole;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_ApprovalSheet")]
    protected new NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_ApprovalDecision")]
    protected NamedSubentityRef _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_ApprovalSheetEntry")]
    protected SubentityRef _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "SignatureApproval_ApprovingFor")]
    protected NamedObjectRef _ApprovingFor;

    public override bool Equals(object obj)
    {
      return obj is SignatureApproval && object.Equals((object) this._ApprovingForRole, (object) ((SignatureApproval) obj)._ApprovingForRole) && (object.Equals((object) this._GeneralInstructions, (object) ((SignatureApproval) obj)._GeneralInstructions) && object.Equals((object) this._SpecialInstructions, (object) ((SignatureApproval) obj)._SpecialInstructions)) && (object.Equals((object) this._Comments, (object) ((SignatureApproval) obj)._Comments) && object.Equals((object) this._ApprovalSheet, (object) ((SignatureApproval) obj)._ApprovalSheet) && (object.Equals((object) this._ApprovalDecision, (object) ((SignatureApproval) obj)._ApprovalDecision) && object.Equals((object) this._ApprovalSheetEntry, (object) ((SignatureApproval) obj)._ApprovalSheetEntry))) && (object.Equals((object) this._TrackableObject, (object) ((SignatureApproval) obj)._TrackableObject) && object.Equals((object) this._ApprovingFor, (object) ((SignatureApproval) obj)._ApprovingFor)) && base.Equals(obj);
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

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
      }
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

    public new NamedSubentityRef ApprovalSheet
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

    public new BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
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
