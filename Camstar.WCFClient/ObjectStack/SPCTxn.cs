// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCTxn
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
  public class SPCTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCTxn_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;

    public override bool Equals(object obj)
    {
      return obj is SPCTxn && object.Equals((object) this._DataCollectionDef, (object) ((SPCTxn) obj)._DataCollectionDef) && base.Equals(obj);
    }

    public new RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }
  }
}
