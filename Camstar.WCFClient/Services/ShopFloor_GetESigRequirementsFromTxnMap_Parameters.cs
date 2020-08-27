// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_GetESigRequirementsFromTxnMap_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ShopFloor_GetESigRequirementsFromTxnMap_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigTxnMap")]
    protected string _ESigTxnMap;

    public string ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ESigTxnMap));
      }
    }
  }
}
