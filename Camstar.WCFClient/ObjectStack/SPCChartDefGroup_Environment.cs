// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDefGroup_Environment
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
  public class SPCChartDefGroup_Environment : NamedObjectGroup_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroup_Environment_Entries")]
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, true, "NamedObjectRef", 1048631, false, true, false, null)]
    protected new Environment _Entries;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroup_Environment_Groups")]
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", false, false, true, "NamedObjectRef", 1048633, false, true, false, null)]
    protected new Environment _Groups;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroup_Environment_EntryType")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1048632, false, false, false, "SPCChartDef")]
    protected new Environment _EntryType;

    public new Environment Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Entries));
      }
    }

    public new Environment Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Groups));
      }
    }

    public new Environment EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EntryType));
      }
    }
  }
}
