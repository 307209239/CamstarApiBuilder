// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GroupStartDetails_Info
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
  public class GroupStartDetails_Info : StartDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_ChildContainers")]
    protected UnitStartDetails_Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_SpecStep")]
    protected Info _SpecStep;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "GroupStartDetails_Info_Location")]
    protected Info _Location;

    public UnitStartDetails_Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (UnitStartDetails_Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Info SpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecStep));
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
