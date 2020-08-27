// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveWithThruput_Info
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
  public class MoveWithThruput_Info : CompoundTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Move")]
    protected MoveStd_Info _Move;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Thruput")]
    protected Thruput_Info _Thruput;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_NavigationMode")]
    protected Info _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Close")]
    protected Info _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_MoveAllQty")]
    protected Info _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_OverrideCurrentStatus")]
    protected Info _OverrideCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_ThruputAllQty")]
    protected Info _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_ToResource")]
    protected Info _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_ToWorkflow")]
    protected Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Info_Resource")]
    protected Info _Resource;

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

    public Info NavigationMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NavigationMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NavigationMode));
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

    public Info ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToWorkflow));
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
  }
}
