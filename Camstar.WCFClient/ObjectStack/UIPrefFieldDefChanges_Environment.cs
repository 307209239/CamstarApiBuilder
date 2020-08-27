// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPrefFieldDefChanges_Environment
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
  public class UIPrefFieldDefChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("The UI Preference Field Definition will be used to store the information about a User Interface field.  (Position, sequence, etc.)", "UIPrefFieldDef", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_Environment_ListItemToChange")]
    [Metadata("The UI Preference Field Definition will be used to store the information about a User Interface field.  (Position, sequence, etc.)", "UIPrefFieldDefChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Field Expression.", "", false, true, false, "String", 1050370, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Generic Integer", "", true, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDefChanges_Environment_FieldSeq")]
    protected Environment _FieldSeq;

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment FieldSeq
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSeq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldSeq));
      }
    }
  }
}
