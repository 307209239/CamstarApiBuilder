// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStartHistoryDetail_Info
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
  public class BatchStartHistoryDetail_Info : StartHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Info_MasterRecipe")]
    protected Info _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Info_BatchStatus")]
    protected Info _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Info_BatchComments")]
    protected Info _BatchComments;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Info_Qty")]
    protected new Info _Qty;

    public Info MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public Info BatchStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BatchStatus));
      }
    }

    public Info BatchComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BatchComments));
      }
    }

    public new Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
