// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistViewHistMainlineDtl_Environment
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
  public class HistViewHistMainlineDtl_Environment : HistViewDtl_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HistViewHistMainlineDtl_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050254, false, false, false, null)]
    protected new Environment _Name;

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
