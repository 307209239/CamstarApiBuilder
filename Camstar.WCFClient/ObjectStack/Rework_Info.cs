// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Rework_Info
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
  public class Rework_Info : MoveTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_ReEntryStep")]
    protected Info _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_Path")]
    protected new Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_NavigationMode")]
    protected new Info _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_ReEntryWorkflowStack")]
    protected Info _ReEntryWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_UseReEntryWorkflowStack")]
    protected Info _UseReEntryWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_ReEntryWorkflow")]
    protected Info _ReEntryWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_EndReworkStep")]
    protected Info _EndReworkStep;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_EndReworkWorkflow")]
    protected Info _EndReworkWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_ReworkReason")]
    protected Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Info_ToStep")]
    protected new Info _ToStep;

    public Info ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public new Info Path
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

    public new Info NavigationMode
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

    public Info ReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReEntryWorkflowStack));
      }
    }

    public Info UseReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseReEntryWorkflowStack));
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

    public Info ReEntryWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReEntryWorkflow));
      }
    }

    public Info EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndReworkStep));
      }
    }

    public Info EndReworkWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndReworkWorkflow));
      }
    }

    public Info ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public new Info ToStep
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
