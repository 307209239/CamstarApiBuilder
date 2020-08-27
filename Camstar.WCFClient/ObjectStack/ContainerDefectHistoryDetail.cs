// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerDefectHistoryDetail
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
  public class ContainerDefectHistoryDetail : DefectHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_ReasonCode")]
    protected new NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_DefectCount")]
    protected new Primitive<int> _DefectCount;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectHistoryDetail_Comment")]
    protected new Primitive<string> _Comment;

    public override bool Equals(object obj)
    {
      return obj is ContainerDefectHistoryDetail && object.Equals((object) this._ReasonCode, (object) ((ContainerDefectHistoryDetail) obj)._ReasonCode) && (object.Equals((object) this._ExportImportKey, (object) ((ContainerDefectHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._DefectCount, (object) ((ContainerDefectHistoryDetail) obj)._DefectCount)) && (object.Equals((object) this._HistoryId, (object) ((ContainerDefectHistoryDetail) obj)._HistoryId) && object.Equals((object) this._Container, (object) ((ContainerDefectHistoryDetail) obj)._Container) && object.Equals((object) this._Comment, (object) ((ContainerDefectHistoryDetail) obj)._Comment)) && base.Equals(obj);
    }

    public new NamedObjectRef ReasonCode
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

    public new Primitive<int> DefectCount
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

    public new ContainerRef Container
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

    public new Primitive<string> Comment
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
  }
}
