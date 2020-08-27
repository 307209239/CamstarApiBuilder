// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageStatusHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangePackagePkgStatusHistory))]
  [KnownType(typeof (ChangePackageImpStatusHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChangePackageStatusHistory : TrackableObjectHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_ToStatus")]
    protected Primitive<int> _ToStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageStatusHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageStatusHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ChangePackageStatusHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ChangePackageStatusHistory) obj)._ExportImportKey) && object.Equals((object) this._ToStatus, (object) ((ChangePackageStatusHistory) obj)._ToStatus)) && object.Equals((object) this._HistoryId, (object) ((ChangePackageStatusHistory) obj)._HistoryId) && base.Equals(obj);
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

    public Primitive<int> ToStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStatus), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ToStatus));
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
  }
}
