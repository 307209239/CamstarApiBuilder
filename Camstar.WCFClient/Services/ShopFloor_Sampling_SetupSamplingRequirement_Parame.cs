// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_Sampling_SetupSamplingRequirement_Parameters
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
  public class ShopFloor_Sampling_SetupSamplingRequirement_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "StartDetails")]
    protected string _StartDetails;
    [DataMember(EmitDefaultValue = false, Name = "Spec")]
    protected string _Spec;
    [DataMember(EmitDefaultValue = false, Name = "Resource")]
    protected string _Resource;
    [DataMember(EmitDefaultValue = false, Name = "VendorItem")]
    protected string _VendorItem;

    public string StartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDetails), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (StartDetails));
      }
    }

    public string Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Spec));
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

    public string VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (VendorItem));
      }
    }
  }
}
