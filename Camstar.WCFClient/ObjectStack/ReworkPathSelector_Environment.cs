// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkPathSelector_Environment
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
  public class ReworkPathSelector_Environment : PathSelector_Environment
  {
    [Metadata("ReworkPath", "ReworkPath", false, false, true, "NamedSubentityRef", 1049030, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathSelector_Environment_Path")]
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
