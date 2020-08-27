// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_ValidateMaintenanceUOM_Parameters
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
  public class ShopFloor_ValidateMaintenanceUOM_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "UOM")]
    protected string _UOM;
    [DataMember(EmitDefaultValue = false, Name = "Resource")]
    protected string _Resource;
    [DataMember(EmitDefaultValue = false, Name = "UOM2")]
    protected string _UOM2;

    public string UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (UOM));
      }
    }

    public string Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Resource));
      }
    }

    public string UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (UOM2));
      }
    }
  }
}
