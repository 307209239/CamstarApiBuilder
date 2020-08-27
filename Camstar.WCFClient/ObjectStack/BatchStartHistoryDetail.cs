// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStartHistoryDetail
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
  public class BatchStartHistoryDetail : StartHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_BatchStatus")]
    protected Enumeration<BatchStatusEnum, int> _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_BatchComments")]
    protected Primitive<string> _BatchComments;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Qty")]
    protected new Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is BatchStartHistoryDetail && object.Equals((object) this._MasterRecipe, (object) ((BatchStartHistoryDetail) obj)._MasterRecipe) && (object.Equals((object) this._BatchStatus, (object) ((BatchStartHistoryDetail) obj)._BatchStatus) && object.Equals((object) this._BatchComments, (object) ((BatchStartHistoryDetail) obj)._BatchComments)) && object.Equals((object) this._Qty, (object) ((BatchStartHistoryDetail) obj)._Qty) && base.Equals(obj);
    }

    public RevisionedObjectRef MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public Enumeration<BatchStatusEnum, int> BatchStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatus), (object) value);
      }
      get
      {
        return (Enumeration<BatchStatusEnum, int>) this.PropertyGet(nameof (BatchStatus));
      }
    }

    public Primitive<string> BatchComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BatchComments));
      }
    }

    public new Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
