// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Subentity_Info
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
  public class Subentity_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Subentity_Info_ExportImportKey")]
    protected Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Subentity_Info_DisplayName")]
    protected Info _DisplayName;

    public Info ExportImportKey
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

    public Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }
  }
}
