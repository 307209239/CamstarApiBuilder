// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelTagChanges_Environment
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
  public class LabelTagChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_Environment_ListItemToChange")]
    [Metadata("Values that will be substituted into a label template (label printer flat file) at runtime.", "LabelTagChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_Environment_Expression")]
    [Metadata("Field Expression.", "", false, true, false, "String", 1049630, false, false, false, null)]
    protected Environment _Expression;
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_Environment_DefaultValue")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1050637, false, false, false, null)]
    protected Environment _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_Environment_ObjectToChange")]
    [Metadata("Values that will be substituted into a label template (label printer flat file) at runtime.", "LabelTag", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelTagChanges_Environment_Name")]
    protected new Environment _Name;

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

    public Environment Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Expression));
      }
    }

    public Environment DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultValue));
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
