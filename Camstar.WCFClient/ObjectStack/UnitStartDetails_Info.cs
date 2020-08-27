// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UnitStartDetails_Info
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
  public class UnitStartDetails_Info : StartDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_StartReason")]
    protected new Info _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_SpecStep")]
    protected Info _SpecStep;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_UnitCount")]
    protected new Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_Product")]
    protected new Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Info_Qty")]
    protected new Info _Qty;

    public new Info StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartReason));
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

    public new Info UOM
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

    public new Info UnitCount
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

    public new Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
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

    public new Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public new Info Qty
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
