// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerDefectHistoryDetail_Info
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
  public class ContainerDefectHistoryDetail_Info : DefectHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Info_ReasonCode")]
    protected new Info _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Info_DefectCount")]
    protected new Info _DefectCount;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Info_Comment")]
    protected new Info _Comment;

    public new Info ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonCode));
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

    public new Info DefectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefectCount));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public new Info Comment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comment));
      }
    }
  }
}
