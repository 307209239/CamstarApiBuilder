// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportTargetDetail_Environment
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
  public class ExportTargetDetail_Environment : ExportImportStatus_Environment
  {
    [Metadata("URL", "", false, false, true, "String", 1053220, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Environment_FolderLocation")]
    protected Environment _FolderLocation;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Environment_DeliveryOption")]
    [Metadata("TargetSystemDeliveryOption", "TargetSystemDeliveryOptionEnum", false, false, true, "Integer", 1053222, false, false, false, null)]
    protected Environment _DeliveryOption;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053231, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Environment_ExportImportTargetId")]
    protected Environment _ExportImportTargetId;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053227, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Environment_ExportImportHeaderId")]
    protected Environment _ExportImportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Environment_ExportImportName")]
    [Metadata("Generic String", "", false, false, true, "String", 1050821, false, false, false, null)]
    protected Environment _ExportImportName;

    public Environment FolderLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FolderLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FolderLocation));
      }
    }

    public Environment DeliveryOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeliveryOption));
      }
    }

    public Environment ExportImportTargetId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportTargetId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportTargetId));
      }
    }

    public Environment ExportImportHeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportHeaderId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportHeaderId));
      }
    }

    public Environment ExportImportName
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
  }
}
