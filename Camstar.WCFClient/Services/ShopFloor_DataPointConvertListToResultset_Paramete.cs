// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_DataPointConvertListToResultset_Parameters
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
  public class ShopFloor_DataPointConvertListToResultset_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected string _Value;
    [DataMember(EmitDefaultValue = false, Name = "StartRow")]
    protected string _StartRow;
    [DataMember(EmitDefaultValue = false, Name = "ResultsetSize")]
    protected string _ResultsetSize;
    [DataMember(EmitDefaultValue = false, Name = "DataPoint")]
    protected string _DataPoint;

    public string Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Value));
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

    public string DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (DataPoint));
      }
    }
  }
}
