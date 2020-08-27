// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartContAttrHistoryDetail_Info
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
  public class StartContAttrHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Info_AttributeValue")]
    protected Info _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Info_LevelName")]
    protected Info _LevelName;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Info_ContainerName")]
    protected Info _ContainerName;

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

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info AttributeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeValue));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
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

    public Info LevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LevelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LevelName));
      }
    }

    public Info ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerName));
      }
    }
  }
}
