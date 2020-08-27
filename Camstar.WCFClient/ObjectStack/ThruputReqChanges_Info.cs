// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputReqChanges_Info
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
  public class ThruputReqChanges_Info : MaintenanceReqChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_ToleranceQty2")]
    protected Info _ToleranceQty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_WarningQty2")]
    protected Info _WarningQty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_WarningQty")]
    protected Info _WarningQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_ToleranceQty")]
    protected Info _ToleranceQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Info_Qty")]
    protected Info _Qty;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
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

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
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

    public Info ToleranceQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToleranceQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToleranceQty2));
      }
    }

    public Info WarningQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WarningQty2));
      }
    }

    public Info WarningQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WarningQty));
      }
    }

    public Info ToleranceQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToleranceQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToleranceQty));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
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
