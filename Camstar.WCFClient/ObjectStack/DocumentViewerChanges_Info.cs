// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentViewerChanges_Info
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
  public class DocumentViewerChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Info_CurrentDirectory")]
    protected Info _CurrentDirectory;
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Info_CommandLine")]
    protected Info _CommandLine;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info CurrentDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentDirectory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentDirectory));
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

    public Info CommandLine
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommandLine), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CommandLine));
      }
    }
  }
}
