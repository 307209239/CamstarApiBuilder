// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeployChangePkgHistory
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
  public class DeployChangePkgHistory : ChangePackageHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DeployChangePkgHistory_ChangePackageName")]
    protected new Primitive<string> _ChangePackageName;

    public override bool Equals(object obj)
    {
      return obj is DeployChangePkgHistory && object.Equals((object) this._ExportImportKey, (object) ((DeployChangePkgHistory) obj)._ExportImportKey) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((DeployChangePkgHistory) obj)._HistoryDetails) && object.Equals((object) this._HistoryId, (object) ((DeployChangePkgHistory) obj)._HistoryId)) && object.Equals((object) this._ChangePackageName, (object) ((DeployChangePkgHistory) obj)._ChangePackageName) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Primitive<string> ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
