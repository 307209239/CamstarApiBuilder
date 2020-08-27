// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentEntry_Info
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
  public class DocumentEntry_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_FileName")]
    protected Info _FileName;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_Attachment")]
    protected Info _Attachment;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_DocumentBrowseMode")]
    protected Info _DocumentBrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_DocumentIdentifier")]
    protected Info _DocumentIdentifier;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Info_Document")]
    protected Info _Document;

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

    public Info FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FileName));
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

    public Info Attachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Attachment));
      }
    }

    public Info DocumentBrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentBrowseMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentBrowseMode));
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

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Info DocumentIdentifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentIdentifier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentIdentifier));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Document));
      }
    }
  }
}
