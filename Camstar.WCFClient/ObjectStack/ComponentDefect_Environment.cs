// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDefect_Environment
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
  public class ComponentDefect_Environment : Defect_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefect_Environment_ServiceDetails")]
    [Metadata("ComponentDefect transaction detail.", "ComponentDefectDetail", false, true, false, "ComponentDefectDetail", 1049639, false, true, false, null)]
    protected ComponentDefectDetail_Environment _ServiceDetails;

    public ComponentDefectDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentDefectDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
