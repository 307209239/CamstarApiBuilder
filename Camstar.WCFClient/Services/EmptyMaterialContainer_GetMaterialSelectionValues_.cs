// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EmptyMaterialContainer_GetMaterialSelectionValues_Parameters
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
  public class EmptyMaterialContainer_GetMaterialSelectionValues_Parameters : EmptyMaterialContainer_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "__ResultsetSizeLimit")]
    protected string ___ResultsetSizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "__Parameters")]
    protected string ___Parameters;
    [DataMember(EmitDefaultValue = false, Name = "ContainerFilter")]
    protected string _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "__ResultsetStartRow")]
    protected string ___ResultsetStartRow;

    public string __ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (__ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (__ResultsetSizeLimit));
      }
    }

    public string __Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (__Parameters), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (__Parameters));
      }
    }

    public string ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public string __ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (__ResultsetStartRow), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (__ResultsetStartRow));
      }
    }
  }
}
