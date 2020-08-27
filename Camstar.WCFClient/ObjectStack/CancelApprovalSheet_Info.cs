// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CancelApprovalSheet_Info
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
  public class CancelApprovalSheet_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Info_FromStage")]
    protected Info _FromStage;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Info_ToStage")]
    protected Info _ToStage;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Info_ProcessObjectDetails")]
    protected ProcessObject_Info _ProcessObjectDetails;

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
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

    public Info FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStage));
      }
    }

    public Info ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStage));
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
  }
}
