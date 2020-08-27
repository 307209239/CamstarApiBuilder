// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CancelApprovalSheet_Environment
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
  public class CancelApprovalSheet_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected new Environment _QualityObject;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, true, false, "NamedSubentityRef", 1051639, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Environment_ApprovalSheet")]
    protected Environment _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Environment_FromStage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1051670, false, false, false, null)]
    protected Environment _FromStage;
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1051971, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Environment_ToStage")]
    protected Environment _ToStage;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "ProcessObject", 1051396, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CancelApprovalSheet_Environment_ProcessObjectDetails")]
    protected ProcessObject_Environment _ProcessObjectDetails;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Environment ApprovalSheet
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

    public Environment FromStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStage));
      }
    }

    public Environment ToStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStage));
      }
    }

    public ProcessObject_Environment ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Environment) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}
