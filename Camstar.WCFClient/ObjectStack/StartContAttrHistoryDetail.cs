// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartContAttrHistoryDetail
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
  public class StartContAttrHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_AttributeValue")]
    protected Primitive<string> _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_DataType")]
    protected Enumeration<TrivialTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_LevelName")]
    protected Primitive<string> _LevelName;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_ContainerName")]
    protected Primitive<string> _ContainerName;

    public override bool Equals(object obj)
    {
      return obj is StartContAttrHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((StartContAttrHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._Name, (object) ((StartContAttrHistoryDetail) obj)._Name) && object.Equals((object) this._AttributeValue, (object) ((StartContAttrHistoryDetail) obj)._AttributeValue)) && (object.Equals((object) this._DataType, (object) ((StartContAttrHistoryDetail) obj)._DataType) && object.Equals((object) this._HistoryId, (object) ((StartContAttrHistoryDetail) obj)._HistoryId) && (object.Equals((object) this._LevelName, (object) ((StartContAttrHistoryDetail) obj)._LevelName) && object.Equals((object) this._ContainerName, (object) ((StartContAttrHistoryDetail) obj)._ContainerName))) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> AttributeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeValue));
      }
    }

    public Enumeration<TrivialTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<string> LevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LevelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LevelName));
      }
    }

    public Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }
  }
}
