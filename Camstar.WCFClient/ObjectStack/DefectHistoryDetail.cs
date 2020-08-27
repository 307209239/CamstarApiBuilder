// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DefectHistoryDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ComponentDefectHistoryDetail))]
  [KnownType(typeof (ContainerDefectHistoryDetail))]
  [Serializable]
  public class DefectHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_DefectCount")]
    protected Primitive<int> _DefectCount;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_Comment")]
    protected Primitive<string> _Comment;
    [DataMember(EmitDefaultValue = false, Name = "DefectHistoryDetail_ReasonCode")]
    protected NamedObjectRef _ReasonCode;

    public override bool Equals(object obj)
    {
      return obj is DefectHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((DefectHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._Container, (object) ((DefectHistoryDetail) obj)._Container) && object.Equals((object) this._HistoryId, (object) ((DefectHistoryDetail) obj)._HistoryId)) && (object.Equals((object) this._DefectCount, (object) ((DefectHistoryDetail) obj)._DefectCount) && object.Equals((object) this._Comment, (object) ((DefectHistoryDetail) obj)._Comment) && object.Equals((object) this._ReasonCode, (object) ((DefectHistoryDetail) obj)._ReasonCode)) && base.Equals(obj);
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

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public Primitive<int> DefectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DefectCount));
      }
    }

    public Primitive<string> Comment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comment), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comment));
      }
    }

    public NamedObjectRef ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReasonCode));
      }
    }
  }
}
