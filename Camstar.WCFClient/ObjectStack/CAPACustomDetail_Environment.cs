// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPACustomDetail_Environment
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
  public class CAPACustomDetail_Environment : QualityCustomDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPACustomDetail_Environment_QualityCustomData")]
    [Metadata("Used to manage customer extensions to CAPA.", "CAPACustomData", false, false, false, "SubentityRef", 1052473, false, false, false, null)]
    protected new Environment _QualityCustomData;

    public new Environment QualityCustomData
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCustomData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityCustomData));
      }
    }
  }
}
