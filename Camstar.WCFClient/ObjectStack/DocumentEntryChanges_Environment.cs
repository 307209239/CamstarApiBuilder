// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentEntryChanges_Environment
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
  public class DocumentEntryChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Environment_Name")]
    [Metadata("DisplayName", "", false, false, false, "String", 1050248, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Environment_DocumentSet")]
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    protected Environment _DocumentSet;
    [Metadata("A Document Entry is used to include a Document in a Document and provide a description for it within the Document Set. If there is more than one Document within a Document Set when a request is made to display a Document Set, the list of Document Entries is used to build a selection list. (Note that a one-to-one relationship between a Document Set and a Document is likely the common scenario).", "DocumentEntry", false, false, false, "NamedSubentityRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048606, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Environment_Document")]
    protected Environment _Document;

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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
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
