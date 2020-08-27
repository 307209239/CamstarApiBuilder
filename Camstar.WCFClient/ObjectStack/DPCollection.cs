// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollection
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
  public class DPCollection : ParametricData
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollection_DPCollectionGroups")]
    protected DPCollectionGroupDetail[] _DPCollectionGroups;

    public override bool Equals(object obj)
    {
      return obj is DPCollection && this.CompareArrays((Array) this._DPCollectionGroups, (Array) ((DPCollection) obj)._DPCollectionGroups) && base.Equals(obj);
    }

    public DPCollectionGroupDetail[] DPCollectionGroups
    {
      [param: In] set
      {
        this.PropertySet(nameof (DPCollectionGroups), (object) value);
      }
      get
      {
        return (DPCollectionGroupDetail[]) this.PropertyGet(nameof (DPCollectionGroups));
      }
    }
  }
}
