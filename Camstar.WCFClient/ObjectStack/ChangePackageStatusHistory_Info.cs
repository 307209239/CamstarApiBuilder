// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageStatusHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangePackagePkgStatusHistory_Info))]
  [KnownType(typeof (ChangePackageImpStatusHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChangePackageStatusHistory_Info : TrackableObjectHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_Info_ToStatus")]
    protected Info _ToStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_Info_HistoryId")]
    protected new Info _HistoryId;

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

    public Info ToStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStatus));
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
  }
}
