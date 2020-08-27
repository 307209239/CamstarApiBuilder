// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalDecisionChanges
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
  public class ApprovalDecisionChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_DecisionType")]
    protected Enumeration<DecisionTypeEnum, int> _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_IncludeComments")]
    protected Primitive<bool> _IncludeComments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ApprovalDecisionChanges && object.Equals((object) this._DecisionType, (object) ((ApprovalDecisionChanges) obj)._DecisionType) && (object.Equals((object) this._ObjectToChange, (object) ((ApprovalDecisionChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((ApprovalDecisionChanges) obj)._ListItemToChange)) && (object.Equals((object) this._IncludeComments, (object) ((ApprovalDecisionChanges) obj)._IncludeComments) && object.Equals((object) this._Name, (object) ((ApprovalDecisionChanges) obj)._Name)) && base.Equals(obj);
    }

    public Enumeration<DecisionTypeEnum, int> DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Enumeration<DecisionTypeEnum, int>) this.PropertyGet(nameof (DecisionType));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<bool> IncludeComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeComments), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeComments));
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
