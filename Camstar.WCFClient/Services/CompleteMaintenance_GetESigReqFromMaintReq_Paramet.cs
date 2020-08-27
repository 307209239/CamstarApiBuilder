// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteMaintenance_GetESigReqFromMaintReq_Parameters
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
  public class CompleteMaintenance_GetESigReqFromMaintReq_Parameters : CompleteMaintenance_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReq")]
    protected string _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "Resource")]
    protected string _Resource;

    public string MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (MaintenanceReq));
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
  }
}
