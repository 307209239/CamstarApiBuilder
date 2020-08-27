// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttrDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerMaintDetail))]
  [Serializable]
  public class ChgContainerAttrDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrDetail_PreHistoryDetail")]
    protected SubentityRef _PreHistoryDetail;

    public override bool Equals(object obj)
    {
      return obj is ChgContainerAttrDetail && object.Equals((object) this._PreHistoryDetail, (object) ((ChgContainerAttrDetail) obj)._PreHistoryDetail) && base.Equals(obj);
    }

    public SubentityRef PreHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (PreHistoryDetail));
      }
    }
  }
}
