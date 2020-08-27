// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkgHistory_Info
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
  public class DeployChangePkgHistory_Info : ChangePackageHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_Info_ChangePackageName")]
    protected new Info _ChangePackageName;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Info ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
