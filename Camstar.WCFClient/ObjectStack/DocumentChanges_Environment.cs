// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentChanges_Environment
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
  public class DocumentChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1052150, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_FileName")]
    protected Environment _FileName;
    [Metadata("LongString", "", false, false, false, "String", 1052152, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_Identifier")]
    protected Environment _Identifier;
    [Metadata("File directory path", "", false, false, false, "String", 1052149, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_FileLocation")]
    protected Environment _FileLocation;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_BrowseMode")]
    [Metadata("BrowseMode", "BrowseModeEnum", false, false, false, "Integer", 16779316, false, false, true, "2")]
    protected Environment _BrowseMode;
    [Metadata("Enumeration for the Authentication Type:\r\n10 = Basic\r\n20 = None", "AuthenticationTypeEnum", false, false, false, "Integer", 16778999, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_AuthenticationType")]
    protected Environment _AuthenticationType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052151, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_UploadFile")]
    protected Environment _UploadFile;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_IsAttachment")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777539, false, false, false, "0")]
    protected Environment _IsAttachment;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "DocumentBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_Base")]
    protected new Environment _Base;
    [Metadata("Document Viewer allows you to specify the application to use to view the documents that are defined within InSite. A Document Viewer definition contains the location of the application and a command line string that launches the program to display the document. For example, you may define Document Viewers that use Word, Excel, or Portable Document Format (PDF) to view various documents.", "DocumentViewer", false, false, false, "NamedObjectRef", 1048893, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_Viewer")]
    protected Environment _Viewer;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_FileVersion")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1052148, false, false, false, null)]
    protected Environment _FileVersion;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050228, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentChanges_Environment_Name")]
    protected new Environment _Name;

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

    public Environment Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Identifier));
      }
    }

    public Environment FileLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileLocation));
      }
    }

    public Environment BrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrowseMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BrowseMode));
      }
    }

    public Environment AuthenticationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuthenticationType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AuthenticationType));
      }
    }

    public Environment UploadFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (UploadFile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UploadFile));
      }
    }

    public Environment IsAttachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsAttachment));
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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment Viewer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Viewer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Viewer));
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

    public Environment FileVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileVersion), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FileVersion));
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
  }
}
