// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_ChangeAttribute_Info
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
  public class V4_ChangeAttribute_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_Info_ContainerStatusDetails")]
    protected ChangeAttributeAsParent_Info _ContainerStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_Info_ServiceDetails")]
    protected ChangeAttributeDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_Info_IncludeChildren")]
    protected Info _IncludeChildren;

    public ChangeAttributeAsParent_Info ContainerStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeAsParent_Info) this.PropertyGet(nameof (ContainerStatusDetails));
      }
    }

    public ChangeAttributeDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
