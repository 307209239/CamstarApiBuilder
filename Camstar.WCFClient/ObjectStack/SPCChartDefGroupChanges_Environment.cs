// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDefGroupChanges_Environment
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
  public class SPCChartDefGroupChanges_Environment : NamedObjectGroupChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupChanges_Environment_NewGroup")]
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", false, false, false, "NamedObjectRef", 1049325, false, false, true, null)]
    protected new Environment _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupChanges_Environment_ResolvedEntries")]
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, true, "NamedObjectRef", 1048760, false, true, true, null)]
    protected new Environment _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupChanges_Environment_NewEntry")]
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, false, "NamedObjectRef", 1049324, false, false, true, null)]
    protected new Environment _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupChanges_Environment_ObjectToChange")]
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", false, false, false, "NamedObjectRef", 1048633, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupChanges_Environment_Groups")]
    protected new Environment _Groups;
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, false, "NamedObjectRef", 1048631, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupChanges_Environment_Entries")]
    protected new Environment _Entries;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroupChanges_Environment_EntryType")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048632, false, false, true, "SPCChartDef")]
    protected new Environment _EntryType;

    public new Environment NewGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewGroup));
      }
    }

    public new Environment ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public new Environment NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewEntry));
      }
    }

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
