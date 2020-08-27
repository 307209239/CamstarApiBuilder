// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportInquiry_Info
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
  public class ExportImportInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Info_ExportImportName")]
    protected Info _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Info_StatusDetails")]
    protected ExportImportStatus_Info _StatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Info_ExportImportType")]
    protected Info _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Info_LogStartRow")]
    protected Info _LogStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportInquiry_Info_IncludeLog")]
    protected Info _IncludeLog;

    public Info ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public ExportImportStatus_Info StatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusDetails), (object) value);
      }
      get
      {
        return (ExportImportStatus_Info) this.PropertyGet(nameof (StatusDetails));
      }
    }

    public Info ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportType));
      }
    }

    public Info LogStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogStartRow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LogStartRow));
      }
    }

    public Info IncludeLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeLog), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeLog));
      }
    }
  }
}
