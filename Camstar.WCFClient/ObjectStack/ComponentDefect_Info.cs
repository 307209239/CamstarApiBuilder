// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDefect_Info
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
  public class ComponentDefect_Info : Defect_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefect_Info_ServiceDetails")]
    protected ComponentDefectDetail_Info _ServiceDetails;

    public ComponentDefectDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentDefectDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
