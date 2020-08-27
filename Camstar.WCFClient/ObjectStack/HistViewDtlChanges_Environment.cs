// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistViewDtlChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (HistViewHistMainlineDtlChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class HistViewDtlChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("Field Expression.", "", false, true, false, "String", 1052288, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_Environment_UIFields")]
    protected Environment _UIFields;
    [Metadata("User Interface (UI) Preference Detail is used to store the fields that are related to a UI Preference instance.  An example is a UI Preference that is used to store the fields to be displayed for the \"current\" information about a Container in the Live History.", "HistViewDtl", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_Environment_ListItemToChange")]
    [Metadata("Changes CDO for UI Preference Detail ", "HistViewDtlChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtlChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050253, false, false, false, null)]
    protected new Environment _Name;

    public Environment UIFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIFields), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIFields));
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
  }
}
