// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeCategoryHistory
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
  public class ChangeCategoryHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_FromCategory")]
    protected Enumeration<CategoryEnum, int> _FromCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_NewCategory")]
    protected Enumeration<CategoryEnum, int> _NewCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_TriageComplete")]
    protected Primitive<bool> _TriageComplete;

    public override bool Equals(object obj)
    {
      return obj is ChangeCategoryHistory && object.Equals((object) this._FromCategory, (object) ((ChangeCategoryHistory) obj)._FromCategory) && (object.Equals((object) this._ExportImportKey, (object) ((ChangeCategoryHistory) obj)._ExportImportKey) && object.Equals((object) this._NewCategory, (object) ((ChangeCategoryHistory) obj)._NewCategory)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((ChangeCategoryHistory) obj)._HistoryDetails) && object.Equals((object) this._HistoryId, (object) ((ChangeCategoryHistory) obj)._HistoryId) && object.Equals((object) this._TriageComplete, (object) ((ChangeCategoryHistory) obj)._TriageComplete)) && base.Equals(obj);
    }

    public Enumeration<CategoryEnum, int> FromCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCategory), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (FromCategory));
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

    public Enumeration<CategoryEnum, int> NewCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewCategory), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (NewCategory));
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

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }
  }
}
