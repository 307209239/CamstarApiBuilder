// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerAttrHistoryDetail
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
  public class ContainerAttrHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_AttributeName_After")]
    protected Primitive<string> _AttributeName_After;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_AttributeName_Before")]
    protected Primitive<string> _AttributeName_Before;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_AttributeValue_Before")]
    protected Primitive<string> _AttributeValue_Before;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_DataType_After")]
    protected Enumeration<TrivialTypeEnum, int> _DataType_After;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_AttributeValue_After")]
    protected Primitive<string> _AttributeValue_After;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_DataType_Before")]
    protected Enumeration<TrivialTypeEnum, int> _DataType_Before;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ContainerAttrHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((ContainerAttrHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._AttributeName_After, (object) ((ContainerAttrHistoryDetail) obj)._AttributeName_After) && object.Equals((object) this._AttributeName_Before, (object) ((ContainerAttrHistoryDetail) obj)._AttributeName_Before)) && (object.Equals((object) this._AttributeValue_Before, (object) ((ContainerAttrHistoryDetail) obj)._AttributeValue_Before) && object.Equals((object) this._DataType_After, (object) ((ContainerAttrHistoryDetail) obj)._DataType_After) && (object.Equals((object) this._AttributeValue_After, (object) ((ContainerAttrHistoryDetail) obj)._AttributeValue_After) && object.Equals((object) this._DataType_Before, (object) ((ContainerAttrHistoryDetail) obj)._DataType_Before))) && object.Equals((object) this._HistoryId, (object) ((ContainerAttrHistoryDetail) obj)._HistoryId) && base.Equals(obj);
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

    public Primitive<string> AttributeName_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName_After), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeName_After));
      }
    }

    public Primitive<string> AttributeName_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName_Before), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeName_Before));
      }
    }

    public Primitive<string> AttributeValue_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue_Before), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeValue_Before));
      }
    }

    public Enumeration<TrivialTypeEnum, int> DataType_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType_After), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType_After));
      }
    }

    public Primitive<string> AttributeValue_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue_After), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeValue_After));
      }
    }

    public Enumeration<TrivialTypeEnum, int> DataType_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType_Before), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType_Before));
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
  }
}
