// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalDecisionListChanges
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
  public class ApprovalDecisionListChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListChanges_ApprovalDecisions")]
    protected ApprovalDecisionChanges[] _ApprovalDecisions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionListChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ApprovalDecisionListChanges && object.Equals((object) this._ObjectToChange, (object) ((ApprovalDecisionListChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._ApprovalDecisions, (Array) ((ApprovalDecisionListChanges) obj)._ApprovalDecisions) && object.Equals((object) this._Name, (object) ((ApprovalDecisionListChanges) obj)._Name)) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ApprovalDecisionChanges[] ApprovalDecisions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisions), (object) value);
      }
      get
      {
        return (ApprovalDecisionChanges[]) this.PropertyGet(nameof (ApprovalDecisions));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
