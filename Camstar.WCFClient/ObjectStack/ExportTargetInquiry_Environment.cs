// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportTargetInquiry_Environment
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
  public class ExportTargetInquiry_Environment : ExportImportInquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Environment_ExportImportName")]
    [Metadata("ExportImportName", "", false, false, false, "String", 1050821, false, false, true, null)]
    protected new Environment _ExportImportName;
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, false, true, "Integer", 1050832, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Environment_ExportImportType")]
    protected new Environment _ExportImportType;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Environment_ExportTargetDetails")]
    [Metadata("Target information for an export.", "ExportTargetDetail", false, false, true, "ExportTargetDetail", 1053226, false, true, false, null)]
    protected ExportTargetDetail_Environment _ExportTargetDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Environment_NumberOfRows")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053229, false, false, false, null)]
    protected Environment _NumberOfRows;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetInquiry_Environment_StartRow")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053269, false, false, false, null)]
    protected Environment _StartRow;

    public new Environment ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportName));
      }
    }

    public new Environment ExportImportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportType));
      }
    }

    public ExportTargetDetail_Environment ExportTargetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportTargetDetails), (object) value);
      }
      get
      {
        return (ExportTargetDetail_Environment) this.PropertyGet(nameof (ExportTargetDetails));
      }
    }

    public Environment NumberOfRows
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberOfRows), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NumberOfRows));
      }
    }

    public Environment StartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartRow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartRow));
      }
    }
  }
}
