// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceSetupTransition_Info
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
  public class ResourceSetupTransition_Info : ResourceSetup_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetupTransition_Info_ResourceStatusCode")]
    protected new Info _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetupTransition_Info_ResourceStatusReason")]
    protected new Info _ResourceStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetupTransition_Info_Availability")]
    protected new Info _Availability;

    public new Info ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public new Info ResourceStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusReason));
      }
    }

    public new Info Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Availability));
      }
    }
  }
}
