// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartHistoryDetail_Environment
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
  public class SPCChartHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Environment_FileName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051133, false, false, false, null)]
    protected Environment _FileName;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Environment_FileDirectory")]
    [Metadata("File directory path", "", false, false, true, "String", 1053012, false, false, false, null)]
    protected Environment _FileDirectory;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Environment_SPCChartDef")]
    [Metadata("Defines SPC Charting information for a variable/chart type combination.  Includes designation for rules file, macro, display options, OCAPs and 10 user params to use during chart generation, display and OCAP processing", "SPCChartDef", false, false, true, "NamedObjectRef", 1052637, false, false, false, null)]
    protected Environment _SPCChartDef;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Environment_HistoryDetails")]
    [Metadata("History for the actual violation that were reported for a chart.", "SPCViolationHistoryDetail", false, false, true, "SubentityRef", 1052997, false, true, false, null)]
    protected Environment _HistoryDetails;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Environment_SPCChartDefName")]
    protected Environment _SPCChartDefName;

    public Environment FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileName));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment FileDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileDirectory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileDirectory));
      }
    }

    public Environment SPCChartDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCChartDef));
      }
    }

    public Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment SPCChartDefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCChartDefName));
      }
    }
  }
}
