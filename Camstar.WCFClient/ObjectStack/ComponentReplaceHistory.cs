// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceHistory
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
  public class ComponentReplaceHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistory_HistoryDetails")]
    protected ComponentReplaceHistoryDetail[] _HistoryDetails;

    public override bool Equals(object obj)
    {
      return obj is ComponentReplaceHistory && object.Equals((object) this._ExportImportKey, (object) ((ComponentReplaceHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ComponentReplaceHistory) obj)._HistoryDetails) && base.Equals(obj);
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

    public ComponentReplaceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ComponentReplaceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }
  }
}
