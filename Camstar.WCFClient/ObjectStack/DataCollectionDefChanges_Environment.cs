// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataCollectionDefChanges_Environment
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
  public class DataCollectionDefChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_ParametricDataControl")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049965, false, false, false, null)]
    protected Environment _ParametricDataControl;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_SPCChartDefGroup")]
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", false, false, false, "NamedObjectRef", 1052641, false, false, true, null)]
    protected Environment _SPCChartDefGroup;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_SPCChartDefEntries")]
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, true, "NamedObjectRef", 1048760, false, true, true, null)]
    protected Environment _SPCChartDefEntries;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_SPCChartDefGroupProxy")]
    [Metadata("Contains a list of SPCCharts that can be executed/generated/plotted at the same time.  Often hooked to the DataColelctionDefinition or Task CDOs for execution after a successful dcata collection transaction", "SPCChartDefGroup", true, false, false, "SPCChartDefGroup", 1052642, false, false, false, null)]
    protected SPCChartDefGroup_Environment _SPCChartDefGroupProxy;
    [Metadata("A web part is a piece of a web page that performs a specific function, but is not intended to run as a page on its own", "WebPart", false, false, false, "NamedObjectRef", 1052990, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_WebPart")]
    protected Environment _WebPart;
    [Metadata("RevisionBase refers to attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.  The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.", "RevisionBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_ParametricDataDefType")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050394, false, false, true, null)]
    protected Environment _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_IsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    protected new Environment _IsRevOfRcd;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050227, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1049436, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataCollectionDefChanges_Environment_ParametricDataDef")]
    protected Environment _ParametricDataDef;

    public Environment ParametricDataControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataControl));
      }
    }

    public Environment SPCChartDefGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCChartDefGroup));
      }
    }

    public Environment SPCChartDefEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefEntries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCChartDefEntries));
      }
    }

    public SPCChartDefGroup_Environment SPCChartDefGroupProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefGroupProxy), (object) value);
      }
      get
      {
        return (SPCChartDefGroup_Environment) this.PropertyGet(nameof (SPCChartDefGroupProxy));
      }
    }

    public Environment WebPart
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebPart), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WebPart));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public new Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
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

    public Environment ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataDef));
      }
    }
  }
}
