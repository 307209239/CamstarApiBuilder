// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputHistory_Info
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
  public class ThruputHistory_Info : MovementHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_HistoryDetails")]
    protected ThruputHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_UOM2")]
    protected new Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_ChildCount")]
    protected new Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_UnitCount")]
    protected new Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_ThruputAllQty")]
    protected Info _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Setup")]
    protected new Info _Setup;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_ElapsedTime")]
    protected new Info _ElapsedTime;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Run")]
    protected new Info _Run;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_CycleTime")]
    protected new Info _CycleTime;
    [DataMember(EmitDefaultValue = false, Name = "ThruputHistory_Info_Owner")]
    protected new Info _Owner;

    public new Info Qty2
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

    public ThruputHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ThruputHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Info UOM2
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

    public new Info UOM
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

    public new Info ChildCount
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

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public new Info UnitCount
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

    public Info ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputAllQty));
      }
    }

    public new Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public new Info Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Setup));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public new Info ElapsedTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElapsedTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ElapsedTime));
      }
    }

    public new Info Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Run));
      }
    }

    public new Info Qty
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

    public new Info CycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (CycleTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CycleTime));
      }
    }

    public new Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }
  }
}
