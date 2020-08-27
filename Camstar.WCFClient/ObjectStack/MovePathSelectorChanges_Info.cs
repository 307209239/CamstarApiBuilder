// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MovePathSelectorChanges_Info
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
  public class MovePathSelectorChanges_Info : PathSelectorChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelectorChanges_Info_Expression")]
    protected new Info _Expression;
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelectorChanges_Info_Path")]
    protected new Info _Path;

    public new Info Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Expression));
      }
    }

    public new Info Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Path));
      }
    }
  }
}
