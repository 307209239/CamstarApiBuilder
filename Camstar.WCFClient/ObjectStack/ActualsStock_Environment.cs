// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsStock_Environment
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
  public class ActualsStock_Environment : IssueActuals_Environment
  {
    [Metadata("Generic String", "", false, false, false, "String", 1049457, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActualsStock_Environment_FromStockPoint")]
    protected Environment _FromStockPoint;

    public Environment FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStockPoint));
      }
    }
  }
}
