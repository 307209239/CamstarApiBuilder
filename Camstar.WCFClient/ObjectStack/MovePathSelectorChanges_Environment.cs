// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MovePathSelectorChanges_Environment
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
  public class MovePathSelectorChanges_Environment : PathSelectorChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelectorChanges_Environment_Expression")]
    [Metadata("Current Value Expression string", "", false, false, false, "String", 1049630, false, false, false, null)]
    protected new Environment _Expression;
    [Metadata("Changes CDO for Path.", "MovePathChanges", false, false, false, "NamedSubentityRef", 1049329, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelectorChanges_Environment_Path")]
    protected new Environment _Path;

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
  }
}
