// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_AddMassUpdateStatement_Parameters
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
  public class ShopFloor_AddMassUpdateStatement_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "QueryName")]
    protected string _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "QueryParameters")]
    protected string _QueryParameters;

    public string QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (QueryName));
      }
    }

    public string QueryParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryParameters), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (QueryParameters));
      }
    }
  }
}
