// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (TransferHistory_Info))]
  [KnownType(typeof (ReworkHistory_Info))]
  [KnownType(typeof (ShipHistory_Info))]
  [Serializable]
  public class MoveHistory_Info : MovementHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Qty2")]
    protected new Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_UOM2")]
    protected new Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_ChildCount")]
    protected new Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Close")]
    protected Info _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_ToStepUsage")]
    protected Info _ToStepUsage;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_UnitCount")]
    protected new Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_MoveAllQty")]
    protected Info _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_ElapsedTime")]
    protected new Info _ElapsedTime;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Run")]
    protected new Info _Run;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_ToResource")]
    protected Info _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Qty")]
    protected new Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Setup")]
    protected new Info _Setup;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveHistory_Info_CycleTime")]
    protected new Info _CycleTime;

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

    public Info Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Step));
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

    public Info ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStep));
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

    public Info Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Close));
      }
    }

    public Info ToStepUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStepUsage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStepUsage));
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

    public Info MoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MoveAllQty));
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

    public Info ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToLocation));
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

    public Info ToResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToResource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToResource));
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

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }

    public Info Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Path));
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
  }
}
