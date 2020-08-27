// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistActualResponse_Info
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
  public class ChecklistActualResponse_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistActualResponse_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistActualResponse_Info_ResponseItem")]
    protected Info _ResponseItem;

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

    public Info ResponseItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseItem));
      }
    }
  }
}
