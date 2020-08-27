// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkPathSelectorChanges_Environment
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
  public class ReworkPathSelectorChanges_Environment : PathSelectorChanges_Environment
  {
    [Metadata("ReworkPathChanges", "ReworkPathChanges", false, false, false, "NamedSubentityRef", 1049329, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathSelectorChanges_Environment_Path")]
    protected new Environment _Path;

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
