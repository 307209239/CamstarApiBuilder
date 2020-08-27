// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveTxns_Info
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
  public class MoveTxns_Info : ContainersTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_Services")]
    protected MoveTxn_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_ToWorkflowStack")]
    protected Info _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_ClearToWorkflowStack")]
    protected Info _ClearToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_ToFactory")]
    protected Info _ToFactory;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_ToLocation")]
    protected Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_ToWorkflow")]
    protected Info _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxns_Info_ToStep")]
    protected Info _ToStep;

    public MoveTxn_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (MoveTxn_Info) this.PropertyGet(nameof (Services));
      }
    }

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
