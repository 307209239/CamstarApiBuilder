// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportStatusInquiry_Environment
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
  public class ExportStatusInquiry_Environment : ExportImportInquiry_Environment
  {
    [Metadata("ExportImportType", "ExportImportTypeEnum", false, false, true, "Integer", 1050832, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportStatusInquiry_Environment_ExportImportType")]
    protected new Environment _ExportImportType;

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
  }
}
