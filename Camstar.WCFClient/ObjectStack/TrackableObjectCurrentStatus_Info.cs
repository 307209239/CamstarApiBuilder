// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackableObjectCurrentStatus_Info
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
  public class TrackableObjectCurrentStatus_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Info_LastMoveDate")]
    protected Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Info_LastMoveDateGMT")]
    protected Info _LastMoveDateGMT;

    public Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
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

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Info LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }
  }
}
