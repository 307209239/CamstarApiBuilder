// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalDecisionListChanges_Environment
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
  public class ApprovalDecisionListChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("A list of decisions that are allowed for an ApprovalSheet.", "ApprovalDecisionList", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecisionChanges", false, true, false, "ApprovalDecisionChanges", 1051690, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListChanges_Environment_ApprovalDecisions")]
    protected ApprovalDecisionChanges_Environment _ApprovalDecisions;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051614, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListChanges_Environment_Name")]
    protected new Environment _Name;

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

    public ApprovalDecisionChanges_Environment ApprovalDecisions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisions), (object) value);
      }
      get
      {
        return (ApprovalDecisionChanges_Environment) this.PropertyGet(nameof (ApprovalDecisions));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
