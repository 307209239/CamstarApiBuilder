// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ImportContent_Environment
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
  public class ImportContent_Environment : ObjectAlternateKey_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_Environment_ImportStatus")]
    [Metadata("ExportImportDetailStatus", "ExportImportDetailStatusEnum", false, false, true, "Integer", 1050806, false, false, false, null)]
    protected Environment _ImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_Environment_ObjectIsModified")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050802, false, false, false, "0")]
    protected Environment _ObjectIsModified;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050801, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_Environment_ObjectAlreadyExists")]
    protected Environment _ObjectAlreadyExists;

    public Environment ImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImportStatus));
      }
    }

    public Environment ObjectIsModified
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectIsModified), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectIsModified));
      }
    }

    public Environment ObjectAlreadyExists
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectAlreadyExists), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectAlreadyExists));
      }
    }
  }
}
