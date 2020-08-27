// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerInquiry_GetChildContainers_Parameters
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
  public class ContainerInquiry_GetChildContainers_Parameters : ContainerInquiry_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "__ResultsetStartRow")]
    protected string ___ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "__ResultsetSizeLimit")]
    protected string ___ResultsetSizeLimit;

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
  }
}
