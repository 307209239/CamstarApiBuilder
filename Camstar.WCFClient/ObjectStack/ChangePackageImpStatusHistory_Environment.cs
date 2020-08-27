// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageImpStatusHistory_Environment
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
  public class ChangePackageImpStatusHistory_Environment : ChangePackageStatusHistory_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16778941, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageImpStatusHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageImpStatusHistory_Environment_ToStatus")]
    [Metadata("ChangePackageImportStatus", "ChangePackageImportStatusEnum", false, false, true, "Integer", 16778939, false, false, false, null)]
    protected new Environment _ToStatus;

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

    public new Environment ToStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStatus));
      }
    }
  }
}
