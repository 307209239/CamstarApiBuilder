// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportMappingConfigChanges_Environment
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
  public class ReportMappingConfigChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("FileName - used for fields that specify files.", "", false, true, false, "String", 1051714, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Environment_ReportMappingConfigFile")]
    protected Environment _ReportMappingConfigFile;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Environment_ReportTemplate")]
    [Metadata("FileName - used for fields that specify files.", "", false, true, false, "String", 1051715, false, false, false, null)]
    protected Environment _ReportTemplate;
    [Metadata("Report Mapping Config", "ReportMappingConfig", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051713, false, false, false, null)]
    protected new Environment _Name;

    public Environment ReportMappingConfigFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportMappingConfigFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportMappingConfigFile));
      }
    }

    public Environment ReportTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportTemplate));
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
  }
}
