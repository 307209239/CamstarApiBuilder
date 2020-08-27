// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveOut_Info
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
  public class MoveOut_Info : CompoundTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Thruput")]
    protected Thruput_Info _Thruput;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_ChangeQty")]
    protected ChangeQty_Info _ChangeQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Move")]
    protected MoveStd_Info _Move;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_MoveAllQty")]
    protected Info _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Close")]
    protected Info _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_OverrideCurrentStatus")]
    protected Info _OverrideCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_ThruputReportingLevel")]
    protected Info _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_ToResource")]
    protected Info _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Info_ToStep")]
    protected Info _ToStep;

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

    public Thruput_Info Thruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (Thruput), (object) value);
      }
      get
      {
        return (Thruput_Info) this.PropertyGet(nameof (Thruput));
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

    public ChangeQty_Info ChangeQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQty), (object) value);
      }
      get
      {
        return (ChangeQty_Info) this.PropertyGet(nameof (ChangeQty));
      }
    }

    public new Info MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public MoveStd_Info Move
    {
      [param: In] set
      {
        this.PropertySet(nameof (Move), (object) value);
      }
      get
      {
        return (MoveStd_Info) this.PropertyGet(nameof (Move));
      }
    }

    public new Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
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

    public Info OverrideCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideCurrentStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OverrideCurrentStatus));
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

    public Info ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputReportingLevel));
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
  }
}
