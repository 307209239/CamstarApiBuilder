// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgAttributeHistoryObject_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (OldObject_Info))]
  [KnownType(typeof (NewObject_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChgAttributeHistoryObject_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_Info_ObjectDisplayName")]
    protected Info _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_Info_ObjectRef")]
    protected Info _ObjectRef;

    public Info ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectDisplayName));
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

    public Info ObjectRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectRef));
      }
    }
  }
}
