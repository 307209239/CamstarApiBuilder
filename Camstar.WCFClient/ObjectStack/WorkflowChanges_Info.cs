// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkflowChanges_Info
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
  public class WorkflowChanges_Info : BusinessProcessWorkflowChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_Gates")]
    protected GateChanges_Info _Gates;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_FirstStep")]
    protected new Info _FirstStep;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_ERPRoute")]
    protected Info _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_Steps")]
    protected new StepChanges_Info _Steps;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_Image")]
    protected Info _Image;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_TotalYield")]
    protected Info _TotalYield;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Info_TotalCycleTime")]
    protected Info _TotalCycleTime;

    public GateChanges_Info Gates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gates), (object) value);
      }
      get
      {
        return (GateChanges_Info) this.PropertyGet(nameof (Gates));
      }
    }

    public new Info FirstStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FirstStep));
      }
    }

    public Info ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public new StepChanges_Info Steps
    {
      [param: In] set
      {
        this.PropertySet(nameof (Steps), (object) value);
      }
      get
      {
        return (StepChanges_Info) this.PropertyGet(nameof (Steps));
      }
    }

    public Info Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Image));
      }
    }

    public Info TotalYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalYield), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalYield));
      }
    }

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

    public new Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
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

    public Info TotalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalCycleTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalCycleTime));
      }
    }
  }
}
