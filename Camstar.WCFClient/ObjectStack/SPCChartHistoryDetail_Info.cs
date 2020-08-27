// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartHistoryDetail_Info
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
  public class SPCChartHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Info_FileDirectory")]
    protected Info _FileDirectory;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Info_SPCChartDef")]
    protected Info _SPCChartDef;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Info_HistoryDetails")]
    protected Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartHistoryDetail_Info_SPCChartDefName")]
    protected Info _SPCChartDefName;

    public Info FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileName));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info FileDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileDirectory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileDirectory));
      }
    }

    public Info SPCChartDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCChartDef));
      }
    }

    public Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info SPCChartDefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCChartDefName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCChartDefName));
      }
    }
  }
}
