﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssueHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BatchDispenseHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RecipeDispenseHistory))]
  [Serializable]
  public class ComponentIssueHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_HistoryDetails")]
    protected IssueHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_BillControl")]
    protected Primitive<bool> _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ComponentIssueHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ComponentIssueHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ComponentIssueHistory) obj)._ExportImportKey) && object.Equals((object) this._BillControl, (object) ((ComponentIssueHistory) obj)._BillControl)) && object.Equals((object) this._HistoryId, (object) ((ComponentIssueHistory) obj)._HistoryId) && base.Equals(obj);
    }

    public IssueHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (IssueHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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

    public Primitive<bool> BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BillControl));
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
