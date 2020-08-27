// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldReleaseHistoryDetail
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
  public class HoldReleaseHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistoryDetail_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistoryDetail_ContainerReleased")]
    protected ContainerRef _ContainerReleased;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistoryDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistoryDetail_HoldDuration")]
    protected Primitive<double> _HoldDuration;

    public override bool Equals(object obj)
    {
      return obj is HoldReleaseHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((HoldReleaseHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._DisplayName, (object) ((HoldReleaseHistoryDetail) obj)._DisplayName) && object.Equals((object) this._ContainerReleased, (object) ((HoldReleaseHistoryDetail) obj)._ContainerReleased)) && (object.Equals((object) this._HistoryId, (object) ((HoldReleaseHistoryDetail) obj)._HistoryId) && object.Equals((object) this._Container, (object) ((HoldReleaseHistoryDetail) obj)._Container) && object.Equals((object) this._HoldDuration, (object) ((HoldReleaseHistoryDetail) obj)._HoldDuration)) && base.Equals(obj);
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

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public ContainerRef ContainerReleased
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerReleased), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ContainerReleased));
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

    public Primitive<double> HoldDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldDuration), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (HoldDuration));
      }
    }
  }
}
