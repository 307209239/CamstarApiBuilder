// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentViewerChanges_Environment
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
  public class DocumentViewerChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Environment_ObjectToChange")]
    [Metadata("Document Viewer allows you to specify the application to use to view the documents that are defined within InSite. A Document Viewer definition contains the location of the application and a command line string that launches the program to display the document. For example, you may define Document Viewers that use Word, Excel, or Portable Document Format (PDF) to view various documents.", "DocumentViewer", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Optionally specifies the directory to be used as the current directory when the application is launched.", "", false, false, false, "String", 1048884, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Environment_CurrentDirectory")]
    protected Environment _CurrentDirectory;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050062, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Specifies the name of the application to launch and any command line arguments that are required. This string includes an identifier that is to be replaced with a document identifier when the command string is constructed at run-time. For example:\r\n\r\nAcrobat.exe %1\r\n\r\nWhere %1 is to be replaced with a document identifier at run time.", "", false, false, false, "String", 1048885, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Environment_CommandLine")]
    protected Environment _CommandLine;

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

    public Environment CurrentDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentDirectory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentDirectory));
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

    public Environment CommandLine
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommandLine), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CommandLine));
      }
    }
  }
}
