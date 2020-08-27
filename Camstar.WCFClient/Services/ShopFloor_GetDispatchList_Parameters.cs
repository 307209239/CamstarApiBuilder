// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_GetDispatchList_Parameters
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
  public class ShopFloor_GetDispatchList_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "StartRow")]
    protected string _StartRow;
    [DataMember(EmitDefaultValue = false, Name = "Parameters")]
    protected string _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "ResultsetSize")]
    protected string _ResultsetSize;

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

    public string Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Parameters));
      }
    }

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
  }
}
