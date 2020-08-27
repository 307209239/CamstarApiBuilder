// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveTxn_Info
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
  public class MoveTxn_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ToWorkflowStack")]
    protected Info _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Step")]
    protected Info _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_NavigationMode")]
    protected Info _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ToSpecStep")]
    protected Info _ToSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Path")]
    protected Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ClearToWorkflowStack")]
    protected Info _ClearToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_OverrideCurrentStatus")]
    protected Info _OverrideCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_TrackStepPass")]
    protected Info _TrackStepPass;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Close")]
    protected Info _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_MoveAllQty")]
    protected Info _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ToResource")]
    protected Info _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ToFactory")]
    protected Info _ToFactory;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Info_ToWorkflow")]
    protected Info _ToWorkflow;

    public Info ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToWorkflowStack));
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

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
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

    public Info ToSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSpecStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToSpecStep));
      }
    }

    public Info WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStack));
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

    public Info ClearToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearToWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClearToWorkflowStack));
      }
    }

    public new Info UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseDispatch));
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

    public Info TrackStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackStepPass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackStepPass));
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

    public new Info Container
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

    public Info ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToFactory));
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
  }
}
