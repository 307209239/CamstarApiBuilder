// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsLotStock_Info
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
  public class ActualsLotStock_Info : IssueActuals_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActualsLotStock_Info_FromStockPoint")]
    protected Info _FromStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ActualsLotStock_Info_FromLot")]
    protected Info _FromLot;

    public Info FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStockPoint));
      }
    }

    public Info FromLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromLot));
      }
    }
  }
}
