// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentEntry_Environment
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
  public class DocumentEntry_Environment : NamedSubentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_FileName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1051133, false, false, false, null)]
    protected Environment _FileName;
    [Metadata("DisplayName", "", false, false, true, "String", 1050248, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_Attachment")]
    [Metadata("Attached Document", "AttachedDoc", false, false, true, "NamedSubentityRef", 1052146, false, false, false, null)]
    protected Environment _Attachment;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_DocumentBrowseMode")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16779312, false, false, false, null)]
    protected Environment _DocumentBrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_DocumentSet")]
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1048646, false, false, false, null)]
    protected Environment _DocumentSet;
    [Metadata("External identifier for a document (Path and file name, URL, etc.)", "", false, false, true, "String", 1049620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_DocumentIdentifier")]
    protected Environment _DocumentIdentifier;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, true, "RevisionedObjectRef", 1048606, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntry_Environment_Document")]
    protected Environment _Document;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment FileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileName));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment Attachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Attachment));
      }
    }

    public Environment DocumentBrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentBrowseMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentBrowseMode));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Environment DocumentIdentifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentIdentifier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentIdentifier));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Document));
      }
    }
  }
}
