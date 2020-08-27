// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CombineHistoryDetail_Info
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
  public class CombineHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_ContainerClosed")]
    protected Info _ContainerClosed;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_CombineAllQty")]
    protected Info _CombineAllQty;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_CloseWhenEmpty")]
    protected Info _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_FromContainer")]
    protected Info _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_ChildContainers")]
    protected Info _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "CombineHistoryDetail_Info_Qty")]
    protected Info _Qty;

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

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
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

    public Info ContainerClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerClosed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerClosed));
      }
    }

    public Info CombineAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CombineAllQty));
      }
    }

    public Info CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Info FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
