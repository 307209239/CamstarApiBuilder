// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteThruputHistoryDetails_Info
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
  public class CompleteThruputHistoryDetails_Info : CompleteMaintHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_LastThruputQty2Limit")]
    protected Info _LastThruputQty2Limit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_LastThruputQty2Warning")]
    protected Info _LastThruputQty2Warning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_ThruputQty2")]
    protected Info _ThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_LastThruputQty2Due")]
    protected Info _LastThruputQty2Due;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_LastThruputQtyLimit")]
    protected Info _LastThruputQtyLimit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_ThruputQty")]
    protected Info _ThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_LastThruputQtyWarning")]
    protected Info _LastThruputQtyWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Info_LastThruputQtyDue")]
    protected Info _LastThruputQtyDue;

    public Info LastThruputQty2Limit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Limit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastThruputQty2Limit));
      }
    }

    public Info LastThruputQty2Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Warning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastThruputQty2Warning));
      }
    }

    public Info ThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputQty2));
      }
    }

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

    public Info LastThruputQty2Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Due), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastThruputQty2Due));
      }
    }

    public Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
      }
    }

    public Info LastThruputQtyLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastThruputQtyLimit));
      }
    }

    public Info ThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputQty));
      }
    }

    public Info LastThruputQtyWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyWarning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastThruputQtyWarning));
      }
    }

    public Info LastThruputQtyDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastThruputQtyDue));
      }
    }
  }
}
