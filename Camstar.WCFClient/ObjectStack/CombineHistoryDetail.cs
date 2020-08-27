// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CombineHistoryDetail
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
  public class CombineHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_ContainerClosed")]
    protected Primitive<bool> _ContainerClosed;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_CombineAllQty")]
    protected Primitive<bool> _CombineAllQty;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_CloseWhenEmpty")]
    protected Primitive<bool> _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_FromContainer")]
    protected ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_ChildContainers")]
    protected ContainerRef[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is CombineHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((CombineHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._Qty2, (object) ((CombineHistoryDetail) obj)._Qty2) && object.Equals((object) this._HistoryId, (object) ((CombineHistoryDetail) obj)._HistoryId)) && (object.Equals((object) this._ContainerClosed, (object) ((CombineHistoryDetail) obj)._ContainerClosed) && object.Equals((object) this._CombineAllQty, (object) ((CombineHistoryDetail) obj)._CombineAllQty) && (object.Equals((object) this._CloseWhenEmpty, (object) ((CombineHistoryDetail) obj)._CloseWhenEmpty) && object.Equals((object) this._FromContainer, (object) ((CombineHistoryDetail) obj)._FromContainer))) && (this.CompareArrays((Array) this._ChildContainers, (Array) ((CombineHistoryDetail) obj)._ChildContainers) && object.Equals((object) this._Qty, (object) ((CombineHistoryDetail) obj)._Qty)) && base.Equals(obj);
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

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
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

    public Primitive<bool> ContainerClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerClosed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ContainerClosed));
      }
    }

    public Primitive<bool> CombineAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CombineAllQty));
      }
    }

    public Primitive<bool> CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public ContainerRef FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromContainer));
      }
    }

    public ContainerRef[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
