// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentStatusStartDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (V3_CurrentStatusStartDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MatlContainerCurrentStartDtls_Info))]
  [Serializable]
  public class CurrentStatusStartDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_ReworkStatusStartDetails")]
    protected ReworkStatusStartDetails_Info _ReworkStatusStartDetails;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_ReworkTotalCount")]
    protected Info _ReworkTotalCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_InRework")]
    protected Info _InRework;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_InProcess")]
    protected Info _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Info_Location")]
    protected Info _Location;

    public ReworkStatusStartDetails_Info ReworkStatusStartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkStatusStartDetails), (object) value);
      }
      get
      {
        return (ReworkStatusStartDetails_Info) this.PropertyGet(nameof (ReworkStatusStartDetails));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info ReworkTotalCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkTotalCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkTotalCount));
      }
    }

    public Info InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InRework));
      }
    }

    public Info InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InProcess));
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

    public Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
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
  }
}
