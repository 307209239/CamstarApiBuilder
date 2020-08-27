// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MovePathSelector_Environment
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
  public class MovePathSelector_Environment : PathSelector_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelector_Environment_Expression")]
    [Metadata("Current Value Expression string", "", false, false, true, "String", 1049630, false, false, false, null)]
    protected new Environment _Expression;
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, true, "NamedSubentityRef", 1049030, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelector_Environment_Path")]
    protected new Environment _Path;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelector_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

    public new Environment Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Expression));
      }
    }

    public new Environment Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Path));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
