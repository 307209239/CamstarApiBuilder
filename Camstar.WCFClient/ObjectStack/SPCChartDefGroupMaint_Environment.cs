// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDefGroupMaint_Environment
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
  public class SPCChartDefGroupMaint_Environment : NamedObjectGroupMaint_Environment
  {
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupMaint_Environment_ObjectChanges")]
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroupChanges", false, false, false, "SPCChartDefGroupChanges", 1048873, true, false, false, null)]
    protected SPCChartDefGroupChanges_Environment _ObjectChanges;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public SPCChartDefGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SPCChartDefGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
