// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportMappingConfigChanges_Info
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
  public class ReportMappingConfigChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Info_ReportMappingConfigFile")]
    protected Info _ReportMappingConfigFile;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Info_ReportTemplate")]
    protected Info _ReportTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ReportMappingConfigChanges_Info_Name")]
    protected new Info _Name;

    public Info ReportMappingConfigFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportMappingConfigFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportMappingConfigFile));
      }
    }

    public Info ReportTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportTemplate));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
