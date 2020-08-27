// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceActivationDetails_Info
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
  public class ResourceActivationDetails_Info : MaintReqActivationDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_Info_ClassActivated")]
    protected Info _ClassActivated;
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_Info_ResourceName")]
    protected Info _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_Info_Resource")]
    protected Info _Resource;

    public Info ClassActivated
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassActivated), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClassActivated));
      }
    }

    public Info ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceName));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
