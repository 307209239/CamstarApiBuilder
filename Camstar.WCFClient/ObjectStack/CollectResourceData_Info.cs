// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectResourceData_Info
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
  public class CollectResourceData_Info : ResourceTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectResourceData_Info_ParametricData")]
    protected new ParametricData_Info _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "CollectResourceData_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;

    public new ParametricData_Info ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData_Info) this.PropertyGet(nameof (ParametricData));
      }
    }

    public new Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }
  }
}
