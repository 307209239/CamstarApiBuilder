// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalDecisionListMaint_Environment
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
  public class ApprovalDecisionListMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListMaint_Environment_ObjectListInquiry")]
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionList", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionListChanges", false, false, false, "ApprovalDecisionListChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListMaint_Environment_ObjectChanges")]
    protected ApprovalDecisionListChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListMaint_Environment_ObjectToChange")]
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionList", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ApprovalDecisionListChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ApprovalDecisionListChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
