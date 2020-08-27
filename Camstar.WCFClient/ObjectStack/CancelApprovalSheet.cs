// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CancelApprovalSheet
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
  public class CancelApprovalSheet : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_FromStage")]
    protected Enumeration<StageEnum, int> _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_ToStage")]
    protected Enumeration<StageEnum, int> _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_ProcessObjectDetails")]
    protected ProcessObject _ProcessObjectDetails;

    public override bool Equals(object obj)
    {
      return obj is CancelApprovalSheet && object.Equals((object) this._QualityObject, (object) ((CancelApprovalSheet) obj)._QualityObject) && (object.Equals((object) this._ApprovalSheet, (object) ((CancelApprovalSheet) obj)._ApprovalSheet) && object.Equals((object) this._FromStage, (object) ((CancelApprovalSheet) obj)._FromStage)) && (object.Equals((object) this._ToStage, (object) ((CancelApprovalSheet) obj)._ToStage) && object.Equals((object) this._ProcessObjectDetails, (object) ((CancelApprovalSheet) obj)._ProcessObjectDetails)) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
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

    public Enumeration<StageEnum, int> FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (FromStage));
      }
    }

    public Enumeration<StageEnum, int> ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (ToStage));
      }
    }

    public ProcessObject ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}
