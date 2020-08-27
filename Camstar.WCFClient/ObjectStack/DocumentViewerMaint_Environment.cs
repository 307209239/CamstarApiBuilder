// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentViewerMaint_Environment
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
  public class DocumentViewerMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Changes CDO for DocumentViewer.", "DocumentViewerChanges", false, false, false, "DocumentViewerChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerMaint_Environment_ObjectChanges")]
    protected DocumentViewerChanges_Environment _ObjectChanges;
    [Metadata("Document Viewer allows you to specify the application to use to view the documents that are defined within InSite. A Document Viewer definition contains the location of the application and a command line string that launches the program to display the document. For example, you may define Document Viewers that use Word, Excel, or Portable Document Format (PDF) to view various documents.", "DocumentViewer", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Document Viewer allows you to specify the application to use to view the documents that are defined within InSite. A Document Viewer definition contains the location of the application and a command line string that launches the program to display the document. For example, you may define Document Viewers that use Word, Excel, or Portable Document Format (PDF) to view various documents.", "DocumentViewer", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public DocumentViewerChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DocumentViewerChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
