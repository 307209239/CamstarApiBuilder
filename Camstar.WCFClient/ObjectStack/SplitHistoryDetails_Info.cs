// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SplitHistoryDetails_Info
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
  public class SplitHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_AdjustThruput")]
    protected Info _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_ToContainer")]
    protected Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistoryDetails_Info_Qty")]
    protected Info _Qty;

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

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public Info UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Info AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public Info ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Info ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainer));
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

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
