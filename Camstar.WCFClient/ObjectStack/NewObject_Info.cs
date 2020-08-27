// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NewObject_Info
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
  public class NewObject_Info : ChgAttributeHistoryObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Info_ObjectDisplayName")]
    protected new Info _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Info_ObjectRef")]
    protected new Info _ObjectRef;
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Info_HistoryId")]
    protected new Info _HistoryId;

    public new Info ObjectDisplayName
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

    public new Info ObjectRef
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
