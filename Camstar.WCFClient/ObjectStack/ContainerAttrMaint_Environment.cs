// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerAttrMaint_Environment
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
  public class ContainerAttrMaint_Environment : ContainerTxn_Environment
  {
    [Metadata("Used for changes to User Attributes on a Container", "ContainerAttrDetail", false, false, false, "ContainerAttrDetail", 1051953, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrMaint_Environment_ServiceDetails")]
    protected ContainerAttrDetail_Environment _ServiceDetails;

    public ContainerAttrDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ContainerAttrDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
