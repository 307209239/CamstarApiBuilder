// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerAttrHistoryDetail_Info
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
  public class ContainerAttrHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_AttributeName_After")]
    protected Info _AttributeName_After;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_AttributeName_Before")]
    protected Info _AttributeName_Before;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_AttributeValue_Before")]
    protected Info _AttributeValue_Before;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_DataType_After")]
    protected Info _DataType_After;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_AttributeValue_After")]
    protected Info _AttributeValue_After;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_DataType_Before")]
    protected Info _DataType_Before;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;

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

    public Info AttributeName_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName_After), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeName_After));
      }
    }

    public Info AttributeName_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName_Before), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeName_Before));
      }
    }

    public Info AttributeValue_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue_Before), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeValue_Before));
      }
    }

    public Info DataType_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType_After), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType_After));
      }
    }

    public Info AttributeValue_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue_After), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeValue_After));
      }
    }

    public Info DataType_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType_Before), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType_Before));
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
  }
}
