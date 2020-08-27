// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCustomDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CAPACustomDetail))]
  [KnownType(typeof (EventCustomDetail))]
  [Serializable]
  public class QualityCustomDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCustomDetail_QualityCustomData")]
    protected SubentityRef _QualityCustomData;

    public override bool Equals(object obj)
    {
      return obj is QualityCustomDetail && object.Equals((object) this._QualityCustomData, (object) ((QualityCustomDetail) obj)._QualityCustomData) && base.Equals(obj);
    }

    public SubentityRef QualityCustomData
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCustomData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (QualityCustomData));
      }
    }
  }
}
