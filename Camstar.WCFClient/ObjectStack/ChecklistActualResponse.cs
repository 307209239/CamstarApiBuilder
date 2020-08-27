// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChecklistActualResponse
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
  public class ChecklistActualResponse : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ChecklistActualResponse_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChecklistActualResponse_ResponseItem")]
    protected SubentityRef _ResponseItem;

    public override bool Equals(object obj)
    {
      return obj is ChecklistActualResponse && object.Equals((object) this._ExportImportKey, (object) ((ChecklistActualResponse) obj)._ExportImportKey) && object.Equals((object) this._ResponseItem, (object) ((ChecklistActualResponse) obj)._ResponseItem) && base.Equals(obj);
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

    public SubentityRef ResponseItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseItem), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ResponseItem));
      }
    }
  }
}
