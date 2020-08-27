// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachments_Info
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
  public class DocAttachments_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachments_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachments_Info_Documents")]
    protected AttachedDoc_Info _Documents;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachments_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public AttachedDoc_Info Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (AttachedDoc_Info) this.PropertyGet(nameof (Documents));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
