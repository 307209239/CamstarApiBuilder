// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPACustomDetail
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
  public class CAPACustomDetail : QualityCustomDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPACustomDetail_QualityCustomData")]
    protected new SubentityRef _QualityCustomData;

    public override bool Equals(object obj)
    {
      return obj is CAPACustomDetail && object.Equals((object) this._QualityCustomData, (object) ((CAPACustomDetail) obj)._QualityCustomData) && base.Equals(obj);
    }

    public new SubentityRef QualityCustomData
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
