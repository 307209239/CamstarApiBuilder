// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistViewDtl_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (HistViewHistMainlineDtl_Info))]
  [Serializable]
  public class HistViewDtl_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Info_UIFields")]
    protected Info _UIFields;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Info_Parent")]
    protected Info _Parent;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Info_Name")]
    protected new Info _Name;

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

    public Info UIFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIFields), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIFields));
      }
    }

    public Info Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Parent));
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
  }
}
