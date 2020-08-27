// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrierDetails_Environment
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
  public class EmptyCarrierDetails_Environment : LossDetails_Environment
  {
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052572, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrierDetails_Environment_RecordAllQty")]
    protected new Environment _RecordAllQty;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052571, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrierDetails_Environment_TypeSortOrder")]
    protected new Environment _TypeSortOrder;

    public new Environment RecordAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordAllQty));
      }
    }

    public new Environment TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TypeSortOrder));
      }
    }
  }
}
