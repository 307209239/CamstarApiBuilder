// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignSingleCPContent_Info
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
  public class AssignSingleCPContent_Info : AssignChangePkgContent_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContent_Info_ServiceDetail")]
    protected AssignSingleCPContentDtl_Info _ServiceDetail;

    public AssignSingleCPContentDtl_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (AssignSingleCPContentDtl_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
