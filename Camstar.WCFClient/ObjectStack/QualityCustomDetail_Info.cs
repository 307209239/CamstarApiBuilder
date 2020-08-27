// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityCustomDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (EventCustomDetail_Info))]
  [KnownType(typeof (CAPACustomDetail_Info))]
  [Serializable]
  public class QualityCustomDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityCustomDetail_Info_QualityCustomData")]
    protected Info _QualityCustomData;

    public Info QualityCustomData
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCustomData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityCustomData));
      }
    }
  }
}
