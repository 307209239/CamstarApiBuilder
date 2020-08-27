// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentMaint_Environment
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
  public class DocumentMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("Changes CDO for Document.", "DocumentChanges", false, false, false, "DocumentChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Environment_ObjectChanges")]
    protected DocumentChanges_Environment _ObjectChanges;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 16777566, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Environment_DocumentRevision")]
    protected Environment _DocumentRevision;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050228, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Environment_DocumentName")]
    protected Environment _DocumentName;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777565, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Environment_DocumentProxy")]
    protected Environment _DocumentProxy;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "DocumentBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "DocumentBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public DocumentChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DocumentChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentRevision));
      }
    }

    public Environment DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentName));
      }
    }

    public Environment DocumentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentProxy));
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

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
