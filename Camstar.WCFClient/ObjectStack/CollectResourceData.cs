// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectResourceData
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
  public class CollectResourceData : ResourceTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectResourceData_ParametricData")]
    protected new ParametricData _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "CollectResourceData_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;

    public override bool Equals(object obj)
    {
      return obj is CollectResourceData && object.Equals((object) this._ParametricData, (object) ((CollectResourceData) obj)._ParametricData) && object.Equals((object) this._DataCollectionDef, (object) ((CollectResourceData) obj)._DataCollectionDef) && base.Equals(obj);
    }

    public new ParametricData ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData) this.PropertyGet(nameof (ParametricData));
      }
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
