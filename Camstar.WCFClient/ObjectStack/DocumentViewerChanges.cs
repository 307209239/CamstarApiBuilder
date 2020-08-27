// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentViewerChanges
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
  public class DocumentViewerChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_CurrentDirectory")]
    protected Primitive<string> _CurrentDirectory;
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentViewerChanges_CommandLine")]
    protected Primitive<string> _CommandLine;

    public override bool Equals(object obj)
    {
      return obj is DocumentViewerChanges && object.Equals((object) this._ObjectToChange, (object) ((DocumentViewerChanges) obj)._ObjectToChange) && (object.Equals((object) this._CurrentDirectory, (object) ((DocumentViewerChanges) obj)._CurrentDirectory) && object.Equals((object) this._Name, (object) ((DocumentViewerChanges) obj)._Name)) && object.Equals((object) this._CommandLine, (object) ((DocumentViewerChanges) obj)._CommandLine) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> CurrentDirectory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentDirectory), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CurrentDirectory));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<string> CommandLine
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommandLine), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CommandLine));
      }
    }
  }
}
