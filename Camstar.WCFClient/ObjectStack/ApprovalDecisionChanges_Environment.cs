// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalDecisionChanges_Environment
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
  public class ApprovalDecisionChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("The decisions that can be made regarding the approval of an object.", "DecisionTypeEnum", false, false, false, "Integer", 1051625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_Environment_DecisionType")]
    protected Environment _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_Environment_ObjectToChange")]
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecision", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_Environment_ListItemToChange")]
    [Metadata("Defines an option that can be taken for an entry on an approval sheet.", "ApprovalDecisionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_Environment_IncludeComments")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051611, false, false, false, "0")]
    protected Environment _IncludeComments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalDecisionChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051612, false, false, false, null)]
    protected new Environment _Name;

    public Environment DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecisionType));
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment IncludeComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeComments));
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
