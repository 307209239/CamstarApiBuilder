// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportTargetInquiry_Info
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
  public class ExportTargetInquiry_Info : ExportImportInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Info_ExportImportName")]
    protected new Info _ExportImportName;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Info_ExportImportType")]
    protected new Info _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Info_ExportTargetDetails")]
    protected ExportTargetDetail_Info _ExportTargetDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Info_NumberOfRows")]
    protected Info _NumberOfRows;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Info_StartRow")]
    protected Info _StartRow;

    public new Info ExportImportName
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

    public new Info ExportImportType
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

    public ExportTargetDetail_Info ExportTargetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportTargetDetails), (object) value);
      }
      get
      {
        return (ExportTargetDetail_Info) this.PropertyGet(nameof (ExportTargetDetails));
      }
    }

    public Info NumberOfRows
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberOfRows), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NumberOfRows));
      }
    }

    public Info StartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartRow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartRow));
      }
    }
  }
}
