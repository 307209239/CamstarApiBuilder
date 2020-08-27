// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsLotStock_Environment
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
  public class ActualsLotStock_Environment : IssueActuals_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActualsLotStock_Environment_FromStockPoint")]
    [Metadata("Generic String", "", false, false, false, "String", 1049457, false, false, false, null)]
    protected Environment _FromStockPoint;
    [Metadata("Generic String", "", false, true, false, "String", 1049458, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActualsLotStock_Environment_FromLot")]
    protected Environment _FromLot;

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

    public Environment FromLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromLot));
      }
    }
  }
}
