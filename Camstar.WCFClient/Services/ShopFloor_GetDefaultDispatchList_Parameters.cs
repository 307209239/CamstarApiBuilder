// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_GetDefaultDispatchList_Parameters
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
  public class ShopFloor_GetDefaultDispatchList_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "ResultsetSize")]
    protected string _ResultsetSize;
    [DataMember(EmitDefaultValue = false, Name = "QueryParams")]
    protected string _QueryParams;
    [DataMember(EmitDefaultValue = false, Name = "StartRow")]
    protected string _StartRow;

    public string ResultsetSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSize), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ResultsetSize));
      }
    }

    public string QueryParams
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryParams), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (QueryParams));
      }
    }

    public string StartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartRow), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (StartRow));
      }
    }
  }
}
