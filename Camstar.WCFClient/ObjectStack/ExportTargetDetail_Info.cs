// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportTargetDetail_Info
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
  public class ExportTargetDetail_Info : ExportImportStatus_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Info_FolderLocation")]
    protected Info _FolderLocation;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Info_DeliveryOption")]
    protected Info _DeliveryOption;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Info_ExportImportTargetId")]
    protected Info _ExportImportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Info_ExportImportHeaderId")]
    protected Info _ExportImportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_Info_ExportImportName")]
    protected Info _ExportImportName;

    public Info FolderLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FolderLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FolderLocation));
      }
    }

    public Info DeliveryOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeliveryOption));
      }
    }

    public Info ExportImportTargetId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportTargetId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportTargetId));
      }
    }

    public Info ExportImportHeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportHeaderId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportHeaderId));
      }
    }

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
  }
}
