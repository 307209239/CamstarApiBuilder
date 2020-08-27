// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPrefFieldDef_Info
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
  public class UIPrefFieldDef_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Info_FieldSeq")]
    protected Info _FieldSeq;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Info_IsFrozen")]
    protected new Info _IsFrozen;

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
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

    public Info FieldSeq
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSeq), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldSeq));
      }
    }

    public new Info IsFrozen
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
